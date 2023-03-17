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
    public partial class MDI_telaEscolhaProduto : Form
    {
        public MDI_telaEscolhaProduto()
        {
            InitializeComponent();
        }

        string conexao = frm_produto.Conexao;
        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(conexao);
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

        private void lbl_produtos_Click(object sender, EventArgs e)
        {

        }

        private void frm_telaEscolhaProduto_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void pic2_estatisticas_Click(object sender, EventArgs e)
        {

        }

        private void lbl_funcionario_Click(object sender, EventArgs e)
        {

        }

        private void pic_funcionario_Click(object sender, EventArgs e)
        {
            frm_categoria categoria = new frm_categoria();
            categoria.Show();
            this.Hide();
            
        }

        private void lbl_Estatisticas_Click(object sender, EventArgs e)
        {

        }

        private void pic3_venda_Click(object sender, EventArgs e)
        {

        }

        private void pic_produto_Click(object sender, EventArgs e)
        {
            frm_produto produto = new frm_produto();
            this.Hide();
            produto.Show();
        }

        private void bto_voltar_Click(object sender, EventArgs e)
        {
            MDITelaIncial mdi = new MDITelaIncial();
            mdi.Show();
            this.Hide();
        }
    }
}
