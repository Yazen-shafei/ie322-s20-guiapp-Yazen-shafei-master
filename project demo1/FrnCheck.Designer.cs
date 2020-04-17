namespace project_demo1
{
    partial class FrmCheck
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.ChkDonut = new System.Windows.Forms.CheckBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(71, 58);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(619, 392);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(250, 147);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(69, 21);
            this.ChkCoffee.TabIndex = 2;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            this.ChkCoffee.CheckedChanged += new System.EventHandler(this.ChkCoffee_CheckedChanged);
            // 
            // ChkDonut
            // 
            this.ChkDonut.AutoSize = true;
            this.ChkDonut.Location = new System.Drawing.Point(250, 209);
            this.ChkDonut.Name = "ChkDonut";
            this.ChkDonut.Size = new System.Drawing.Size(69, 21);
            this.ChkDonut.TabIndex = 3;
            this.ChkDonut.Text = "Donut";
            this.ChkDonut.UseVisualStyleBackColor = true;
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(250, 272);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(78, 21);
            this.ChkBrownie.TabIndex = 4;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkBrownie);
            this.Controls.Add(this.ChkDonut);
            this.Controls.Add(this.ChkCoffee);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheck";
            this.Text = "Check Box Form";
            this.Load += new System.EventHandler(this.FrmCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.CheckBox ChkDonut;
        private System.Windows.Forms.CheckBox ChkBrownie;
    }
}