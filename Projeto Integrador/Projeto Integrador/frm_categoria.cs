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
    public partial class frm_categoria : Form
    {
        public frm_categoria()
        {
            InitializeComponent();
        }

        string Conexao = frm_produto.Conexao;

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

        private void bto_sair_Click(object sender, EventArgs e)
        {
            MDITelaIncial inicial = new MDITelaIncial();
            inicial.Show();
            this.Hide();
        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            string Cadastro = "Insert into categoria (nome_categoria, descricao_categoria, status_categoria, obs_categoria)" +
            "values ('" + txt_nome.Text + "'," +
            "'" + txt_descricao.Text + "'," +
            "'" + cbo_status.Text + "'," +
            "'" + txt_obs.Text + "')" + "Select SCOPE_IDENTITY()";

            if (txt_nome.Text == "" || txt_descricao.Text == "" || cbo_status.SelectedIndex == -1)
            {
                MessageBox.Show("Algo não foi preenchido");
            }
            else
            {

                SqlConnection conexao = new SqlConnection(Conexao);
                SqlCommand comando = new SqlCommand(Cadastro, conexao);
                comando.CommandType = CommandType.Text;
                SqlDataReader leitura;
                conexao.Open();

                try
                {
                    leitura = comando.ExecuteReader();
                    if (leitura.Read())
                    {
                        MessageBox.Show("Cadastro Realizado com sucesso, Código gerado: " + leitura[0].ToString());
                        numeric_ID.Text = leitura[0].ToString();

                        bto_limpar.PerformClick();
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
        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_descricao.Text = "";
            txt_obs.Text = "";
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            string sql = "update categoria set " +
            "nome_categoria = " + "'" + txt_nome.Text + "'," +
            "descricao_categoria =" + "'" + txt_descricao.Text + "'," +
            "obs_categoria =" + "'" + txt_obs.Text + "'," +
            "status_categoria =" + "'" + cbo_status.Text + "'" +
            "where id_categoria =" + numeric_ID.Text;

            SqlConnection conexao = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.CommandType = CommandType.Text;

            try
            {

                int i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                    bto_limpar.PerformClick();
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

        private void frm_categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bto_pesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from categoria where id_categoria =" + numeric_ID.Text;

            SqlConnection conexaoSQL = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(sql, conexaoSQL);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexaoSQL.Open();

            try
            {
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Pesquisa feita com sucesso, mostrando os resultados...");

                    numeric_ID.Text = reader[0].ToString();
                    txt_nome.Text = reader[1].ToString();
                    txt_descricao.Text = reader[2].ToString();
                    cbo_status.Text = reader[3].ToString();
                    txt_obs.Text = reader[4].ToString();
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
}
