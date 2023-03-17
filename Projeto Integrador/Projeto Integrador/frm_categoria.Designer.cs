namespace Projeto_Integrador
{
    partial class frm_categoria
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
            this.grupo1_ID = new System.Windows.Forms.GroupBox();
            this.numeric_ID = new System.Windows.Forms.NumericUpDown();
            this.bto_pesquisar = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.grupo2_informacoes = new System.Windows.Forms.GroupBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.grupo3_botoes = new System.Windows.Forms.GroupBox();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.grupo1_ID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).BeginInit();
            this.grupo2_informacoes.SuspendLayout();
            this.grupo3_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo1_ID
            // 
            this.grupo1_ID.Controls.Add(this.numeric_ID);
            this.grupo1_ID.Controls.Add(this.bto_pesquisar);
            this.grupo1_ID.Controls.Add(this.lbl_ID);
            this.grupo1_ID.Location = new System.Drawing.Point(12, 12);
            this.grupo1_ID.Name = "grupo1_ID";
            this.grupo1_ID.Size = new System.Drawing.Size(264, 64);
            this.grupo1_ID.TabIndex = 0;
            this.grupo1_ID.TabStop = false;
            // 
            // numeric_ID
            // 
            this.numeric_ID.Location = new System.Drawing.Point(9, 34);
            this.numeric_ID.Name = "numeric_ID";
            this.numeric_ID.Size = new System.Drawing.Size(80, 23);
            this.numeric_ID.TabIndex = 3;
            // 
            // bto_pesquisar
            // 
            this.bto_pesquisar.Location = new System.Drawing.Point(107, 34);
            this.bto_pesquisar.Name = "bto_pesquisar";
            this.bto_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bto_pesquisar.TabIndex = 2;
            this.bto_pesquisar.Text = "Pesquisar";
            this.bto_pesquisar.UseVisualStyleBackColor = true;
            this.bto_pesquisar.Click += new System.EventHandler(this.bto_pesquisar_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(6, 17);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(72, 15);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID Categoria";
            // 
            // grupo2_informacoes
            // 
            this.grupo2_informacoes.Controls.Add(this.txt_obs);
            this.grupo2_informacoes.Controls.Add(this.lbl_obs);
            this.grupo2_informacoes.Controls.Add(this.cbo_status);
            this.grupo2_informacoes.Controls.Add(this.lbl_Status);
            this.grupo2_informacoes.Controls.Add(this.txt_descricao);
            this.grupo2_informacoes.Controls.Add(this.lbl_descricao);
            this.grupo2_informacoes.Controls.Add(this.txt_nome);
            this.grupo2_informacoes.Controls.Add(this.lbl_nome);
            this.grupo2_informacoes.Location = new System.Drawing.Point(12, 82);
            this.grupo2_informacoes.Name = "grupo2_informacoes";
            this.grupo2_informacoes.Size = new System.Drawing.Size(657, 271);
            this.grupo2_informacoes.TabIndex = 1;
            this.grupo2_informacoes.TabStop = false;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(9, 147);
            this.txt_obs.MaxLength = 100;
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.PlaceholderText = "Opcional";
            this.txt_obs.Size = new System.Drawing.Size(234, 101);
            this.txt_obs.TabIndex = 7;
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Location = new System.Drawing.Point(9, 129);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(69, 15);
            this.lbl_obs.TabIndex = 6;
            this.lbl_obs.Text = "Observação";
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Em Análise"});
            this.cbo_status.Location = new System.Drawing.Point(8, 91);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 5;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(8, 73);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(39, 15);
            this.lbl_Status.TabIndex = 4;
            this.lbl_Status.Text = "Status";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(303, 37);
            this.txt_descricao.MaxLength = 100;
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(348, 211);
            this.txt_descricao.TabIndex = 3;
            this.txt_descricao.Text = " ";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(440, 19);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(58, 15);
            this.lbl_descricao.TabIndex = 2;
            this.lbl_descricao.Text = "Descrição";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(6, 37);
            this.txt_nome.MaxLength = 30;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(218, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // grupo3_botoes
            // 
            this.grupo3_botoes.Controls.Add(this.bto_excluir);
            this.grupo3_botoes.Controls.Add(this.bto_alterar);
            this.grupo3_botoes.Controls.Add(this.bto_cadastrar);
            this.grupo3_botoes.Controls.Add(this.bto_limpar);
            this.grupo3_botoes.Controls.Add(this.bto_sair);
            this.grupo3_botoes.Location = new System.Drawing.Point(12, 379);
            this.grupo3_botoes.Name = "grupo3_botoes";
            this.grupo3_botoes.Size = new System.Drawing.Size(657, 59);
            this.grupo3_botoes.TabIndex = 2;
            this.grupo3_botoes.TabStop = false;
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(295, 22);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(75, 23);
            this.bto_excluir.TabIndex = 9;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(464, 22);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 8;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(545, 22);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 7;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(138, 22);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 6;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(33, 22);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 5;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // frm_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.grupo3_botoes);
            this.Controls.Add(this.grupo2_informacoes);
            this.Controls.Add(this.grupo1_ID);
            this.Name = "frm_categoria";
            this.Text = "Tela de categoria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_categoria_FormClosed);
            this.Load += new System.EventHandler(this.frm_categoria_Load);
            this.grupo1_ID.ResumeLayout(false);
            this.grupo1_ID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).EndInit();
            this.grupo2_informacoes.ResumeLayout(false);
            this.grupo2_informacoes.PerformLayout();
            this.grupo3_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupo1_ID;
        private Button bto_pesquisar;
        private Label lbl_ID;
        private GroupBox grupo2_informacoes;
        private TextBox txt_nome;
        private Label lbl_nome;
        private TextBox txt_obs;
        private Label lbl_obs;
        private ComboBox cbo_status;
        private Label lbl_Status;
        private TextBox txt_descricao;
        private Label lbl_descricao;
        private GroupBox grupo3_botoes;
        private Button bto_excluir;
        private Button bto_alterar;
        private Button bto_cadastrar;
        private Button bto_limpar;
        private Button bto_sair;
        private NumericUpDown numeric_ID;
    }
}