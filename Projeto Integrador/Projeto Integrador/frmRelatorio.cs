namespace Projeto_Integrador
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MDITelaIncial inicial = new MDITelaIncial();
            inicial.Show();
            this.Hide();
        }

        private void frmRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}