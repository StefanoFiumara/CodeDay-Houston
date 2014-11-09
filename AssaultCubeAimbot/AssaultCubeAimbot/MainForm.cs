using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using ProcessMemoryReaderLib;

namespace AssaultCubeAimbot
{
    public partial class MainForm : Form
    {
        Process[] MyProcesses;
        ProcessModule MainModule;
        ProcessMemoryReader MemReader = new ProcessMemoryReader();
        PlayerData MainPlayer = new PlayerData();

        #region ------Addresses------
        int MainPlayerBase = 0x50F4F4;
        int[] MainPlayerMultiLvl = new int[] { 0x30 };
        PlayerDataAddresses MainPlayerOffsets = new PlayerDataAddresses(0x10, 0x14, 0x4, 0xC, 0x8, 0xC8, 0x120, 0x10C);
        

        #region ------Enemy Addresses------
        List<PlayerData> EnemyAddresses = new List<PlayerData>();
        int[] EnemyOneMultiLvl = new int[] { 0x4, 0x30 };
        //int[] EnemyTwoMultiLvl = new int[] { 0x4, 0x34 };
        //int[] EnemyThreeMultiLvl = new int[] { 0x4, 0x34 };

        #endregion
        #endregion

        float PI = 3.14159265f;
        const int RIGHT_MOUSE_BUTTON = 2;
        bool GameFound = false;
        bool FocusingOnEnemy = false;
        int FocusTarget = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoopTimer_Tick(object sender, EventArgs e)
        {
            if (GameFound)
            {
                int playerBase = MemReader.ReadMultiLevelPointer(MainPlayer.baseAddress, 4, MainPlayer.multilevel);
                UpdateLabels(playerBase);

                if (GodModeCheckBox.Checked)
                {
                    WriteInfiniteHealth(playerBase);
                }

                if (InfiniteAmmoCheckBox.Checked)
                {
                    WriteInfiniteAmmo(playerBase);
                }

                int hotkey = ProcessMemoryReaderApi.GetKeyState(RIGHT_MOUSE_BUTTON);
                if (IsKeyHeld(hotkey))
                {
                    if (AimbotCheckBox.Checked) 
                    {
                        FocusingOnEnemy = true;
                        Aimbot();
                    }
                }
                else
                {
                    FocusingOnEnemy = false;
                    FocusTarget = -1;
                }
            }
            try
            {
                CheckProcessExists();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message);
            }
        }

        private void CheckProcessExists()
        {
            if (MyProcesses != null)
            {
                if (MyProcesses.Length > 0)
                {
                    if (MyProcesses[0].HasExited)
                    {
                        if (GameFound)
                        {
                            SetStatusConnectionLost();
                            GameFound = false;
                        }
                    }
                }
            }
        }

        private void SetStatusConnectionLost()
        {
            StatusLabel.Text = "Process Not Found";
            StatusLabel.ForeColor = Color.Red;
            FindProcessButton.Enabled = true;
        }

        private bool IsKeyHeld(int hotkey)
        {
            return (hotkey & 0x8000) != 0;
        }
        private void WriteInfiniteHealth(int playerBase)
        {
            MemReader.WriteInt(playerBase + MainPlayer.offsets.health, 1337);
        }

        private void WriteInfiniteAmmo(int playerBase)
        {
            MemReader.WriteInt(playerBase + MainPlayer.offsets.primaryAmmo, 1337);
            MemReader.WriteInt(playerBase + MainPlayer.offsets.secondaryAmmo, 1337);
        }

        private void UpdateLabels(int playerBase)
        {
            PlayerPositionXLabel.Text = "X: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.xPos);
            PlayerPositionYLabel.Text = "Y: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.yPos);
            PlayerPositionZLabel.Text = "Z: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.zPos);

            int enemyBase = MemReader.ReadMultiLevelPointer(EnemyAddresses[0].baseAddress, 4, EnemyAddresses[0].multilevel);
            TargetPositionXLabel.Text = "X: " + MemReader.ReadFloat(enemyBase + MainPlayer.offsets.xPos);
            TargetPositionYLabel.Text = "Y: " + MemReader.ReadFloat(enemyBase + MainPlayer.offsets.yPos);
            TargetPositionZLabel.Text = "Z: " + MemReader.ReadFloat(enemyBase + MainPlayer.offsets.zPos);

            MouseXLabel.Text = "MouseX: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.xMouse);
            MouseYLabel.Text = "MouseY: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.yMouse);
        }

        private void Aimbot()
        {
            PlayerDataValues pDataValues = GetPlayerData(MainPlayer);
            List<PlayerDataValues> EnemyDataValues = new List<PlayerDataValues>();

            for (int i = 0; i < EnemyAddresses.Count; i++)
            {
                PlayerDataValues enemyData = GetPlayerData(EnemyAddresses[i]);
                EnemyDataValues.Add(enemyData);
            }

            if (pDataValues.health > 0)
            {
                int target = 0;
                if (FocusingOnEnemy && FocusTarget != -1)
                {
                    if (EnemyDataValues[FocusTarget].health > 0)
                    {
                        target = FocusTarget;
                    }
                    else
                    {
                        target = FindClosestEnemyIndex(EnemyDataValues.ToArray(), pDataValues);
                    }
                }
                else
                {
                    target = FindClosestEnemyIndex(EnemyDataValues.ToArray(), pDataValues);
                }

                if (target != -1)
                {
                    FocusTarget = target;
                    if (EnemyDataValues[target].health > 0)
                    {
                        AimAtTarget(EnemyDataValues[target], pDataValues);
                    }
                }
            }
        }

        private void AimAtTarget(PlayerDataValues enemy, PlayerDataValues player)
        {
            float MouseTargetX = -(float)Math.Atan2(enemy.xPos - player.xPos, enemy.zPos - player.zPos) / PI * 180 + 180;
            float MouseTargetY = (float)Math.Asin((enemy.yPos - player.yPos) / Get3DDistance(enemy, player)) * 180 / PI; 

            int playerBase = MemReader.ReadMultiLevelPointer(MainPlayer.baseAddress, 4, MainPlayer.multilevel);

            MemReader.WriteFloat(playerBase + MainPlayer.offsets.xMouse, MouseTargetX);
            MemReader.WriteFloat(playerBase + MainPlayer.offsets.yMouse, MouseTargetY);
        }

        private int FindClosestEnemyIndex(PlayerDataValues[] enemies, PlayerDataValues myPosition)
        {
            float[] distances = new float[enemies.Length];

            for(int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i].health > 0)
                {
                    distances[i] = Get3DDistance(enemies[i], myPosition);
                }
                else 
                {
                    distances[i] = float.MaxValue;
                }
            }

            float minValue = float.MaxValue;
            int minvalueIndex = -1;
            for (int j = 0; j < enemies.Length; j++)
            {
                if (distances[j] < minValue)
                {
                    minValue = distances[j];
                    minvalueIndex = j;
                }
            }

            return minvalueIndex;
        }


        private float Get3DDistance(PlayerDataValues to, PlayerDataValues from)
        {
            return (float)(Math.Sqrt(
                                     ((to.xPos - from.xPos) * (to.xPos - from.xPos)) +
                                     ((to.yPos - from.yPos) * (to.yPos - from.yPos)) +
                                     ((to.zPos - from.zPos) * (to.zPos - from.zPos))));
        }
        private PlayerDataValues GetPlayerData(PlayerData player)
        {
            PlayerDataValues pDataValues = new PlayerDataValues();
            int playerBase = MemReader.ReadMultiLevelPointer(player.baseAddress, 4, player.multilevel);
            pDataValues.xMouse = MemReader.ReadFloat(playerBase + player.offsets.xMouse);
            pDataValues.yMouse = MemReader.ReadFloat(playerBase + player.offsets.yMouse);
            pDataValues.xPos = MemReader.ReadFloat(playerBase + player.offsets.xPos);
            pDataValues.yPos = MemReader.ReadFloat(playerBase + player.offsets.yPos);
            pDataValues.zPos = MemReader.ReadFloat(playerBase + player.offsets.zPos);
            pDataValues.health = MemReader.ReadInt(playerBase + player.offsets.health);
            return pDataValues;
        }

        private void FindProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                AttachProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to process: " + ex.Message);
            }
        }

        private void AttachProcess()
        {
            MyProcesses = Process.GetProcessesByName("ac_client");
            if (MyProcesses.Length == 0)
            {
                throw new Exception("Process not found!");
            }

            MainModule = MyProcesses[0].MainModule;
            MemReader.ReadProcess = MyProcesses[0];
            
            GameFound = true;

            MainPlayer.baseAddress = MainPlayerBase;
            MainPlayer.multilevel = MainPlayerMultiLvl;
            MainPlayer.offsets = new PlayerDataAddresses(MainPlayerOffsets.xMouse, MainPlayerOffsets.yMouse, 
                                                         MainPlayerOffsets.xPos, MainPlayerOffsets.yPos, MainPlayerOffsets.zPos, 
                                                         MainPlayerOffsets.health, MainPlayerOffsets.primaryAmmo, MainPlayerOffsets.secondaryAmmo);
            SetupEnemyVariables();

            SetStatusToAttached();
        }

        private void SetStatusToAttached()
        {
            StatusLabel.Text = "Process Attached!";
            StatusLabel.ForeColor = Color.Green;
            FindProcessButton.Enabled = false;
        }

        private void SetupEnemyVariables()
        {
            PlayerData En1 = new PlayerData();
            En1.baseAddress = MyProcesses[0].MainModule.BaseAddress.ToInt32() + 0x0010F4F8;
            En1.multilevel = EnemyOneMultiLvl;
            En1.offsets = MainPlayer.offsets;
            EnemyAddresses.Add(En1);

        }
    }
}
