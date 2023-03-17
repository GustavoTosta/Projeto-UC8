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
    public partial class MDITelaIncial : Form
    {
        public MDITelaIncial()
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

        private void MDITelaIncial_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void pic_1_Click(object sender, EventArgs e)
        {
            frm_funcionario funcionario = new frm_funcionario();
            funcionario.Show();
            this.Hide();
        }

        private void pic3_venda_Click(object sender, EventArgs e)
        {
            //abrir uma message box de escolha entre categoria, estoque, venda
            DialogResult dialogo = MessageBox.Show("Você deseja prosseguir às áreas de produto?", "Áreas", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          
            if (dialogo == DialogResult.No)
            {
                return;
            }

            else if (dialogo == DialogResult.Yes)
            {
                MDI_telaEscolhaProduto escolha = new MDI_telaEscolhaProduto();
                escolha.Show();
                this.Hide();
            }

        }

        private void grupo_1_Enter(object sender, EventArgs e)
        {

        }

        private void pic_3_Click(object sender, EventArgs e)
        {
            //abrir tela de fornecedores
        }

        private void pic2_estatisticas_Click(object sender, EventArgs e)
        {

        }

        private void lbl_funcionario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Estatisticas_Click(object sender, EventArgs e)
        {

        }

        private void lbl_produtos_Click(object sender, EventArgs e)
        {

        }

        private void MDITelaIncial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
