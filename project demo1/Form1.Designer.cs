using System;

namespace project_demo1
{
    partial class FrmMain
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPW = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.TextPW = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPictureBox2 = new System.Windows.Forms.Button();
            this.BtnIctureBox = new System.Windows.Forms.Button();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.BtnRobriccall = new System.Windows.Forms.Button();
            this.BtnManufacturingCall = new System.Windows.Forms.Button();
            this.BtnABCAnalysis = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnLogin.Location = new System.Drawing.Point(201, 217);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(80, 38);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(285, 341);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(78, 38);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnEXIT_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(6, 32);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(74, 17);
            this.LblUser.TabIndex = 2;
            this.LblUser.Text = "User Name";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // LblPW
            // 
            this.LblPW.AutoSize = true;
            this.LblPW.Location = new System.Drawing.Point(6, 96);
            this.LblPW.Name = "LblPW";
            this.LblPW.Size = new System.Drawing.Size(103, 17);
            this.LblPW.TabIndex = 3;
            this.LblPW.Text = "Enter Password";
            this.LblPW.Click += new System.EventHandler(this.LblPW_Click);
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(131, 32);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(100, 24);
            this.TextUser.TabIndex = 4;
            this.TextUser.TextChanged += new System.EventHandler(this.TextUser_TextChanged);
            // 
            // TextPW
            // 
            this.TextPW.Location = new System.Drawing.Point(131, 96);
            this.TextPW.Name = "TextPW";
            this.TextPW.Size = new System.Drawing.Size(100, 24);
            this.TextPW.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Controls.Add(this.TextPW);
            this.groupBox1.Controls.Add(this.LblPW);
            this.groupBox1.Controls.Add(this.TextUser);
            this.groupBox1.Location = new System.Drawing.Point(89, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login to IE322";
            // 
            // BtnPictureBox2
            // 
            this.BtnPictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnPictureBox2.Location = new System.Drawing.Point(1024, 91);
            this.BtnPictureBox2.Name = "BtnPictureBox2";
            this.BtnPictureBox2.Size = new System.Drawing.Size(132, 37);
            this.BtnPictureBox2.TabIndex = 7;
            this.BtnPictureBox2.Text = "Picture Box2";
            this.BtnPictureBox2.UseVisualStyleBackColor = false;
            // 
            // BtnIctureBox
            // 
            this.BtnIctureBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnIctureBox.Location = new System.Drawing.Point(784, 91);
            this.BtnIctureBox.Name = "BtnIctureBox";
            this.BtnIctureBox.Size = new System.Drawing.Size(96, 43);
            this.BtnIctureBox.TabIndex = 8;
            this.BtnIctureBox.Text = "Picture Box";
            this.BtnIctureBox.UseVisualStyleBackColor = false;
            this.BtnIctureBox.Click += new System.EventHandler(this.BtnIctureBox_Click);
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnGroupieApp.Location = new System.Drawing.Point(904, 91);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(96, 34);
            this.BtnGroupieApp.TabIndex = 9;
            this.BtnGroupieApp.Text = "Groupie App";
            this.BtnGroupieApp.UseVisualStyleBackColor = false;
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSelfieApp.Location = new System.Drawing.Point(904, 161);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(96, 37);
            this.BtnSelfieApp.TabIndex = 10;
            this.BtnSelfieApp.Text = "Selfie App";
            this.BtnSelfieApp.UseVisualStyleBackColor = false;
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRandomCombo.Location = new System.Drawing.Point(675, 161);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(87, 62);
            this.BtnRandomCombo.TabIndex = 11;
            this.BtnRandomCombo.Text = "Random Combo";
            this.BtnRandomCombo.UseVisualStyleBackColor = false;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRandom.Location = new System.Drawing.Point(423, 91);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(100, 43);
            this.BtnRandom.TabIndex = 12;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnTimer.Location = new System.Drawing.Point(423, 161);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(100, 37);
            this.BtnTimer.TabIndex = 13;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = false;
            // 
            // BtnProgress
            // 
            this.BtnProgress.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnProgress.Location = new System.Drawing.Point(904, 30);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(96, 33);
            this.BtnProgress.TabIndex = 14;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = false;
            // 
            // BtnTalk
            // 
            this.BtnTalk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnTalk.Location = new System.Drawing.Point(548, 91);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(100, 43);
            this.BtnTalk.TabIndex = 15;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnDraw.Location = new System.Drawing.Point(784, 161);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(96, 37);
            this.BtnDraw.TabIndex = 16;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = false;
            // 
            // BtnArduino
            // 
            this.BtnArduino.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnArduino.Location = new System.Drawing.Point(548, 161);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(100, 37);
            this.BtnArduino.TabIndex = 17;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = false;
            // 
            // BtnRobriccall
            // 
            this.BtnRobriccall.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRobriccall.Location = new System.Drawing.Point(675, 31);
            this.BtnRobriccall.Name = "BtnRobriccall";
            this.BtnRobriccall.Size = new System.Drawing.Size(87, 34);
            this.BtnRobriccall.TabIndex = 18;
            this.BtnRobriccall.Text = "Robric call";
            this.BtnRobriccall.UseVisualStyleBackColor = false;
            // 
            // BtnManufacturingCall
            // 
            this.BtnManufacturingCall.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnManufacturingCall.Location = new System.Drawing.Point(1024, 31);
            this.BtnManufacturingCall.Name = "BtnManufacturingCall";
            this.BtnManufacturingCall.Size = new System.Drawing.Size(132, 32);
            this.BtnManufacturingCall.TabIndex = 19;
            this.BtnManufacturingCall.Text = "manufacturing Call";
            this.BtnManufacturingCall.UseVisualStyleBackColor = false;
            // 
            // BtnABCAnalysis
            // 
            this.BtnABCAnalysis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnABCAnalysis.Location = new System.Drawing.Point(1024, 161);
            this.BtnABCAnalysis.Name = "BtnABCAnalysis";
            this.BtnABCAnalysis.Size = new System.Drawing.Size(132, 37);
            this.BtnABCAnalysis.TabIndex = 20;
            this.BtnABCAnalysis.Text = "ABC Analysis";
            this.BtnABCAnalysis.UseVisualStyleBackColor = false;
            // 
            // BtnJohari
            // 
            this.BtnJohari.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnJohari.Location = new System.Drawing.Point(784, 31);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(96, 34);
            this.BtnJohari.TabIndex = 21;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = false;
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCheckBox.Location = new System.Drawing.Point(675, 91);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(87, 43);
            this.BtnCheckBox.TabIndex = 22;
            this.BtnCheckBox.Text = "Check Box";
            this.BtnCheckBox.UseVisualStyleBackColor = false;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRadio.Location = new System.Drawing.Point(423, 31);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(100, 34);
            this.BtnRadio.TabIndex = 23;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCombo.Location = new System.Drawing.Point(548, 31);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(100, 35);
            this.BtnCombo.TabIndex = 24;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(941, 325);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(107, 40);
            this.BtnAbout.TabIndex = 25;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(423, 217);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(100, 63);
            this.BtnRandomNumber.TabIndex = 26;
            this.BtnRandomNumber.Text = "Random Number";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1238, 450);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnCombo);
            this.Controls.Add(this.BtnRadio);
            this.Controls.Add(this.BtnCheckBox);
            this.Controls.Add(this.BtnJohari);
            this.Controls.Add(this.BtnABCAnalysis);
            this.Controls.Add(this.BtnManufacturingCall);
            this.Controls.Add(this.BtnRobriccall);
            this.Controls.Add(this.BtnArduino);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.BtnTalk);
            this.Controls.Add(this.BtnProgress);
            this.Controls.Add(this.BtnTimer);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnRandomCombo);
            this.Controls.Add(this.BtnSelfieApp);
            this.Controls.Add(this.BtnGroupieApp);
            this.Controls.Add(this.BtnIctureBox);
            this.Controls.Add(this.BtnPictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FrmMain";
            this.Text = "IE322_S20_KAU";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }


        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPW;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.TextBox TextPW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPictureBox2;
        private System.Windows.Forms.Button BtnIctureBox;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnRobriccall;
        private System.Windows.Forms.Button BtnManufacturingCall;
        private System.Windows.Forms.Button BtnABCAnalysis;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnRandomNumber;
    }
}

