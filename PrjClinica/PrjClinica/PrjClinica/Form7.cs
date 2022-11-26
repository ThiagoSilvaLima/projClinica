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
    public partial class Form7 : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource = localhost; username = root; password=;Persist Security Info=True;database=bdclinica;Convert Zero Datetime=True";
        public Form7()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Data", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Hora", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Paciente", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Medico", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Motivo", 100, HorizontalAlignment.Left);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                string sql = "DELETE FROM agendamento WHERE id='" + this.txid.Text + "';";

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
            txhr.Text = "";
            txdt.Text = "";
            txmotivo.Text = "";
            txmedico.Text = "";
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                string sql = "UPDATE agendamento set data='" + this.txdt.Text + "',hora='" + this.txhr.Text + "',paciente='" + this.txpaciente.Text + "',medico='" + this.txmedico.Text + "',motivo='" + this.txmotivo.Text + "' where paciente='" + this.txpaciente.Text + "';";

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
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO agendamento (data,hora,paciente,medico,motivo)" +
                    "VALUES ('" + txdt.Text + "', '"
                    + txhr.Text + "', '" + txpaciente.Text + "', '" + txmedico.Text + "', '" + txmotivo.Text + "')";

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
        }

        private void txbusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txbusca.Text + "%'";

                conexao = new MySqlConnection(data_source);


                string sql = "SELECT * " + "FROM agendamento " + "WHERE paciente LIKE " + q + "OR id LIKE " + q;

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

        private void txdt_TextChanged(object sender, EventArgs e)
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

        private void txhr_TextChanged(object sender, EventArgs e)
        {
            txhr.MaxLength = 5;

            switch (txhr.TextLength)
            {
                case 0:
                    txhr.Text = "";
                    break;
                case 2:
                    txhr.Text = txhr.Text + ":";
                    txhr.SelectionStart = 3;
                    break;
            }
        }
    }
}
