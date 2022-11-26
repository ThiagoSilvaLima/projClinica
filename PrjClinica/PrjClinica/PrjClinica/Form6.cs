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

namespace PrjClinica
{
    public partial class Form6 : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource = localhost; username = root; password=;Persist Security Info=True;database=bdclinica;Convert Zero Datetime=True";
        public Form6()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Data", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Médico", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Diagnostico", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Tratamento", 100, HorizontalAlignment.Left);
        }
        private void txdtnascto_TextChanged(object sender, EventArgs e)
        {
            txdt.MaxLength = 10;

            switch (txdt.TextLength)
            {
                case 0:
                    txdt.Text = "";
                    break;
                case 4:
                    txdt.Text = txdt.Text + "/";
                    txdt.SelectionStart = 5;
                    break;

                case 7:
                    txdt.Text = txdt.Text + "/";
                    txdt.SelectionStart = 8;
                    break;
            }
        }
        private void txcidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO consultas (data,medico,diagnostico,tratamento)" +
                    "VALUES ('" + txdt.Text + "', '"
                    + txmedico.Text + "', '" + txdiagnostico.Text + "', '" + txtratamento.Text + "')";

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
            txdt.Text = "";
            txmedico.Text = "";
            txdiagnostico.Text = "";
            txtratamento.Text = "";
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                string sql = "UPDATE consultas set data='" + this.txdt.Text + "',medico='" + this.txmedico.Text + "',diagnostico='" + this.txdiagnostico.Text + "',tratamento='" + this.txtratamento.Text + "' where id='" + this.txid.Text + "';";

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
            txdt.Text = "";
            txmedico.Text = "";
            txdiagnostico.Text = "";
            txtratamento.Text = "";

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                string sql = "DELETE FROM consultas WHERE id='" + this.txid.Text + "';";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                comando.ExecuteReader();

                MessageBox.Show("Apagado Com Sucesso!!");
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
            txdt.Text = "";
            txmedico.Text = "";
            txdiagnostico.Text = "";
            txtratamento.Text = "";
        }

        private void txbusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txbusca.Text + "%'";

                conexao = new MySqlConnection(data_source);


                string sql = "SELECT * " + "FROM consultas " + "WHERE medico LIKE " + q + "OR id LIKE " + q;

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
