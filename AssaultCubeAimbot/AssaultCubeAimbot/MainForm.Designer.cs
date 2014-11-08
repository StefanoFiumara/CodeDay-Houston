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
            this.FindProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AimbotCheckBox = new System.Windows.Forms.CheckBox();
            this.TriggerbotCheckbox = new System.Windows.Forms.CheckBox();
            this.PlayerPositionLabel = new System.Windows.Forms.Label();
            this.PlayerPositionXLabel = new System.Windows.Forms.Label();
            this.PlayerPositionZLabel = new System.Windows.Forms.Label();
            this.PlayerPositionYLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TargetPositionYLabel = new System.Windows.Forms.Label();
            this.TargetPositionZLabel = new System.Windows.Forms.Label();
            this.TargetPositionXLabel = new System.Windows.Forms.Label();
            this.NoRecoilCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FindProcessButton
            // 
            this.FindProcessButton.Location = new System.Drawing.Point(340, 92);
            this.FindProcessButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FindProcessButton.Name = "FindProcessButton";
            this.FindProcessButton.Size = new System.Drawing.Size(112, 35);
            this.FindProcessButton.TabIndex = 0;
            this.FindProcessButton.Text = "Attach";
            this.FindProcessButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assault Cube Aimbot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(18, 92);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(314, 35);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Process Not Found";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AimbotCheckBox
            // 
            this.AimbotCheckBox.AutoSize = true;
            this.AimbotCheckBox.Location = new System.Drawing.Point(538, 149);
            this.AimbotCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AimbotCheckBox.Name = "AimbotCheckBox";
            this.AimbotCheckBox.Size = new System.Drawing.Size(139, 24);
            this.AimbotCheckBox.TabIndex = 3;
            this.AimbotCheckBox.Text = "Enable Aimbot";
            this.AimbotCheckBox.UseVisualStyleBackColor = true;
            // 
            // TriggerbotCheckbox
            // 
            this.TriggerbotCheckbox.AutoSize = true;
            this.TriggerbotCheckbox.Location = new System.Drawing.Point(538, 206);
            this.TriggerbotCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TriggerbotCheckbox.Name = "TriggerbotCheckbox";
            this.TriggerbotCheckbox.Size = new System.Drawing.Size(161, 24);
            this.TriggerbotCheckbox.TabIndex = 4;
            this.TriggerbotCheckbox.Text = "Enable Triggerbot";
            this.TriggerbotCheckbox.UseVisualStyleBackColor = true;
            // 
            // PlayerPositionLabel
            // 
            this.PlayerPositionLabel.AutoSize = true;
            this.PlayerPositionLabel.Location = new System.Drawing.Point(110, 212);
            this.PlayerPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerPositionLabel.Name = "PlayerPositionLabel";
            this.PlayerPositionLabel.Size = new System.Drawing.Size(112, 20);
            this.PlayerPositionLabel.TabIndex = 5;
            this.PlayerPositionLabel.Text = "Player Position";
            // 
            // PlayerPositionXLabel
            // 
            this.PlayerPositionXLabel.AutoSize = true;
            this.PlayerPositionXLabel.Location = new System.Drawing.Point(140, 252);
            this.PlayerPositionXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerPositionXLabel.Name = "PlayerPositionXLabel";
            this.PlayerPositionXLabel.Size = new System.Drawing.Size(28, 20);
            this.PlayerPositionXLabel.TabIndex = 6;
            this.PlayerPositionXLabel.Text = "X: ";
            // 
            // PlayerPositionZLabel
            // 
            this.PlayerPositionZLabel.AutoSize = true;
            this.PlayerPositionZLabel.Location = new System.Drawing.Point(140, 354);
            this.PlayerPositionZLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerPositionZLabel.Name = "PlayerPositionZLabel";
            this.PlayerPositionZLabel.Size = new System.Drawing.Size(27, 20);
            this.PlayerPositionZLabel.TabIndex = 7;
            this.PlayerPositionZLabel.Text = "Z: ";
            // 
            // PlayerPositionYLabel
            // 
            this.PlayerPositionYLabel.AutoSize = true;
            this.PlayerPositionYLabel.Location = new System.Drawing.Point(140, 303);
            this.PlayerPositionYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerPositionYLabel.Name = "PlayerPositionYLabel";
            this.PlayerPositionYLabel.Size = new System.Drawing.Size(24, 20);
            this.PlayerPositionYLabel.TabIndex = 8;
            this.PlayerPositionYLabel.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Target Position";
            // 
            // TargetPositionYLabel
            // 
            this.TargetPositionYLabel.AutoSize = true;
            this.TargetPositionYLabel.Location = new System.Drawing.Point(363, 303);
            this.TargetPositionYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TargetPositionYLabel.Name = "TargetPositionYLabel";
            this.TargetPositionYLabel.Size = new System.Drawing.Size(24, 20);
            this.TargetPositionYLabel.TabIndex = 12;
            this.TargetPositionYLabel.Text = "Y:";
            // 
            // TargetPositionZLabel
            // 
            this.TargetPositionZLabel.AutoSize = true;
            this.TargetPositionZLabel.Location = new System.Drawing.Point(363, 354);
            this.TargetPositionZLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TargetPositionZLabel.Name = "TargetPositionZLabel";
            this.TargetPositionZLabel.Size = new System.Drawing.Size(23, 20);
            this.TargetPositionZLabel.TabIndex = 11;
            this.TargetPositionZLabel.Text = "Z:";
            // 
            // TargetPositionXLabel
            // 
            this.TargetPositionXLabel.AutoSize = true;
            this.TargetPositionXLabel.Location = new System.Drawing.Point(363, 252);
            this.TargetPositionXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TargetPositionXLabel.Name = "TargetPositionXLabel";
            this.TargetPositionXLabel.Size = new System.Drawing.Size(24, 20);
            this.TargetPositionXLabel.TabIndex = 10;
            this.TargetPositionXLabel.Text = "X:";
            // 
            // NoRecoilCheckBox
            // 
            this.NoRecoilCheckBox.AutoSize = true;
            this.NoRecoilCheckBox.Location = new System.Drawing.Point(538, 266);
            this.NoRecoilCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoRecoilCheckBox.Name = "NoRecoilCheckBox";
            this.NoRecoilCheckBox.Size = new System.Drawing.Size(157, 24);
            this.NoRecoilCheckBox.TabIndex = 13;
            this.NoRecoilCheckBox.Text = "Enable No Recoil";
            this.NoRecoilCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 426);
            this.Controls.Add(this.NoRecoilCheckBox);
            this.Controls.Add(this.TargetPositionYLabel);
            this.Controls.Add(this.TargetPositionZLabel);
            this.Controls.Add(this.TargetPositionXLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerPositionYLabel);
            this.Controls.Add(this.PlayerPositionZLabel);
            this.Controls.Add(this.PlayerPositionXLabel);
            this.Controls.Add(this.PlayerPositionLabel);
            this.Controls.Add(this.TriggerbotCheckbox);
            this.Controls.Add(this.AimbotCheckBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindProcessButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindProcessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox AimbotCheckBox;
        private System.Windows.Forms.CheckBox TriggerbotCheckbox;
        private System.Windows.Forms.Label PlayerPositionLabel;
        private System.Windows.Forms.Label PlayerPositionXLabel;
        private System.Windows.Forms.Label PlayerPositionZLabel;
        private System.Windows.Forms.Label PlayerPositionYLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TargetPositionYLabel;
        private System.Windows.Forms.Label TargetPositionZLabel;
        private System.Windows.Forms.Label TargetPositionXLabel;
        private System.Windows.Forms.CheckBox NoRecoilCheckBox;
    }
}

