namespace Projeto_Integrador
{
    partial class frm_produto
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
            this.grupo1_pesquisa = new System.Windows.Forms.GroupBox();
            this.numeric_idProduto = new System.Windows.Forms.NumericUpDown();
            this.bto_pesquisa = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.grupo3_info = new System.Windows.Forms.GroupBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.numeric_venda = new System.Windows.Forms.NumericUpDown();
            this.lbl_valorVenda = new System.Windows.Forms.Label();
            this.numeric_custo = new System.Windows.Forms.NumericUpDown();
            this.lbl_valorCusto = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.cbo_unidadeMedida = new System.Windows.Forms.ComboBox();
            this.lbl_unidadeMedida = new System.Windows.Forms.Label();
            this.numeric_peso = new System.Windows.Forms.NumericUpDown();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.numeric_quantidade = new System.Windows.Forms.NumericUpDown();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.grupo2_IDs = new System.Windows.Forms.GroupBox();
            this.numeric_IDEstoque = new System.Windows.Forms.NumericUpDown();
            this.lbl_IDEstoque = new System.Windows.Forms.Label();
            this.numeric_idCategoria = new System.Windows.Forms.NumericUpDown();
            this.lbl_idCategoria = new System.Windows.Forms.Label();
            this.numeric_IDFornecedor = new System.Windows.Forms.NumericUpDown();
            this.lbl_IDFornecedor = new System.Windows.Forms.Label();
            this.grupo4_botoes = new System.Windows.Forms.GroupBox();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.grupo1_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_idProduto)).BeginInit();
            this.grupo3_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_custo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).BeginInit();
            this.grupo2_IDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IDEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_idCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IDFornecedor)).BeginInit();
            this.grupo4_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo1_pesquisa
            // 
            this.grupo1_pesquisa.Controls.Add(this.numeric_idProduto);
            this.grupo1_pesquisa.Controls.Add(this.bto_pesquisa);
            this.grupo1_pesquisa.Controls.Add(this.lbl_ID);
            this.grupo1_pesquisa.Location = new System.Drawing.Point(12, 12);
            this.grupo1_pesquisa.Name = "grupo1_pesquisa";
            this.grupo1_pesquisa.Size = new System.Drawing.Size(231, 82);
            this.grupo1_pesquisa.TabIndex = 0;
            this.grupo1_pesquisa.TabStop = false;
            // 
            // numeric_idProduto
            // 
            this.numeric_idProduto.Location = new System.Drawing.Point(15, 36);
            this.numeric_idProduto.Name = "numeric_idProduto";
            this.numeric_idProduto.Size = new System.Drawing.Size(89, 23);
            this.numeric_idProduto.TabIndex = 3;
            // 
            // bto_pesquisa
            // 
            this.bto_pesquisa.Location = new System.Drawing.Point(133, 36);
            this.bto_pesquisa.Name = "bto_pesquisa";
            this.bto_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.bto_pesquisa.TabIndex = 2;
            this.bto_pesquisa.Text = "Pesquisa";
            this.bto_pesquisa.UseVisualStyleBackColor = true;
            this.bto_pesquisa.Click += new System.EventHandler(this.bto_pesquisa_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(13, 18);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(64, 15);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID produto";
            // 
            // grupo3_info
            // 
            this.grupo3_info.Controls.Add(this.lbl_obs);
            this.grupo3_info.Controls.Add(this.txt_obs);
            this.grupo3_info.Controls.Add(this.cbo_status);
            this.grupo3_info.Controls.Add(this.lbl_status);
            this.grupo3_info.Controls.Add(this.numeric_venda);
            this.grupo3_info.Controls.Add(this.lbl_valorVenda);
            this.grupo3_info.Controls.Add(this.numeric_custo);
            this.grupo3_info.Controls.Add(this.lbl_valorCusto);
            this.grupo3_info.Controls.Add(this.txt_descricao);
            this.grupo3_info.Controls.Add(this.lbl_descricao);
            this.grupo3_info.Controls.Add(this.cbo_unidadeMedida);
            this.grupo3_info.Controls.Add(this.lbl_unidadeMedida);
            this.grupo3_info.Controls.Add(this.numeric_peso);
            this.grupo3_info.Controls.Add(this.lbl_peso);
            this.grupo3_info.Controls.Add(this.numeric_quantidade);
            this.grupo3_info.Controls.Add(this.lbl_quantidade);
            this.grupo3_info.Controls.Add(this.txt_nome);
            this.grupo3_info.Controls.Add(this.lbl_nome);
            this.grupo3_info.Location = new System.Drawing.Point(12, 100);
            this.grupo3_info.Name = "grupo3_info";
            this.grupo3_info.Size = new System.Drawing.Size(776, 256);
            this.grupo3_info.TabIndex = 2;
            this.grupo3_info.TabStop = false;
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(653, 19);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(69, 15);
            this.lbl_obs.TabIndex = 19;
            this.lbl_obs.Text = "Observação";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(609, 37);
            this.txt_obs.MaxLength = 150;
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.PlaceholderText = "Opcional";
            this.txt_obs.Size = new System.Drawing.Size(161, 72);
            this.txt_obs.TabIndex = 18;
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Em Análise"});
            this.cbo_status.Location = new System.Drawing.Point(15, 195);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 17;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(15, 177);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 16;
            this.lbl_status.Text = "Status";
            // 
            // numeric_venda
            // 
            this.numeric_venda.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_venda.Location = new System.Drawing.Point(119, 143);
            this.numeric_venda.Name = "numeric_venda";
            this.numeric_venda.Size = new System.Drawing.Size(81, 23);
            this.numeric_venda.TabIndex = 15;
            // 
            // lbl_valorVenda
            // 
            this.lbl_valorVenda.AutoSize = true;
            this.lbl_valorVenda.Location = new System.Drawing.Point(117, 125);
            this.lbl_valorVenda.Name = "lbl_valorVenda";
            this.lbl_valorVenda.Size = new System.Drawing.Size(68, 15);
            this.lbl_valorVenda.TabIndex = 14;
            this.lbl_valorVenda.Text = "Valor Venda";
            // 
            // numeric_custo
            // 
            this.numeric_custo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_custo.Location = new System.Drawing.Point(15, 143);
            this.numeric_custo.Name = "numeric_custo";
            this.numeric_custo.Size = new System.Drawing.Size(81, 23);
            this.numeric_custo.TabIndex = 13;
            // 
            // lbl_valorCusto
            // 
            this.lbl_valorCusto.AutoSize = true;
            this.lbl_valorCusto.Location = new System.Drawing.Point(13, 125);
            this.lbl_valorCusto.Name = "lbl_valorCusto";
            this.lbl_valorCusto.Size = new System.Drawing.Size(67, 15);
            this.lbl_valorCusto.TabIndex = 12;
            this.lbl_valorCusto.Text = "Valor Custo";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(378, 37);
            this.txt_descricao.MaxLength = 50;
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.PlaceholderText = "Uma descrição com 50 caracteres";
            this.txt_descricao.Size = new System.Drawing.Size(215, 181);
            this.txt_descricao.TabIndex = 9;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(455, 19);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(58, 15);
            this.lbl_descricao.TabIndex = 8;
            this.lbl_descricao.Text = "Descrição";
            // 
            // cbo_unidadeMedida
            // 
            this.cbo_unidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_unidadeMedida.FormattingEnabled = true;
            this.cbo_unidadeMedida.Items.AddRange(new object[] {
            "t",
            "kg",
            "g",
            "mg"});
            this.cbo_unidadeMedida.Location = new System.Drawing.Point(229, 87);
            this.cbo_unidadeMedida.Name = "cbo_unidadeMedida";
            this.cbo_unidadeMedida.Size = new System.Drawing.Size(83, 23);
            this.cbo_unidadeMedida.TabIndex = 7;
            // 
            // lbl_unidadeMedida
            // 
            this.lbl_unidadeMedida.AutoSize = true;
            this.lbl_unidadeMedida.Location = new System.Drawing.Point(215, 69);
            this.lbl_unidadeMedida.Name = "lbl_unidadeMedida";
            this.lbl_unidadeMedida.Size = new System.Drawing.Size(110, 15);
            this.lbl_unidadeMedida.TabIndex = 6;
            this.lbl_unidadeMedida.Text = "Unidade de Medida";
            // 
            // numeric_peso
            // 
            this.numeric_peso.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numeric_peso.Location = new System.Drawing.Point(119, 86);
            this.numeric_peso.Name = "numeric_peso";
            this.numeric_peso.Size = new System.Drawing.Size(83, 23);
            this.numeric_peso.TabIndex = 5;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(119, 68);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(32, 15);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "Peso";
            // 
            // numeric_quantidade
            // 
            this.numeric_quantidade.Location = new System.Drawing.Point(13, 87);
            this.numeric_quantidade.Name = "numeric_quantidade";
            this.numeric_quantidade.Size = new System.Drawing.Size(83, 23);
            this.numeric_quantidade.TabIndex = 3;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(13, 69);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(69, 15);
            this.lbl_quantidade.TabIndex = 2;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 37);
            this.txt_nome.MaxLength = 30;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(189, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(13, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // grupo2_IDs
            // 
            this.grupo2_IDs.Controls.Add(this.numeric_IDEstoque);
            this.grupo2_IDs.Controls.Add(this.lbl_IDEstoque);
            this.grupo2_IDs.Controls.Add(this.numeric_idCategoria);
            this.grupo2_IDs.Controls.Add(this.lbl_idCategoria);
            this.grupo2_IDs.Controls.Add(this.numeric_IDFornecedor);
            this.grupo2_IDs.Controls.Add(this.lbl_IDFornecedor);
            this.grupo2_IDs.Location = new System.Drawing.Point(261, 12);
            this.grupo2_IDs.Name = "grupo2_IDs";
            this.grupo2_IDs.Size = new System.Drawing.Size(378, 82);
            this.grupo2_IDs.TabIndex = 1;
            this.grupo2_IDs.TabStop = false;
            // 
            // numeric_IDEstoque
            // 
            this.numeric_IDEstoque.Location = new System.Drawing.Point(245, 36);
            this.numeric_IDEstoque.Name = "numeric_IDEstoque";
            this.numeric_IDEstoque.Size = new System.Drawing.Size(86, 23);
            this.numeric_IDEstoque.TabIndex = 5;
            // 
            // lbl_IDEstoque
            // 
            this.lbl_IDEstoque.AutoSize = true;
            this.lbl_IDEstoque.Location = new System.Drawing.Point(245, 18);
            this.lbl_IDEstoque.Name = "lbl_IDEstoque";
            this.lbl_IDEstoque.Size = new System.Drawing.Size(63, 15);
            this.lbl_IDEstoque.TabIndex = 4;
            this.lbl_IDEstoque.Text = "ID Estoque";
            // 
            // numeric_idCategoria
            // 
            this.numeric_idCategoria.Location = new System.Drawing.Point(129, 36);
            this.numeric_idCategoria.Name = "numeric_idCategoria";
            this.numeric_idCategoria.Size = new System.Drawing.Size(86, 23);
            this.numeric_idCategoria.TabIndex = 3;
            // 
            // lbl_idCategoria
            // 
            this.lbl_idCategoria.AutoSize = true;
            this.lbl_idCategoria.Location = new System.Drawing.Point(129, 18);
            this.lbl_idCategoria.Name = "lbl_idCategoria";
            this.lbl_idCategoria.Size = new System.Drawing.Size(72, 15);
            this.lbl_idCategoria.TabIndex = 2;
            this.lbl_idCategoria.Text = "ID Categoria";
            // 
            // numeric_IDFornecedor
            // 
            this.numeric_IDFornecedor.Location = new System.Drawing.Point(15, 36);
            this.numeric_IDFornecedor.Name = "numeric_IDFornecedor";
            this.numeric_IDFornecedor.Size = new System.Drawing.Size(86, 23);
            this.numeric_IDFornecedor.TabIndex = 1;
            // 
            // lbl_IDFornecedor
            // 
            this.lbl_IDFornecedor.AutoSize = true;
            this.lbl_IDFornecedor.Location = new System.Drawing.Point(15, 18);
            this.lbl_IDFornecedor.Name = "lbl_IDFornecedor";
            this.lbl_IDFornecedor.Size = new System.Drawing.Size(81, 15);
            this.lbl_IDFornecedor.TabIndex = 0;
            this.lbl_IDFornecedor.Text = "ID Fornecedor";
            // 
            // grupo4_botoes
            // 
            this.grupo4_botoes.Controls.Add(this.bto_excluir);
            this.grupo4_botoes.Controls.Add(this.bto_alterar);
            this.grupo4_botoes.Controls.Add(this.bto_cadastrar);
            this.grupo4_botoes.Controls.Add(this.bto_limpar);
            this.grupo4_botoes.Controls.Add(this.bto_sair);
            this.grupo4_botoes.Location = new System.Drawing.Point(12, 391);
            this.grupo4_botoes.Name = "grupo4_botoes";
            this.grupo4_botoes.Size = new System.Drawing.Size(776, 57);
            this.grupo4_botoes.TabIndex = 3;
            this.grupo4_botoes.TabStop = false;
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(360, 22);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 9;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(529, 22);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 8;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(610, 22);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 7;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(203, 22);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 6;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(98, 22);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 5;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // frm_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupo4_botoes);
            this.Controls.Add(this.grupo2_IDs);
            this.Controls.Add(this.grupo3_info);
            this.Controls.Add(this.grupo1_pesquisa);
            this.Name = "frm_produto";
            this.Text = "Tela de produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_produto_FormClosed);
            this.Load += new System.EventHandler(this.frm_produto_Load);
            this.grupo1_pesquisa.ResumeLayout(false);
            this.grupo1_pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_idProduto)).EndInit();
            this.grupo3_info.ResumeLayout(false);
            this.grupo3_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_custo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).EndInit();
            this.grupo2_IDs.ResumeLayout(false);
            this.grupo2_IDs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IDEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_idCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IDFornecedor)).EndInit();
            this.grupo4_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupo1_pesquisa;
        private Button bto_pesquisa;
        private Label lbl_ID;
        private GroupBox grupo3_info;
        private ComboBox cbo_status;
        private Label lbl_status;
        private NumericUpDown numeric_venda;
        private Label lbl_valorVenda;
        private NumericUpDown numeric_custo;
        private Label lbl_valorCusto;
        private TextBox txt_descricao;
        private Label lbl_descricao;
        private ComboBox cbo_unidadeMedida;
        private Label lbl_unidadeMedida;
        private NumericUpDown numeric_peso;
        private Label lbl_peso;
        private NumericUpDown numeric_quantidade;
        private Label lbl_quantidade;
        private TextBox txt_nome;
        private Label lbl_nome;
        private GroupBox grupo2_IDs;
        private NumericUpDown numeric_idProduto;
        private Label lbl_obs;
        private TextBox txt_obs;
        private NumericUpDown numeric_IDEstoque;
        private Label lbl_IDEstoque;
        private NumericUpDown numeric_idCategoria;
        private Label lbl_idCategoria;
        private NumericUpDown numeric_IDFornecedor;
        private Label lbl_IDFornecedor;
        private GroupBox grupo4_botoes;
        private Button bto_alterar;
        private Button bto_cadastrar;
        private Button bto_limpar;
        private Button bto_sair;
        private Button bto_excluir;
    }
}