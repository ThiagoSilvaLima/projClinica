using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource = localhost; username = root; password=;Persist Security Info=True;database=bdclinica;Convert Zero Datetime=True";
        public Form5()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CRM", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Especialidade", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("DtFormação", 100, HorizontalAlignment.Left);
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO medicos(nome,crm,especialidade,anoFormacao)" +
                     "VALUES ('" + txnome.Text + "', '" + txcrm.Text + "','" + txespecialidade.Text + "', '" + txdtformacao.Text +"')";

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
            txnome.Text = "";
            txdtformacao.Text = "";
            txcrm.Text = "";
            txespecialidade.Text = "";
        }

        private void txdtformacao_TextChanged(object sender, EventArgs e)
        {
            txdtformacao.MaxLength = 10;

            switch (txdtformacao.TextLength)
            {
                case 0:
                    txdtformacao.Text = "";
                    break;
                case 4:
                    txdtformacao.Text = txdtformacao.Text + "/";
                    txdtformacao.SelectionStart = 5;
                    break;

                case 7:
                    txdtformacao.Text = txdtformacao.Text + "/";
                    txdtformacao.SelectionStart = 8;
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
                //criar conexão com MySQL
                conexao = new MySqlConnection(data_source);


                //comando SQL que altera registro
                string sql = "UPDATE medicos set nome='" + this.txnome.Text + "',crm='" + this.txcrm.Text + "',especialidade='" + this.txespecialidade.Text + "',anoFormacao='" + txdtformacao.Text + "' where id='" + this.txid.Text + "';";

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
            txespecialidade.Text = "";
            txcrm.Text = "";
            txnome.Text = "";
            txdtformacao.Text = "";
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                //criar conexão com MySQL
                conexao = new MySqlConnection(data_source);


                //comando SQL que altera registro
                string sql = "DELETE FROM medicos WHERE id='" + this.txid.Text + "';";

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
            txcrm.Text = "";
            txnome.Text = "";
            txdtformacao.Text = "";
            txespecialidade.Text = "";
        }

        private void txbusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txbusca.Text + "%'";

                conexao = new MySqlConnection(data_source);


                string sql = "SELECT * " + "FROM medicos " + "WHERE nome LIKE " + q + "OR crm LIKE " + q;

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
    }
}
