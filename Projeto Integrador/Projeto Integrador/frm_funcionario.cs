using System.Data.SqlClient;

namespace Projeto_Integrador
{
    public partial class frm_funcionario : Form
    {
        public frm_funcionario()
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

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            MDITelaIncial mdiInicial = new MDITelaIncial();
            this.Hide();
            mdiInicial.Show();
        }

        private void frm_funcionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_funcionario_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            //verificação aqui

            if (txt_nome.Text.Trim() == "" || txt_cpf.Text.Trim() == "" || txt_email.Text.Trim() == "" || txt_nascimento.Text.Trim() == "" || txt_telefone.Text.Trim() == "" || cbo_genero.Text == "" || cbo_status.Text == "")
            {
                MessageBox.Show("Erro, valores obrigatorios não preenchidos");
                return;
            }

            //fim da verificação

            string Cadastro = "Insert into funcionario (nome_funcionario, cpf_funcionario, data_nascimento, genero_funcionario, telefone_funcionario, email_funcionario, status_funcionario, obs_funcionario)" +
            "values ('" + txt_nome.Text + "'," +
            "'" + txt_cpf.Text + "'," +
            "'" + txt_nascimento.Text + "'," +
            "'" + cbo_genero.Text + "'," +
            "'" + txt_telefone.Text + "'," +
            "'" + txt_email.Text + "'," +
            "'" + cbo_status.Text + "'," +
            "'" + txt_obs.Text + "')" + "Select SCOPE_IDENTITY()";

            SqlConnection conexao = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(Cadastro, conexao);
            comando.CommandType = System.Data.CommandType.Text;
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

        private void bto_pesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from funcionario where id_funcionario =" + numeric_ID.Text;

            SqlConnection conexaoSQL = new SqlConnection(Conexao);
            SqlCommand comando = new SqlCommand(sql, conexaoSQL);
            comando.CommandType = System.Data.CommandType.Text;
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
                    txt_cpf.Text = reader[2].ToString();
                    txt_nascimento.Text = reader[3].ToString();
                    cbo_genero.Text = reader[4].ToString();
                    txt_telefone.Text = reader[5].ToString();
                    txt_email.Text = reader[6].ToString();
                    cbo_status.Text = reader[7].ToString();
                    txt_obs.Text = reader[8].ToString();
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

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            numeric_ID.Text = "0";
            txt_nome.Text = "";
            txt_cpf.Text = "";
            txt_nascimento.Text = "";
            cbo_genero.SelectedIndex = -1;
            txt_telefone.Text = "";
            txt_email.Text = "";
            cbo_status.SelectedIndex = -1;
            txt_obs.Text = "";
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Você tem certeza de que deseja alterar os dados do funcionario?","Alteração",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dialogo == DialogResult.Cancel)
            {
                return;
            }
            else if (dialogo == DialogResult.OK)
            {
                string sql = "update funcionario set " +
                        "nome_funcionario = " + "'" + txt_nome.Text + "'," +
                        "cpf_funcionario =" + "'" + txt_cpf.Text + "'," +
                        "data_nascimento =" + "'" + txt_nascimento.Text + "'," +
                        "genero_funcionario =" + "'" + cbo_genero.Text + "'," +
                        "telefone_funcionario =" + "'" + txt_telefone.Text + "'," +
                        "email_funcionario =" + "'" + txt_email.Text + "'," +
                        "status_funcionario =" + "'" + cbo_status.Text + "'," +
                        "obs_funcionario =" + "'" + txt_obs.Text + "'" +
                        "where id_funcionario =" + numeric_ID.Text;

                SqlConnection conn = new SqlConnection(Conexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                try
                {
                    conn.Open();

                    int i = cmd.ExecuteNonQuery();
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
                    conn.Close();
                }
            }

        }

    }
}
