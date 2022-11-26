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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword");
        }
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Form5 medico = new Form5();
            medico.Show();
        }

        private void RelatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Form7 agendamento = new Form7();
            agendamento.Show();
        }
        private void SistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {
  
        }

        private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
        {

       
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortDateString();
        }

        private void pacientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 CadastroP = new Form4();
            CadastroP.Show();

        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 CadastroM = new Form5();
            CadastroM.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 CadastroC = new Form6();
            CadastroC.Show();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 CadastroA = new Form7();
            CadastroA.Show();
        }

        private void desenvolvedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form8 CadastroP = new Form8();
            CadastroP.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form4 paciente = new Form4();
            paciente.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form6 consulta = new Form6();
            consulta.Show();
        }
    }
}

