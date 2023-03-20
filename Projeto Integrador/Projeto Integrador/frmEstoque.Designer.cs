namespace Projeto_Integrador
{
    partial class frmEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.pesquisa_codigo = new System.Windows.Forms.Button();
            this.data_vencimento = new System.Windows.Forms.MaskedTextBox();
            this.categoria_estoque = new System.Windows.Forms.TextBox();
            this.obs_estoque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Status_estoque = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.estoque_descricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome_estoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_estoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data_gride_estoque = new System.Windows.Forms.DataGridView();
            this.pesquisa_estoque = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.excluir_estoque = new System.Windows.Forms.Button();
            this.Limpa_estoque = new System.Windows.Forms.Button();
            this.altera_estoque = new System.Windows.Forms.Button();
            this.cadastra_estoque = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gride_estoque)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.data_cadastro);
            this.groupBox1.Controls.Add(this.pesquisa_codigo);
            this.groupBox1.Controls.Add(this.data_vencimento);
            this.groupBox1.Controls.Add(this.categoria_estoque);
            this.groupBox1.Controls.Add(this.obs_estoque);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Status_estoque);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.estoque_descricao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nome_estoque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.codigo_estoque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "data cadastro";
            // 
            // data_cadastro
            // 
            this.data_cadastro.Location = new System.Drawing.Point(123, 158);
            this.data_cadastro.Mask = "##/##/####";
            this.data_cadastro.Name = "data_cadastro";
            this.data_cadastro.Size = new System.Drawing.Size(102, 23);
            this.data_cadastro.TabIndex = 23;
            // 
            // pesquisa_codigo
            // 
            this.pesquisa_codigo.Location = new System.Drawing.Point(123, 36);
            this.pesquisa_codigo.Name = "pesquisa_codigo";
            this.pesquisa_codigo.Size = new System.Drawing.Size(62, 23);
            this.pesquisa_codigo.TabIndex = 22;
            this.pesquisa_codigo.Text = "pesquisa";
            this.pesquisa_codigo.UseVisualStyleBackColor = true;
            this.pesquisa_codigo.Click += new System.EventHandler(this.pesquisa_codigo_Click);
            // 
            // data_vencimento
            // 
            this.data_vencimento.Location = new System.Drawing.Point(6, 158);
            this.data_vencimento.Mask = "##/##/####";
            this.data_vencimento.Name = "data_vencimento";
            this.data_vencimento.Size = new System.Drawing.Size(102, 23);
            this.data_vencimento.TabIndex = 21;
            // 
            // categoria_estoque
            // 
            this.categoria_estoque.Location = new System.Drawing.Point(135, 97);
            this.categoria_estoque.Name = "categoria_estoque";
            this.categoria_estoque.Size = new System.Drawing.Size(100, 23);
            this.categoria_estoque.TabIndex = 19;
            this.categoria_estoque.TextChanged += new System.EventHandler(this.categoria_estoque_TextChanged);
            // 
            // obs_estoque
            // 
            this.obs_estoque.Location = new System.Drawing.Point(6, 342);
            this.obs_estoque.Multiline = true;
            this.obs_estoque.Name = "obs_estoque";
            this.obs_estoque.Size = new System.Drawing.Size(274, 71);
            this.obs_estoque.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Obs";
            // 
            // Status_estoque
            // 
            this.Status_estoque.FormattingEnabled = true;
            this.Status_estoque.Location = new System.Drawing.Point(7, 295);
            this.Status_estoque.Name = "Status_estoque";
            this.Status_estoque.Size = new System.Drawing.Size(124, 23);
            this.Status_estoque.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Status";
            // 
            // estoque_descricao
            // 
            this.estoque_descricao.Location = new System.Drawing.Point(6, 210);
            this.estoque_descricao.Multiline = true;
            this.estoque_descricao.Name = "estoque_descricao";
            this.estoque_descricao.Size = new System.Drawing.Size(250, 58);
            this.estoque_descricao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descricao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "data de vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria estoque";
            // 
            // nome_estoque
            // 
            this.nome_estoque.Location = new System.Drawing.Point(6, 97);
            this.nome_estoque.Name = "nome_estoque";
            this.nome_estoque.Size = new System.Drawing.Size(111, 23);
            this.nome_estoque.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do estoque";
            // 
            // codigo_estoque
            // 
            this.codigo_estoque.Location = new System.Drawing.Point(6, 37);
            this.codigo_estoque.Name = "codigo_estoque";
            this.codigo_estoque.Size = new System.Drawing.Size(111, 23);
            this.codigo_estoque.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do estoque";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_gride_estoque);
            this.groupBox2.Controls.Add(this.pesquisa_estoque);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Location = new System.Drawing.Point(365, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // data_gride_estoque
            // 
            this.data_gride_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gride_estoque.Location = new System.Drawing.Point(6, 57);
            this.data_gride_estoque.Name = "data_gride_estoque";
            this.data_gride_estoque.RowTemplate.Height = 25;
            this.data_gride_estoque.Size = new System.Drawing.Size(374, 175);
            this.data_gride_estoque.TabIndex = 2;
            this.data_gride_estoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gride_estoque_CellContentClick);
            // 
            // pesquisa_estoque
            // 
            this.pesquisa_estoque.Location = new System.Drawing.Point(305, 19);
            this.pesquisa_estoque.Name = "pesquisa_estoque";
            this.pesquisa_estoque.Size = new System.Drawing.Size(75, 23);
            this.pesquisa_estoque.TabIndex = 1;
            this.pesquisa_estoque.Text = "Pesquisa";
            this.pesquisa_estoque.UseVisualStyleBackColor = true;
            this.pesquisa_estoque.Click += new System.EventHandler(this.pesquisa_estoque_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(280, 23);
            this.textBox6.TabIndex = 0;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.excluir_estoque);
            this.groupBox3.Controls.Add(this.Limpa_estoque);
            this.groupBox3.Controls.Add(this.altera_estoque);
            this.groupBox3.Controls.Add(this.cadastra_estoque);
            this.groupBox3.Location = new System.Drawing.Point(371, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // excluir_estoque
            // 
            this.excluir_estoque.Location = new System.Drawing.Point(149, 85);
            this.excluir_estoque.Name = "excluir_estoque";
            this.excluir_estoque.Size = new System.Drawing.Size(75, 23);
            this.excluir_estoque.TabIndex = 3;
            this.excluir_estoque.Text = "Excluir";
            this.excluir_estoque.UseVisualStyleBackColor = true;
            this.excluir_estoque.Click += new System.EventHandler(this.excluir_estoque_Click);
            // 
            // Limpa_estoque
            // 
            this.Limpa_estoque.Location = new System.Drawing.Point(149, 34);
            this.Limpa_estoque.Name = "Limpa_estoque";
            this.Limpa_estoque.Size = new System.Drawing.Size(75, 23);
            this.Limpa_estoque.TabIndex = 2;
            this.Limpa_estoque.Text = "Limpa";
            this.Limpa_estoque.UseVisualStyleBackColor = true;
            this.Limpa_estoque.Click += new System.EventHandler(this.button4_Click);
            // 
            // altera_estoque
            // 
            this.altera_estoque.Location = new System.Drawing.Point(27, 85);
            this.altera_estoque.Name = "altera_estoque";
            this.altera_estoque.Size = new System.Drawing.Size(75, 23);
            this.altera_estoque.TabIndex = 1;
            this.altera_estoque.Text = "altera";
            this.altera_estoque.UseVisualStyleBackColor = true;
            this.altera_estoque.Click += new System.EventHandler(this.altera_estoque_Click);
            // 
            // cadastra_estoque
            // 
            this.cadastra_estoque.Location = new System.Drawing.Point(27, 34);
            this.cadastra_estoque.Name = "cadastra_estoque";
            this.cadastra_estoque.Size = new System.Drawing.Size(75, 23);
            this.cadastra_estoque.TabIndex = 0;
            this.cadastra_estoque.Text = "Salva";
            this.cadastra_estoque.UseVisualStyleBackColor = true;
            this.cadastra_estoque.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(739, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstoque";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gride_estoque)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox obs_estoque;
        private Label label10;
        private ComboBox Status_estoque;
        private Label label9;
        private TextBox estoque_descricao;
        private Label label7;
        private Label label6;
        private Label label3;
        private TextBox nome_estoque;
        private Label label2;
        private TextBox codigo_estoque;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView data_gride_estoque;
        private Button pesquisa_estoque;
        private TextBox textBox6;
        private GroupBox groupBox3;
        private Button button5;
        private Button Limpa_estoque;
        private Button altera_estoque;
        private Button cadastra_estoque;
        private Button excluir_estoque;
        private MaskedTextBox data_vencimento;
        private TextBox categoria_estoque;
        private Button pesquisa_codigo;
        private Label label4;
        private MaskedTextBox data_cadastro;
    }
}