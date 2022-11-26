using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrjClinica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ((txusuario.Text == "adm") && (txsenha.Text == "1234"))
            {
                Form3 fprincipal = new Form3();
                fprincipal.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Usuário ou senha inválidos!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
