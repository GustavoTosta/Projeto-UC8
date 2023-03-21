using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class frmEstoque : Form
    {
        string conexaodb = "Data Source=localhost;" +
                           "Initial Catalog=projetoCS;" +
                           "User id =sa;" +
                           "Password=123456";


        private void testaconexao()
        {
            SqlConnection conn = new SqlConnection(conexaodb);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                Application.Exit();
            }
        }


        private void datagride()
        {
            string sql = "select " +
                "id_estoque as 'ID'," +
                "nome_estoque as 'Nome'," +
                "categoria_estoque as 'Login'," +
                "status_estoque as 'Status'" +
                " from estoque where nome_estoque  like '%" + pesquisa_estoque.Text + "%'";

            SqlConnection conn = new SqlConnection(conexaodb);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                data_gride_estoque.DataSource = ds.Tables[0];
                data_gride_estoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                data_gride_estoque.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
           testaconexao();
           
        }
        public frmEstoque()
        {
            InitializeComponent();
            datagride();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nome_estoque.Text = "";
            codigo_estoque.Text = "";
            Status_estoque.Text = "";
            categoria_estoque.Text = "";
            nome_estoque.Text = "";
            data_cadastro.Text = "";
            data_vencimento.Text = "";
            estoque_descricao.Text = "";
            obs_estoque.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "insert into estoque " +
               "(" +
                   "nome_estoque," +
                   "categoria_estoque," +
                   "descricao_estoque," +
                   "data_vencimento_estoque," +
                   "status_estoque," +
                   "obs_estoque" +
               ")values(" +
                   "'" + nome_estoque.Text + "'," +
                   "'" + categoria_estoque.Text + "'," +
                   "'" + estoque_descricao.Text + "'," +
                   "'" + data_vencimento.Text + "'," +
                   "'" + Status_estoque.Text + "'," +
                   "'" + obs_estoque.Text + "'" +
               ")Select SCOPE_IDENTITY()";

            SqlConnection conn = new SqlConnection(conexaodb);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    Limpa_estoque.PerformClick();
                    MessageBox.Show("Cadastro Realizado com sucesso");
                    codigo_estoque.Text = leitura[0].ToString();
                    pesquisa_estoque.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void categoria_estoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void excluir_estoque_Click(object sender, EventArgs e)
        {
            string sql = "delete estoque where id_estoque =" + codigo_estoque.Text;

            SqlConnection conn = new SqlConnection(conexaodb);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                    Limpa_estoque.PerformClick();
                }
                else
                {
                    MessageBox.Show("Erro, não foi possivel excluir esse estoque");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void altera_estoque_Click(object sender, EventArgs e)
        {
            string sql = "update estoque set " +
                "id_estoque = " + codigo_estoque.Text + "," +
                "nome_estoque = '" + nome_estoque.Text + "'," +
                "categoria_estoque = " + categoria_estoque.Text + "," +
                "descricao_estoque = " + estoque_descricao.Text + "," +
                "data_vencimento_estoque = '" + data_vencimento.Text + "'," +
                "status_estoque = '" + Status_estoque.Text + "'," +
                "obs_estoque = '" + obs_estoque.Text + "' " +
                "where id_produto = " + codigo_estoque.Text;


            SqlConnection conn = new SqlConnection(conexaodb);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                    pesquisa_estoque.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pesquisa_estoque_Click(object sender, EventArgs e)
        {

        }

        private void pesquisa_codigo_Click(object sender, EventArgs e)
        {
            string sql = "select * from estoque where id_estoque = " + codigo_estoque.Text;

            SqlConnection conn = new SqlConnection(conexaodb);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    codigo_estoque.Text = reader[0].ToString();
                    nome_estoque.Text = reader[1].ToString();
                    categoria_estoque.Text = reader[2].ToString();
                    estoque_descricao.Text = reader[3].ToString();
                    data_vencimento.Text = reader[4].ToString();
                    data_cadastro.Text = reader[5].ToString();
                    Status_estoque.Text = reader[6].ToString();
                    obs_estoque.Text= reader[7].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void data_gride_estoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_estoque.Text = data_gride_estoque.CurrentRow.Cells["ID"].Value.ToString();
            pesquisa_codigo.PerformClick();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            datagride();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Status_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void obs_estoque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
