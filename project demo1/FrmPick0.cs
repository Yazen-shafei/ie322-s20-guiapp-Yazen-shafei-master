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
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\IE322_1845415\\project demo1\\5d7ea55c5c161.png");

        }

        private void FrmPick0_Load(object sender, EventArgs e)
        {

        }
    }    
}

