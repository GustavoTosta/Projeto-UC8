using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Integrador
{
    public partial class frm_produto : Form
    {
        public frm_produto()
        {
            InitializeComponent();
        }

        public static string Conexao = "" +
            "Data Source=localhost;" +
            "Initial catalog=projetoCS;" +
            "User id=sa;" +
            "Password=123456";

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(Conexao);
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
            
        private void frm_produto_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            string Cadastro = "Insert into produto (id_categoria, id_fornecedor, id_estoque ," +
                " nome_produto, quantidade_produto, peso_produto," +
                " unidadeMedida_produto, valorcusto_produto," +
                " valorvenda_produto, obs_produto, status_produto)" +

            "values ('" + numeric_idCategoria.Text + "'," +
            "'" + numeric_IDFornecedor.Text + "'," +
            "'" + numeric_IDEstoque.Text + "'," +
            "'" + txt_nome.Text + "'," +
            "'" + numeric_quantidade.Text + "'," +
            "'" + numeric_peso.Text + "'," +
            "'" + cbo_unidadeMedida.Text + "'," +
            "'" + numeric_custo.Text + "'," +
            "'" + numeric_venda.Text + "'," +
            "'" + txt_obs.Text + "'," +
            "'" + cbo_status.Text + "') Select SCOPE_IDENTITY()";

            SqlConnection conexao = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(Cadastro, conexao);
            comando.CommandType = CommandType.Text;
            conexao.Open();

            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro de produto realizado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void bto_pesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto where id_produto =" + numeric_idProduto.Text;

            SqlConnection conexaoSQL = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(sql, conexaoSQL);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexaoSQL.Open();

            if (numeric_idProduto.Text == "")
            {
                MessageBox.Show("Erro, código de produto é necessário para pesquisa");
            }
            else
            {

                try
                {
                    reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Pesquisa feita com sucesso, mostrando os resultados...");

                        numeric_idProduto.Text = reader[0].ToString();
                        numeric_IDFornecedor.Text = reader[1].ToString();
                        numeric_idCategoria.Text = reader[2].ToString();
                        numeric_IDEstoque.Text = reader[3].ToString();
                        txt_nome.Text = reader[4].ToString();
                        txt_descricao.Text = reader[5].ToString();
                        numeric_quantidade.Text = reader[6].ToString();
                        numeric_peso.Text = reader[7].ToString();
                        cbo_unidadeMedida.Text = reader[8].ToString();
                        numeric_custo.Text = reader[9].ToString();
                        numeric_venda.Text = reader[10].ToString();
                        cbo_status.Text = reader[11].ToString();
                        txt_obs.Text = reader[12].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código do produto inexistente!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexaoSQL.Close();
                }
            }
        }
        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            numeric_idCategoria.Text = "0";
            numeric_IDFornecedor.Text = "0";
            numeric_IDEstoque.Text = "0";
            numeric_quantidade.Text = "0";
            numeric_peso.Text = "0";
            cbo_unidadeMedida.SelectedIndex = -1;
            numeric_idCategoria.Text = "0";
            numeric_custo.Text = "0";
            numeric_venda.Text = "0";
            cbo_status.SelectedIndex = -1;
            txt_obs.Text = "";
        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            MDITelaIncial inicial = new MDITelaIncial();
            inicial.Show();
            this.Hide();
        }

        private void frm_produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {

        }
    }
}
