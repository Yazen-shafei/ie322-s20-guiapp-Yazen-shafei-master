using newLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_demo1
{
    public partial class FrmMain : Form
    {

        string username = "yazan";
        string mypassword = "1845415";
        int attempt = 1;
        int maxattempts = 3;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            Frmradio frm = new Frmradio();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            while (attempt <= 3)
            {
                if (TextUser.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username");
                    break;
                }
                else
                {
                    // username is correct 
                    // so check password
                    if (TextPW.Text != "1845415")

                    { // Incorrect password
                        MessageBox.Show("Incorrect password");

                    }

                }

            }
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnRandomNumber_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void TextUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void LblPW_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnIctureBox_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
