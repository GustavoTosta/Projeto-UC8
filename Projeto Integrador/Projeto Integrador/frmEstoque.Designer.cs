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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data_gride_estoque = new System.Windows.Forms.DataGridView();
            this.txt_pesquisaDataGrid = new System.Windows.Forms.TextBox();
            this.excluir_estoque = new System.Windows.Forms.Button();
            this.Limpa_estoque = new System.Windows.Forms.Button();
            this.alterar_estoque = new System.Windows.Forms.Button();
            this.cadastrar_estoque = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.codigo_estoque = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gride_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigo_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codigo_estoque);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pesquisa_codigo
            // 
            this.pesquisa_codigo.Location = new System.Drawing.Point(109, 27);
            this.pesquisa_codigo.Name = "pesquisa_codigo";
            this.pesquisa_codigo.Size = new System.Drawing.Size(78, 23);
            this.pesquisa_codigo.TabIndex = 22;
            this.pesquisa_codigo.Text = "Pesquisar";
            this.pesquisa_codigo.UseVisualStyleBackColor = true;
            this.pesquisa_codigo.Click += new System.EventHandler(this.pesquisa_codigo_Click);
            // 
            // data_vencimento
            // 
            this.data_vencimento.Location = new System.Drawing.Point(6, 140);
            this.data_vencimento.Mask = "##/##/####";
            this.data_vencimento.Name = "data_vencimento";
            this.data_vencimento.Size = new System.Drawing.Size(73, 23);
            this.data_vencimento.TabIndex = 21;
            // 
            // categoria_estoque
            // 
            this.categoria_estoque.Location = new System.Drawing.Point(135, 88);
            this.categoria_estoque.MaxLength = 100;
            this.categoria_estoque.Name = "categoria_estoque";
            this.categoria_estoque.Size = new System.Drawing.Size(100, 23);
            this.categoria_estoque.TabIndex = 19;
            this.categoria_estoque.TextChanged += new System.EventHandler(this.categoria_estoque_TextChanged);
            // 
            // obs_estoque
            // 
            this.obs_estoque.Location = new System.Drawing.Point(6, 301);
            this.obs_estoque.MaxLength = 255;
            this.obs_estoque.Multiline = true;
            this.obs_estoque.Name = "obs_estoque";
            this.obs_estoque.PlaceholderText = "Opcional";
            this.obs_estoque.Size = new System.Drawing.Size(206, 83);
            this.obs_estoque.TabIndex = 18;
            this.obs_estoque.TextChanged += new System.EventHandler(this.obs_estoque_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Obs";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Status_estoque
            // 
            this.Status_estoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_estoque.FormattingEnabled = true;
            this.Status_estoque.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.Status_estoque.Location = new System.Drawing.Point(123, 140);
            this.Status_estoque.Name = "Status_estoque";
            this.Status_estoque.Size = new System.Drawing.Size(124, 23);
            this.Status_estoque.TabIndex = 15;
            this.Status_estoque.SelectedIndexChanged += new System.EventHandler(this.Status_estoque_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Status";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // estoque_descricao
            // 
            this.estoque_descricao.Location = new System.Drawing.Point(6, 192);
            this.estoque_descricao.MaxLength = 255;
            this.estoque_descricao.Multiline = true;
            this.estoque_descricao.Name = "estoque_descricao";
            this.estoque_descricao.PlaceholderText = "Descrição estoque";
            this.estoque_descricao.Size = new System.Drawing.Size(287, 86);
            this.estoque_descricao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descricao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data de vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria estoque";
            // 
            // nome_estoque
            // 
            this.nome_estoque.Location = new System.Drawing.Point(6, 88);
            this.nome_estoque.MaxLength = 100;
            this.nome_estoque.Name = "nome_estoque";
            this.nome_estoque.Size = new System.Drawing.Size(111, 23);
            this.nome_estoque.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do estoque";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_gride_estoque);
            this.groupBox2.Controls.Add(this.txt_pesquisaDataGrid);
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
            // txt_pesquisaDataGrid
            // 
            this.txt_pesquisaDataGrid.Location = new System.Drawing.Point(6, 19);
            this.txt_pesquisaDataGrid.Name = "txt_pesquisaDataGrid";
            this.txt_pesquisaDataGrid.PlaceholderText = "Pesquise aqui por nome";
            this.txt_pesquisaDataGrid.Size = new System.Drawing.Size(280, 23);
            this.txt_pesquisaDataGrid.TabIndex = 0;
            this.txt_pesquisaDataGrid.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // excluir_estoque
            // 
            this.excluir_estoque.Location = new System.Drawing.Point(422, 415);
            this.excluir_estoque.Name = "excluir_estoque";
            this.excluir_estoque.Size = new System.Drawing.Size(79, 33);
            this.excluir_estoque.TabIndex = 3;
            this.excluir_estoque.Text = "Excluir";
            this.excluir_estoque.UseVisualStyleBackColor = true;
            this.excluir_estoque.Click += new System.EventHandler(this.excluir_estoque_Click);
            // 
            // Limpa_estoque
            // 
            this.Limpa_estoque.Location = new System.Drawing.Point(216, 415);
            this.Limpa_estoque.Name = "Limpa_estoque";
            this.Limpa_estoque.Size = new System.Drawing.Size(75, 33);
            this.Limpa_estoque.TabIndex = 2;
            this.Limpa_estoque.Text = "Limpa";
            this.Limpa_estoque.UseVisualStyleBackColor = true;
            this.Limpa_estoque.Click += new System.EventHandler(this.button4_Click);
            // 
            // alterar_estoque
            // 
            this.alterar_estoque.Location = new System.Drawing.Point(604, 415);
            this.alterar_estoque.Name = "alterar_estoque";
            this.alterar_estoque.Size = new System.Drawing.Size(79, 32);
            this.alterar_estoque.TabIndex = 1;
            this.alterar_estoque.Text = "Alterar";
            this.alterar_estoque.UseVisualStyleBackColor = true;
            this.alterar_estoque.Click += new System.EventHandler(this.altera_estoque_Click);
            // 
            // cadastrar_estoque
            // 
            this.cadastrar_estoque.Location = new System.Drawing.Point(713, 415);
            this.cadastrar_estoque.Name = "cadastrar_estoque";
            this.cadastrar_estoque.Size = new System.Drawing.Size(75, 31);
            this.cadastrar_estoque.TabIndex = 0;
            this.cadastrar_estoque.Text = "Cadastrar";
            this.cadastrar_estoque.UseVisualStyleBackColor = true;
            this.cadastrar_estoque.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 32);
            this.button5.TabIndex = 3;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // codigo_estoque
            // 
            this.codigo_estoque.Location = new System.Drawing.Point(6, 27);
            this.codigo_estoque.Name = "codigo_estoque";
            this.codigo_estoque.Size = new System.Drawing.Size(73, 23);
            this.codigo_estoque.TabIndex = 23;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpa_estoque);
            this.Controls.Add(this.excluir_estoque);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.alterar_estoque);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cadastrar_estoque);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstoque";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gride_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigo_estoque)).EndInit();
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
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView data_gride_estoque;
        private TextBox txt_pesquisaDataGrid;
        private Button button5;
        private Button Limpa_estoque;
        private Button alterar_estoque;
        private Button cadastrar_estoque;
        private Button excluir_estoque;
        private MaskedTextBox data_vencimento;
        private TextBox categoria_estoque;
        private Button pesquisa_codigo;
        private NumericUpDown codigo_estoque;
    }
}