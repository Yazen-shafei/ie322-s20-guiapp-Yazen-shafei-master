﻿namespace project_demo1
{
    partial class frmRandom
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
            this.BtnGenerateRandomColor = new System.Windows.Forms.Button();
            this.BtnNumber = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerateRandomColor
            // 
            this.BtnGenerateRandomColor.Location = new System.Drawing.Point(289, 61);
            this.BtnGenerateRandomColor.Name = "BtnGenerateRandomColor";
            this.BtnGenerateRandomColor.Size = new System.Drawing.Size(170, 53);
            this.BtnGenerateRandomColor.TabIndex = 0;
            this.BtnGenerateRandomColor.Text = "Generate Random Color";
            this.BtnGenerateRandomColor.UseVisualStyleBackColor = true;
            // 
            // BtnNumber
            // 
            this.BtnNumber.Location = new System.Drawing.Point(173, 263);
            this.BtnNumber.Name = "BtnNumber";
            this.BtnNumber.Size = new System.Drawing.Size(100, 51);
            this.BtnNumber.TabIndex = 1;
            this.BtnNumber.Text = "Random Number";
            this.BtnNumber.UseVisualStyleBackColor = true;
            this.BtnNumber.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(500, 347);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNumber);
            this.Controls.Add(this.BtnGenerateRandomColor);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.Load += new System.EventHandler(this.frmRandom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateRandomColor;
        private System.Windows.Forms.Button BtnNumber;
        private System.Windows.Forms.Button BtnBack;
    }
}