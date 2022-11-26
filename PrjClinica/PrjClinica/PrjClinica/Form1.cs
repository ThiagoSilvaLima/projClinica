using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(guna2ProgressBar1.Value < 100){
                guna2ProgressBar1.Value = guna2ProgressBar1.Value + 5;
            }
            else
            {
               
                timer1.Enabled = false;
                Form2 formLogin = new Form2();
                formLogin.Show();
                this.Visible = false;
               
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
