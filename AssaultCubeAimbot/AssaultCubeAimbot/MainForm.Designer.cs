namespace AssaultCubeAimbot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FindProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PlayerPositionLabel = new System.Windows.Forms.Label();
            this.PlayerPositionXLabel = new System.Windows.Forms.Label();
            this.PlayerPositionZLabel = new System.Windows.Forms.Label();
            this.PlayerPositionYLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TargetPositionYLabel = new System.Windows.Forms.Label();
            this.TargetPositionZLabel = new System.Windows.Forms.Label();
            this.TargetPositionXLabel = new System.Windows.Forms.Label();
            this.LoopTimer = new System.Windows.Forms.Timer(this.components);
            this.MouseXLabel = new System.Windows.Forms.Label();
            this.MouseYLabel = new System.Windows.Forms.Label();
            this.AimbotCheckBox = new System.Windows.Forms.CheckBox();
            this.GodModeCheckBox = new System.Windows.Forms.CheckBox();
            this.InfiniteAmmoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FindProcessButton
            // 
            this.FindProcessButton.Location = new System.Drawing.Point(227, 60);
            this.FindProcessButton.Name = "FindProcessButton";
            this.FindProcessButton.Size = new System.Drawing.Size(75, 23);
            this.FindProcessButton.TabIndex = 0;
            this.FindProcessButton.Text = "Attach";
            this.FindProcessButton.UseVisualStyleBackColor = true;
            this.FindProcessButton.Click += new System.EventHandler(this.FindProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assault Cube Aimbot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(12, 60);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(209, 23);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Process Not Found";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerPositionLabel
            // 
            this.PlayerPositionLabel.AutoSize = true;
            this.PlayerPositionLabel.Location = new System.Drawing.Point(73, 138);
            this.PlayerPositionLabel.Name = "PlayerPositionLabel";
            this.PlayerPositionLabel.Size = new System.Drawing.Size(76, 13);
            this.PlayerPositionLabel.TabIndex = 5;
            this.PlayerPositionLabel.Text = "Player Position";
            // 
            // PlayerPositionXLabel
            // 
            this.PlayerPositionXLabel.AutoSize = true;
            this.PlayerPositionXLabel.Location = new System.Drawing.Point(93, 164);
            this.PlayerPositionXLabel.Name = "PlayerPositionXLabel";
            this.PlayerPositionXLabel.Size = new System.Drawing.Size(20, 13);
            this.PlayerPositionXLabel.TabIndex = 6;
            this.PlayerPositionXLabel.Text = "X: ";
            // 
            // PlayerPositionZLabel
            // 
            this.PlayerPositionZLabel.AutoSize = true;
            this.PlayerPositionZLabel.Location = new System.Drawing.Point(93, 230);
            this.PlayerPositionZLabel.Name = "PlayerPositionZLabel";
            this.PlayerPositionZLabel.Size = new System.Drawing.Size(20, 13);
            this.PlayerPositionZLabel.TabIndex = 7;
            this.PlayerPositionZLabel.Text = "Z: ";
            // 
            // PlayerPositionYLabel
            // 
            this.PlayerPositionYLabel.AutoSize = true;
            this.PlayerPositionYLabel.Location = new System.Drawing.Point(93, 197);
            this.PlayerPositionYLabel.Name = "PlayerPositionYLabel";
            this.PlayerPositionYLabel.Size = new System.Drawing.Size(17, 13);
            this.PlayerPositionYLabel.TabIndex = 8;
            this.PlayerPositionYLabel.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Target Position";
            // 
            // TargetPositionYLabel
            // 
            this.TargetPositionYLabel.AutoSize = true;
            this.TargetPositionYLabel.Location = new System.Drawing.Point(242, 197);
            this.TargetPositionYLabel.Name = "TargetPositionYLabel";
            this.TargetPositionYLabel.Size = new System.Drawing.Size(17, 13);
            this.TargetPositionYLabel.TabIndex = 12;
            this.TargetPositionYLabel.Text = "Y:";
            // 
            // TargetPositionZLabel
            // 
            this.TargetPositionZLabel.AutoSize = true;
            this.TargetPositionZLabel.Location = new System.Drawing.Point(242, 230);
            this.TargetPositionZLabel.Name = "TargetPositionZLabel";
            this.TargetPositionZLabel.Size = new System.Drawing.Size(17, 13);
            this.TargetPositionZLabel.TabIndex = 11;
            this.TargetPositionZLabel.Text = "Z:";
            // 
            // TargetPositionXLabel
            // 
            this.TargetPositionXLabel.AutoSize = true;
            this.TargetPositionXLabel.Location = new System.Drawing.Point(242, 164);
            this.TargetPositionXLabel.Name = "TargetPositionXLabel";
            this.TargetPositionXLabel.Size = new System.Drawing.Size(17, 13);
            this.TargetPositionXLabel.TabIndex = 10;
            this.TargetPositionXLabel.Text = "X:";
            // 
            // LoopTimer
            // 
            this.LoopTimer.Enabled = true;
            this.LoopTimer.Interval = 16;
            this.LoopTimer.Tick += new System.EventHandler(this.LoopTimer_Tick);
            // 
            // MouseXLabel
            // 
            this.MouseXLabel.AutoSize = true;
            this.MouseXLabel.Location = new System.Drawing.Point(362, 197);
            this.MouseXLabel.Name = "MouseXLabel";
            this.MouseXLabel.Size = new System.Drawing.Size(52, 13);
            this.MouseXLabel.TabIndex = 14;
            this.MouseXLabel.Text = "MouseX: ";
            // 
            // MouseYLabel
            // 
            this.MouseYLabel.AutoSize = true;
            this.MouseYLabel.Location = new System.Drawing.Point(362, 229);
            this.MouseYLabel.Name = "MouseYLabel";
            this.MouseYLabel.Size = new System.Drawing.Size(52, 13);
            this.MouseYLabel.TabIndex = 15;
            this.MouseYLabel.Text = "MouseY: ";
            // 
            // AimbotCheckBox
            // 
            this.AimbotCheckBox.AutoSize = true;
            this.AimbotCheckBox.Location = new System.Drawing.Point(359, 134);
            this.AimbotCheckBox.Name = "AimbotCheckBox";
            this.AimbotCheckBox.Size = new System.Drawing.Size(154, 17);
            this.AimbotCheckBox.TabIndex = 16;
            this.AimbotCheckBox.Text = "Enable Aimbot (Right Click)";
            this.AimbotCheckBox.UseVisualStyleBackColor = true;
            // 
            // GodModeCheckBox
            // 
            this.GodModeCheckBox.AutoSize = true;
            this.GodModeCheckBox.Location = new System.Drawing.Point(359, 87);
            this.GodModeCheckBox.Name = "GodModeCheckBox";
            this.GodModeCheckBox.Size = new System.Drawing.Size(112, 17);
            this.GodModeCheckBox.TabIndex = 17;
            this.GodModeCheckBox.Text = "Enable God Mode";
            this.GodModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfiniteAmmoCheckBox
            // 
            this.InfiniteAmmoCheckBox.AutoSize = true;
            this.InfiniteAmmoCheckBox.Location = new System.Drawing.Point(359, 110);
            this.InfiniteAmmoCheckBox.Name = "InfiniteAmmoCheckBox";
            this.InfiniteAmmoCheckBox.Size = new System.Drawing.Size(89, 17);
            this.InfiniteAmmoCheckBox.TabIndex = 18;
            this.InfiniteAmmoCheckBox.Text = "Infinite Ammo";
            this.InfiniteAmmoCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 277);
            this.Controls.Add(this.InfiniteAmmoCheckBox);
            this.Controls.Add(this.GodModeCheckBox);
            this.Controls.Add(this.AimbotCheckBox);
            this.Controls.Add(this.MouseYLabel);
            this.Controls.Add(this.MouseXLabel);
            this.Controls.Add(this.TargetPositionYLabel);
            this.Controls.Add(this.TargetPositionZLabel);
            this.Controls.Add(this.TargetPositionXLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerPositionYLabel);
            this.Controls.Add(this.PlayerPositionZLabel);
            this.Controls.Add(this.PlayerPositionXLabel);
            this.Controls.Add(this.PlayerPositionLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindProcessButton);
            this.Name = "MainForm";
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindProcessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PlayerPositionLabel;
        private System.Windows.Forms.Label PlayerPositionXLabel;
        private System.Windows.Forms.Label PlayerPositionZLabel;
        private System.Windows.Forms.Label PlayerPositionYLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TargetPositionYLabel;
        private System.Windows.Forms.Label TargetPositionZLabel;
        private System.Windows.Forms.Label TargetPositionXLabel;
        private System.Windows.Forms.Timer LoopTimer;
        private System.Windows.Forms.Label MouseXLabel;
        private System.Windows.Forms.Label MouseYLabel;
        private System.Windows.Forms.CheckBox AimbotCheckBox;
        private System.Windows.Forms.CheckBox GodModeCheckBox;
        private System.Windows.Forms.CheckBox InfiniteAmmoCheckBox;
    }
}

