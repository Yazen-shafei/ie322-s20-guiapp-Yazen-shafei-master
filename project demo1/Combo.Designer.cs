using System;

namespace newLogin
{
    partial class FrmCombo
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
            this.BtnMethood1 = new System.Windows.Forms.Button();
            this.BtnMethood2 = new System.Windows.Forms.Button();
            this.BtnRemoveLastitem = new System.Windows.Forms.Button();
            this.BtnRemove2ndItem = new System.Windows.Forms.Button();
            this.BtnRemoveInd = new System.Windows.Forms.Button();
            this.BtnRemoeName = new System.Windows.Forms.Button();
            this.BtnBackCombo = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnMethood1
            // 
            this.BtnMethood1.Location = new System.Drawing.Point(110, 50);
            this.BtnMethood1.Name = "BtnMethood1";
            this.BtnMethood1.Size = new System.Drawing.Size(87, 64);
            this.BtnMethood1.TabIndex = 9;
            this.BtnMethood1.Text = "show selecte method1";
            this.BtnMethood1.UseVisualStyleBackColor = true;
            this.BtnMethood1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMethood2
            // 
            this.BtnMethood2.Location = new System.Drawing.Point(341, 50);
            this.BtnMethood2.Name = "BtnMethood2";
            this.BtnMethood2.Size = new System.Drawing.Size(93, 64);
            this.BtnMethood2.TabIndex = 10;
            this.BtnMethood2.Text = "show selecte method2";
            this.BtnMethood2.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveLastitem
            // 
            this.BtnRemoveLastitem.Location = new System.Drawing.Point(650, 109);
            this.BtnRemoveLastitem.Name = "BtnRemoveLastitem";
            this.BtnRemoveLastitem.Size = new System.Drawing.Size(75, 69);
            this.BtnRemoveLastitem.TabIndex = 12;
            this.BtnRemoveLastitem.Text = "Remove Last Item";
            this.BtnRemoveLastitem.UseVisualStyleBackColor = true;
            // 
            // BtnRemove2ndItem
            // 
            this.BtnRemove2ndItem.Location = new System.Drawing.Point(650, 204);
            this.BtnRemove2ndItem.Name = "BtnRemove2ndItem";
            this.BtnRemove2ndItem.Size = new System.Drawing.Size(75, 62);
            this.BtnRemove2ndItem.TabIndex = 13;
            this.BtnRemove2ndItem.Text = "Remove 2nd Item";
            this.BtnRemove2ndItem.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveInd
            // 
            this.BtnRemoveInd.Location = new System.Drawing.Point(122, 270);
            this.BtnRemoveInd.Name = "BtnRemoveInd";
            this.BtnRemoveInd.Size = new System.Drawing.Size(75, 62);
            this.BtnRemoveInd.TabIndex = 14;
            this.BtnRemoveInd.Text = "Remove by Index";
            this.BtnRemoveInd.UseVisualStyleBackColor = true;
            // 
            // BtnRemoeName
            // 
            this.BtnRemoeName.Location = new System.Drawing.Point(341, 270);
            this.BtnRemoeName.Name = "BtnRemoeName";
            this.BtnRemoeName.Size = new System.Drawing.Size(75, 62);
            this.BtnRemoeName.TabIndex = 15;
            this.BtnRemoeName.Text = "Remove by name";
            this.BtnRemoeName.UseVisualStyleBackColor = true;
            // 
            // BtnBackCombo
            // 
            this.BtnBackCombo.Location = new System.Drawing.Point(650, 362);
            this.BtnBackCombo.Name = "BtnBackCombo";
            this.BtnBackCombo.Size = new System.Drawing.Size(75, 23);
            this.BtnBackCombo.TabIndex = 16;
            this.BtnBackCombo.Text = "Back";
            this.BtnBackCombo.UseVisualStyleBackColor = true;
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(91, 154);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 24);
            this.CmbDays.TabIndex = 17;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnBackCombo);
            this.Controls.Add(this.BtnRemoeName);
            this.Controls.Add(this.BtnRemoveInd);
            this.Controls.Add(this.BtnRemove2ndItem);
            this.Controls.Add(this.BtnRemoveLastitem);
            this.Controls.Add(this.BtnMethood2);
            this.Controls.Add(this.BtnMethood1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRemoveLast2ndlastItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRemoveLastItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnShowSelectedMethod2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnShowSelectedMethod1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button BtnMethood1;
        private System.Windows.Forms.Button BtnMethood2;
        private System.Windows.Forms.Button BtnRemoveLastitem;
        private System.Windows.Forms.Button BtnRemove2ndItem;
        private System.Windows.Forms.Button BtnRemoveInd;
        private System.Windows.Forms.Button BtnRemoeName;
        private System.Windows.Forms.Button BtnBackCombo;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}