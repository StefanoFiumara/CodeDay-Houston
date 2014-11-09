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
                PlayerPositionXLabel.Text = "X: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.xPos);
                PlayerPositionYLabel.Text = "Y: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.yPos);
                PlayerPositionZLabel.Text = "Z: " + MemReader.ReadFloat(playerBase + MainPlayer.offsets.zPos);

                int hotkey = ProcessMemoryReaderApi.GetKeyState(02); //Right mouse button
                if ((hotkey & 0x8000) != 0)
                {
                    FocusingOnEnemy = true;
                }
            }
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
