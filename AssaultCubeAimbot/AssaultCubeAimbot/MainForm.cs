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
        int[] MainPlayerMultiLvl = new int[] { 0x34 };
        PlayerDataAddresses MainPlayerOffsets = new PlayerDataAddresses(0xC, 0x10, 0x0, 0x8, 0x4, 0xC4);

        #region ------Enemy Addresses------
        List<PlayerData> EnemyAddresses = new List<PlayerData>();
        int[] EnemyOneMultiLvl = new int[] { 0x4, 0x34 };
        //int[] EnemyTwoMultiLvl = new int[] { 0x4, 0x34 };
        //int[] EnemyThreeMultiLvl = new int[] { 0x4, 0x34 };

        #endregion
        #endregion

        float PI = 3.14159265f;
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

                int hotkey = ProcessMemoryReaderApi.GetKeyState(02); //Right mouse button
                if ((hotkey & 0x8000) != 0)
                {
                    FocusingOnEnemy = true;
                    Aimbot();
                }
                else
                {
                    FocusingOnEnemy = false;
                    FocusTarget = -1;
                }
            }
            try
            {
                if (MyProcesses != null)
                {
                    if (MyProcesses[0].HasExited)
                    {
                        GameFound = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message);
            }
        }

        private void UpdateLabels(int playerBase)
        {
            PlayerPositionXLabel.Text = "X: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.xPos);
            PlayerPositionYLabel.Text = "Y: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.yPos);
            PlayerPositionZLabel.Text = "Z: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.zPos);
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
                        target = FindClosestEnemyIndex();
                    }
                }
            }
        }

        private int FindClosestEnemyIndex(PlayerDataValues[] enemies, PlayerDataValues myPosition) 
        {
            //Find the minimum value and return the index of it.

            float[] distances = new float[enemies.Length];
            //fill array with all enemy distances
            for (int i = 0; i < enemies.Length; i++)
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
            
            //create new array, copy the values and sort them.
            float[] sortedDistances = new float[distances.Length];
            Array.Copy(distances, sortedDistances, distances.Length);
            Array.Sort(sortedDistances);

            //find the index of the smallest distance and return it.
            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] == sortedDistances[0])
                {
                    return i;
                }
            }
            return -1;
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
            int playerBase = MemReader.ReadMultiLevelPointer(player.baseAddress, 4, MainPlayer.multilevel);
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
            MainModule = MyProcesses[0].MainModule;
            MemReader.ReadProcess = MyProcesses[0];
            
            GameFound = true;

            MainPlayer.baseAddress = MainPlayerBase;
            MainPlayer.multilevel = MainPlayerMultiLvl;
            MainPlayer.offsets = new PlayerDataAddresses(MainPlayerOffsets.xMouse, MainPlayerOffsets.yMouse, MainPlayerOffsets.xPos, MainPlayerOffsets.yPos, MainPlayerOffsets.zPos, MainPlayerOffsets.health);
            SetupEnemyVariables();

            StatusLabel.Text = "Process Attached!";
            StatusLabel.ForeColor = Color.Green;
            FindProcessButton.Enabled = false;
        }

        private void SetupEnemyVariables()
        {

        }
    }
}
