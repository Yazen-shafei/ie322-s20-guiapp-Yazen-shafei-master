namespace project_demo1
{
    partial class FrmRandomCombo
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.CmbRandom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.Rdo1 = new System.Windows.Forms.RadioButton();
            this.Rdo2 = new System.Windows.Forms.RadioButton();
            this.Rdo3 = new System.Windows.Forms.RadioButton();
            this.Rdo4 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(177, 74);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbRandom
            // 
            this.CmbRandom.FormattingEnabled = true;
            this.CmbRandom.Location = new System.Drawing.Point(31, 39);
            this.CmbRandom.Name = "CmbRandom";
            this.CmbRandom.Size = new System.Drawing.Size(121, 24);
            this.CmbRandom.TabIndex = 1;
            this.CmbRandom.SelectedIndexChanged += new System.EventHandler(this.CmbRandom_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rdo2);
            this.groupBox1.Controls.Add(this.Rdo1);
            this.groupBox1.Controls.Add(this.BtnReset1);
            this.groupBox1.Controls.Add(this.CmbRandom);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(97, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(177, 233);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(75, 23);
            this.BtnReset1.TabIndex = 2;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // Rdo1
            // 
            this.Rdo1.AutoSize = true;
            this.Rdo1.Location = new System.Drawing.Point(166, 127);
            this.Rdo1.Name = "Rdo1";
            this.Rdo1.Size = new System.Drawing.Size(115, 21);
            this.Rdo1.TabIndex = 3;
            this.Rdo1.TabStop = true;
            this.Rdo1.Text = "Less than 500";
            this.Rdo1.UseVisualStyleBackColor = true;
            // 
            // Rdo2
            // 
            this.Rdo2.AutoSize = true;
            this.Rdo2.Location = new System.Drawing.Point(166, 167);
            this.Rdo2.Name = "Rdo2";
            this.Rdo2.Size = new System.Drawing.Size(134, 21);
            this.Rdo2.TabIndex = 4;
            this.Rdo2.TabStop = true;
            this.Rdo2.Text = "Greater than 500";
            this.Rdo2.UseVisualStyleBackColor = true;
            // 
            // Rdo3
            // 
            this.Rdo3.AutoSize = true;
            this.Rdo3.Location = new System.Drawing.Point(192, 110);
            this.Rdo3.Name = "Rdo3";
            this.Rdo3.Size = new System.Drawing.Size(107, 21);
            this.Rdo3.TabIndex = 5;
            this.Rdo3.TabStop = true;
            this.Rdo3.Text = "Less than 50";
            this.Rdo3.UseVisualStyleBackColor = true;
            // 
            // Rdo4
            // 
            this.Rdo4.AutoSize = true;
            this.Rdo4.Location = new System.Drawing.Point(192, 167);
            this.Rdo4.Name = "Rdo4";
            this.Rdo4.Size = new System.Drawing.Size(126, 21);
            this.Rdo4.TabIndex = 6;
            this.Rdo4.TabStop = true;
            this.Rdo4.Text = "Greater than 50";
            this.Rdo4.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(206, 58);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate2.TabIndex = 7;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(206, 233);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(75, 23);
            this.BtnReset2.TabIndex = 8;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbRandom2);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.Rdo4);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.Rdo3);
            this.groupBox2.Location = new System.Drawing.Point(481, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 302);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(6, 39);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(121, 24);
            this.CmbRandom2.TabIndex = 10;
            this.CmbRandom2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(514, 399);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomCombo";
            this.Text = "FrnRandomCombo";
            this.Load += new System.EventHandler(this.FrnRandomCombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ComboBox CmbRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rdo2;
        private System.Windows.Forms.RadioButton Rdo1;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.RadioButton Rdo3;
        private System.Windows.Forms.RadioButton Rdo4;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.Button BtnBack;
    }
}