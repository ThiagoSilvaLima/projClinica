using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PrjClinica
{
    public partial class Form4 : Form
    {
        private MySqlConnection conexao;
        //private string data_source = "datasource = localhost; username=root; password=; database=bdclinica";
        private string data_source = "datasource = localhost; username = root; password=;Persist Security Info=True;database=bdclinica;Convert Zero Datetime=True";
        public Form4()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("DtNascto", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Sexo", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Tipo", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Endereço", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Bairro", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Cidade", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("UF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Celular", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Email", 100, HorizontalAlignment.Left);

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {
            txcpf.MaxLength = 14;

            switch (txcpf.TextLength)
            {
                case 0:
                    txcpf.Text = "";
                    break;
                case 3:
                    txcpf.Text =txcpf.Text + ".";
                    txcpf.SelectionStart = 4;
                    break;

                case 7:
                    txcpf.Text = txcpf.Text + ".";
                    txcpf.SelectionStart = 8;
                    break;
                case 11:
                    txcpf.Text = txcpf.Text + "-";
                    txcpf.SelectionStart = 12;
                    break;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (txsexo.SelectedIndex < 0)
                {
                    txsexo.Text = "Sexo";
                }
                else
                {
                    txsexo.Text = txsexo.SelectedText;
                }
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txtipo.SelectedIndex < 0)
            {
                txsexo.Text = "Tipo";
            }
            else
            {
                txsexo.Text = txtipo.SelectedText;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (txuf.SelectedIndex < 0)
            {
                txuf.Text = "UF";
            }
            else
            {
                txuf.Text = txtipo.SelectedText;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO pacientes(nome,cpf,dtnascto,sexo,tipo,endereco,bairro,cidade,uf,celular,email)" +
                    "VALUES ('" + txnome.Text + "', '"+ txcpf.Text + "','" + txdtnascto.Text + "', '" + txsexo.Text + "' ,'" + txtipo.Text + "' , '" + txendereco.Text + "','" + txbairro.Text + "' , '" + txcidade.Text + "', '" + txuf.Text + "', '" + txcell.Text + "', '" + txemail.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                comando.ExecuteReader();

                MessageBox.Show("Inserido com Sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            txid.Text = "";
            txbairro.Text = "";
            txnome.Text = "";
            txdtnascto.Text = "";
            txcpf.Text = "";
            txcell.Text = "";
            txcidade.Text = "";
            txemail.Text = "";
            txendereco.Text = "";
            txsexo.Text = "";
            txtipo.Text = "";
            txuf.Text = "";
        }

        private void txcell_TextChanged(object sender, EventArgs e)
        {
            txcell.MaxLength = 14;
            switch (txcell.TextLength)
            {
                case 0:
                    txcell.Text = "(";
                    txcell.SelectionStart = 1;
                    break;
                case 3:
                    txcell.Text = txcell.Text + ")";
                    txcell.SelectionStart = 4;
                    break;

                case 9:
                    txcell.Text = txcell.Text + "-";
                    txcell.SelectionStart = 10;
                    break;
            }
        }
        private void txdtnascto_TextChanged(object sender, EventArgs e)
        {
            txdtnascto.MaxLength = 10;

            switch (txdtnascto.TextLength)
            {
                case 0:
                    txdtnascto.Text = "";
                    break;
                case 4:
                    txdtnascto.Text = txdtnascto.Text + "/";
                    txdtnascto.SelectionStart = 5;
                    break;

                case 7:
                    txdtnascto.Text = txdtnascto.Text + "/";
                    txdtnascto.SelectionStart = 8;
                    break;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
                //criar conexão com MySQL
                conexao = new MySqlConnection(data_source);


                //comando SQL que altera registro
                string sql = "UPDATE pacientes set nome='" + this.txnome.Text + "',cpf='" + this.txcpf.Text + "',dtnascto='" + this.txdtnascto.Text +"',sexo='"+txsexo.Text+ "',tipo='"+txtipo.Text+"',endereco='"+txendereco.Text+"',bairro='"+txbairro.Text+ "',cidade='"+txcidade.Text + "',uf='"+txuf.Text+"',celular='" + this.txcell.Text + "',email='" + this.txemail.Text + "' where id='" + this.txid.Text + "';";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                comando.ExecuteReader();

                MessageBox.Show("Dados alterados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            txid.Text = "";
            txbairro.Text = "";
            txnome.Text = "";
            txdtnascto.Text = "";
            txcpf.Text = "";
            txcell.Text = "";
            txcidade.Text = "";
            txemail.Text = "";
            txendereco.Text = "";
            txsexo.Text = "";
            txtipo.Text = "";
            txuf.Text = "";
        }

        private void guna2TextBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void txendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txcidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txbusca.Text + "%'";

                conexao = new MySqlConnection(data_source);


                string sql = "SELECT * " + "FROM pacientes " + "WHERE nome LIKE " + q + "OR email LIKE " + q;

                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),
                        reader.GetString(8),
                        reader.GetString(9),
                        reader.GetString(10),
                        reader.GetString(11),

                    };
                    var linha_listview = new ListViewItem(row);

                    listView1.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                //criar conexão com MySQL
                conexao = new MySqlConnection(data_source);


                //comando SQL que altera registro
                string sql = "DELETE FROM pacientes WHERE id='" + this.txid.Text + "';";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                comando.ExecuteReader();

                MessageBox.Show("Dados alterados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            txid.Text = "";
            txbairro.Text = "";
            txnome.Text = "";
            txdtnascto.Text = "";
            txcpf.Text = "";
            txcell.Text = "";
            txcidade.Text = "";
            txemail.Text = "";
            txendereco.Text = "";
            txsexo.Text = "";
            txtipo.Text = "";
            txuf.Text = "";
            


        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }
    }
}
