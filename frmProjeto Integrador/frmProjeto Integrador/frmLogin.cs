using System.Data;
using System.Data.SqlClient;

namespace frmProjeto_Integrador
{

    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        
        public static string StringConexao = " " +
            "Data Source = localhost;" +
            "initial Catalog = projetoCS;" +
            "User = sa;" +
            "password = 123456";

        private void TestarConexao()
        {
            try
            {
                SqlConnection conn = new SqlConnection(StringConexao);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bto_ok_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where " +
                "nome_usuario = '" + txt_usuario.Text + "' and " +
                "senha_usuario = '" + txt_senha.Text + "'";

            SqlConnection conn = new SqlConnection(StringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    MessageBox.Show("Seja bem vindo");
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }
              
            }
            catch (Exception)
            {
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }
        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}