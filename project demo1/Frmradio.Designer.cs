using System;

namespace project_demo1
{
    partial class Frmradio
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
            this.RdoRed1 = new System.Windows.Forms.RadioButton();
            this.RdoGreen1 = new System.Windows.Forms.RadioButton();
            this.RdoBlue1 = new System.Windows.Forms.RadioButton();
            this.RdoYellow1 = new System.Windows.Forms.RadioButton();
            this.RdoRed2 = new System.Windows.Forms.RadioButton();
            this.RdoGreen2 = new System.Windows.Forms.RadioButton();
            this.RdoBlue2 = new System.Windows.Forms.RadioButton();
            this.RdoYellow2 = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RdoRed1
            // 
            this.RdoRed1.AutoSize = true;
            this.RdoRed1.Location = new System.Drawing.Point(36, 46);
            this.RdoRed1.Name = "RdoRed1";
            this.RdoRed1.Size = new System.Drawing.Size(53, 21);
            this.RdoRed1.TabIndex = 1;
            this.RdoRed1.TabStop = true;
            this.RdoRed1.Text = "Red";
            this.RdoRed1.UseVisualStyleBackColor = true;
            this.RdoRed1.CheckedChanged += new System.EventHandler(this.RdoRed1_CheckedChanged);
            // 
            // RdoGreen1
            // 
            this.RdoGreen1.AutoSize = true;
            this.RdoGreen1.Location = new System.Drawing.Point(36, 91);
            this.RdoGreen1.Name = "RdoGreen1";
            this.RdoGreen1.Size = new System.Drawing.Size(65, 21);
            this.RdoGreen1.TabIndex = 2;
            this.RdoGreen1.TabStop = true;
            this.RdoGreen1.Text = "Green";
            this.RdoGreen1.UseVisualStyleBackColor = true;
            this.RdoGreen1.CheckedChanged += new System.EventHandler(this.RdoGreen1_CheckedChanged);
            // 
            // RdoBlue1
            // 
            this.RdoBlue1.AutoSize = true;
            this.RdoBlue1.Location = new System.Drawing.Point(36, 133);
            this.RdoBlue1.Name = "RdoBlue1";
            this.RdoBlue1.Size = new System.Drawing.Size(54, 21);
            this.RdoBlue1.TabIndex = 3;
            this.RdoBlue1.TabStop = true;
            this.RdoBlue1.Text = "Blue";
            this.RdoBlue1.UseVisualStyleBackColor = true;
            // 
            // RdoYellow1
            // 
            this.RdoYellow1.AutoSize = true;
            this.RdoYellow1.Location = new System.Drawing.Point(36, 190);
            this.RdoYellow1.Name = "RdoYellow1";
            this.RdoYellow1.Size = new System.Drawing.Size(66, 21);
            this.RdoYellow1.TabIndex = 4;
            this.RdoYellow1.TabStop = true;
            this.RdoYellow1.Text = "Yellow";
            this.RdoYellow1.UseVisualStyleBackColor = true;
            // 
            // RdoRed2
            // 
            this.RdoRed2.AutoSize = true;
            this.RdoRed2.Location = new System.Drawing.Point(300, 46);
            this.RdoRed2.Name = "RdoRed2";
            this.RdoRed2.Size = new System.Drawing.Size(53, 21);
            this.RdoRed2.TabIndex = 5;
            this.RdoRed2.TabStop = true;
            this.RdoRed2.Text = "Red";
            this.RdoRed2.UseVisualStyleBackColor = true;
            // 
            // RdoGreen2
            // 
            this.RdoGreen2.AutoSize = true;
            this.RdoGreen2.Location = new System.Drawing.Point(300, 91);
            this.RdoGreen2.Name = "RdoGreen2";
            this.RdoGreen2.Size = new System.Drawing.Size(65, 21);
            this.RdoGreen2.TabIndex = 6;
            this.RdoGreen2.TabStop = true;
            this.RdoGreen2.Text = "Green";
            this.RdoGreen2.UseVisualStyleBackColor = true;
            // 
            // RdoBlue2
            // 
            this.RdoBlue2.AutoSize = true;
            this.RdoBlue2.Location = new System.Drawing.Point(300, 133);
            this.RdoBlue2.Name = "RdoBlue2";
            this.RdoBlue2.Size = new System.Drawing.Size(54, 21);
            this.RdoBlue2.TabIndex = 7;
            this.RdoBlue2.TabStop = true;
            this.RdoBlue2.Text = "Blue";
            this.RdoBlue2.UseVisualStyleBackColor = true;
            // 
            // RdoYellow2
            // 
            this.RdoYellow2.AutoSize = true;
            this.RdoYellow2.Location = new System.Drawing.Point(300, 190);
            this.RdoYellow2.Name = "RdoYellow2";
            this.RdoYellow2.Size = new System.Drawing.Size(66, 21);
            this.RdoYellow2.TabIndex = 8;
            this.RdoYellow2.TabStop = true;
            this.RdoYellow2.Text = "Yellow";
            this.RdoYellow2.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(158, 249);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(316, 302);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // Frmradio
            // 
            this.ClientSize = new System.Drawing.Size(511, 424);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.RdoYellow2);
            this.Controls.Add(this.RdoBlue2);
            this.Controls.Add(this.RdoGreen2);
            this.Controls.Add(this.RdoRed2);
            this.Controls.Add(this.RdoYellow1);
            this.Controls.Add(this.RdoBlue1);
            this.Controls.Add(this.RdoGreen1);
            this.Controls.Add(this.RdoRed1);
            this.Name = "Frmradio";
            this.Load += new System.EventHandler(this.Frmradio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.RadioButton RdoRed1;
        private System.Windows.Forms.RadioButton RdoGreen1;
        private System.Windows.Forms.RadioButton RdoBlue1;
        private System.Windows.Forms.RadioButton RdoYellow1;
        private System.Windows.Forms.RadioButton RdoRed2;
        private System.Windows.Forms.RadioButton RdoGreen2;
        private System.Windows.Forms.RadioButton RdoBlue2;
        private System.Windows.Forms.RadioButton RdoYellow2;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnBack;
    }
}