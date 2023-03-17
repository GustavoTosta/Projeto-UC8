namespace Projeto_Integrador
{
    partial class frm_funcionario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_IDfuncionario = new System.Windows.Forms.Label();
            this.grupo_id = new System.Windows.Forms.GroupBox();
            this.numeric_ID = new System.Windows.Forms.NumericUpDown();
            this.bto_pesquisar = new System.Windows.Forms.Button();
            this.grupo2_caracteristicas = new System.Windows.Forms.GroupBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.txt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dataNascimento = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nomeFuncionario = new System.Windows.Forms.Label();
            this.grupo3_botoes = new System.Windows.Forms.GroupBox();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.grupo_id.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).BeginInit();
            this.grupo2_caracteristicas.SuspendLayout();
            this.grupo3_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IDfuncionario
            // 
            this.lbl_IDfuncionario.AutoSize = true;
            this.lbl_IDfuncionario.Location = new System.Drawing.Point(6, 23);
            this.lbl_IDfuncionario.Name = "lbl_IDfuncionario";
            this.lbl_IDfuncionario.Size = new System.Drawing.Size(84, 15);
            this.lbl_IDfuncionario.TabIndex = 0;
            this.lbl_IDfuncionario.Text = "ID Funcionário";
            // 
            // grupo_id
            // 
            this.grupo_id.Controls.Add(this.numeric_ID);
            this.grupo_id.Controls.Add(this.bto_pesquisar);
            this.grupo_id.Controls.Add(this.lbl_IDfuncionario);
            this.grupo_id.Location = new System.Drawing.Point(12, 3);
            this.grupo_id.Name = "grupo_id";
            this.grupo_id.Size = new System.Drawing.Size(361, 73);
            this.grupo_id.TabIndex = 2;
            this.grupo_id.TabStop = false;
            // 
            // numeric_ID
            // 
            this.numeric_ID.Location = new System.Drawing.Point(6, 41);
            this.numeric_ID.Name = "numeric_ID";
            this.numeric_ID.Size = new System.Drawing.Size(84, 23);
            this.numeric_ID.TabIndex = 3;
            // 
            // bto_pesquisar
            // 
            this.bto_pesquisar.Location = new System.Drawing.Point(112, 41);
            this.bto_pesquisar.Name = "bto_pesquisar";
            this.bto_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bto_pesquisar.TabIndex = 2;
            this.bto_pesquisar.Text = "Pesquisar";
            this.bto_pesquisar.UseVisualStyleBackColor = true;
            this.bto_pesquisar.Click += new System.EventHandler(this.bto_pesquisar_Click);
            // 
            // grupo2_caracteristicas
            // 
            this.grupo2_caracteristicas.Controls.Add(this.txt_obs);
            this.grupo2_caracteristicas.Controls.Add(this.label1);
            this.grupo2_caracteristicas.Controls.Add(this.cbo_status);
            this.grupo2_caracteristicas.Controls.Add(this.lbl_status);
            this.grupo2_caracteristicas.Controls.Add(this.txt_email);
            this.grupo2_caracteristicas.Controls.Add(this.lbl_email);
            this.grupo2_caracteristicas.Controls.Add(this.lbl_telefone);
            this.grupo2_caracteristicas.Controls.Add(this.txt_telefone);
            this.grupo2_caracteristicas.Controls.Add(this.lbl_Genero);
            this.grupo2_caracteristicas.Controls.Add(this.cbo_genero);
            this.grupo2_caracteristicas.Controls.Add(this.txt_nascimento);
            this.grupo2_caracteristicas.Controls.Add(this.lbl_dataNascimento);
            this.grupo2_caracteristicas.Controls.Add(this.txt_cpf);
            this.grupo2_caracteristicas.Controls.Add(this.lbl_cpf);
            this.grupo2_caracteristicas.Controls.Add(this.txt_nome);
            this.grupo2_caracteristicas.Controls.Add(this.lbl_nomeFuncionario);
            this.grupo2_caracteristicas.Location = new System.Drawing.Point(12, 82);
            this.grupo2_caracteristicas.Name = "grupo2_caracteristicas";
            this.grupo2_caracteristicas.Size = new System.Drawing.Size(642, 334);
            this.grupo2_caracteristicas.TabIndex = 3;
            this.grupo2_caracteristicas.TabStop = false;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(24, 182);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(587, 146);
            this.txt_obs.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Observação";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(349, 94);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 23);
            this.cbo_status.TabIndex = 13;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(349, 76);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 12;
            this.lbl_status.Text = "Status";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(6, 94);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(198, 23);
            this.txt_email.TabIndex = 11;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 76);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 15);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(227, 76);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(51, 15);
            this.lbl_telefone.TabIndex = 9;
            this.lbl_telefone.Text = "Telefone";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(227, 94);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(92, 23);
            this.txt_telefone.TabIndex = 8;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(349, 19);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(45, 15);
            this.lbl_Genero.TabIndex = 7;
            this.lbl_Genero.Text = "Gênero";
            // 
            // cbo_genero
            // 
            this.cbo_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbo_genero.Location = new System.Drawing.Point(349, 37);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(99, 23);
            this.cbo_genero.TabIndex = 6;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(481, 37);
            this.txt_nascimento.Mask = "00/00/0000";
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(67, 23);
            this.txt_nascimento.TabIndex = 5;
            this.txt_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_dataNascimento
            // 
            this.lbl_dataNascimento.AutoSize = true;
            this.lbl_dataNascimento.Location = new System.Drawing.Point(463, 19);
            this.lbl_dataNascimento.Name = "lbl_dataNascimento";
            this.lbl_dataNascimento.Size = new System.Drawing.Size(112, 15);
            this.lbl_dataNascimento.TabIndex = 4;
            this.lbl_dataNascimento.Text = "Data de nascimento";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(227, 37);
            this.txt_cpf.Mask = "000,000,000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(92, 23);
            this.txt_cpf.TabIndex = 3;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(227, 19);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(28, 15);
            this.lbl_cpf.TabIndex = 2;
            this.lbl_cpf.Text = "CPF";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(6, 37);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(198, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nomeFuncionario
            // 
            this.lbl_nomeFuncionario.AutoSize = true;
            this.lbl_nomeFuncionario.Location = new System.Drawing.Point(6, 19);
            this.lbl_nomeFuncionario.Name = "lbl_nomeFuncionario";
            this.lbl_nomeFuncionario.Size = new System.Drawing.Size(40, 15);
            this.lbl_nomeFuncionario.TabIndex = 0;
            this.lbl_nomeFuncionario.Text = "Nome";
            // 
            // grupo3_botoes
            // 
            this.grupo3_botoes.Controls.Add(this.bto_alterar);
            this.grupo3_botoes.Controls.Add(this.bto_cadastrar);
            this.grupo3_botoes.Controls.Add(this.bto_limpar);
            this.grupo3_botoes.Controls.Add(this.bto_sair);
            this.grupo3_botoes.Location = new System.Drawing.Point(12, 422);
            this.grupo3_botoes.Name = "grupo3_botoes";
            this.grupo3_botoes.Size = new System.Drawing.Size(642, 60);
            this.grupo3_botoes.TabIndex = 4;
            this.grupo3_botoes.TabStop = false;
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(455, 22);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(75, 23);
            this.bto_alterar.TabIndex = 3;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            this.bto_alterar.Click += new System.EventHandler(this.bto_alterar_Click);
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(536, 22);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bto_cadastrar.TabIndex = 2;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            this.bto_cadastrar.Click += new System.EventHandler(this.bto_cadastrar_Click);
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(105, 22);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(75, 23);
            this.bto_limpar.TabIndex = 1;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            this.bto_limpar.Click += new System.EventHandler(this.bto_limpar_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(24, 22);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 0;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 492);
            this.Controls.Add(this.grupo3_botoes);
            this.Controls.Add(this.grupo2_caracteristicas);
            this.Controls.Add(this.grupo_id);
            this.Name = "frm_funcionario";
            this.Text = "Tela do Funcionário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_funcionario_FormClosed);
            this.Load += new System.EventHandler(this.frm_funcionario_Load);
            this.grupo_id.ResumeLayout(false);
            this.grupo_id.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).EndInit();
            this.grupo2_caracteristicas.ResumeLayout(false);
            this.grupo2_caracteristicas.PerformLayout();
            this.grupo3_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_IDfuncionario;
        private GroupBox grupo_id;
        private Button bto_pesquisar;
        private GroupBox grupo2_caracteristicas;
        private TextBox txt_email;
        private Label lbl_email;
        private Label lbl_telefone;
        private MaskedTextBox txt_telefone;
        private Label lbl_Genero;
        private ComboBox cbo_genero;
        private MaskedTextBox txt_nascimento;
        private Label lbl_dataNascimento;
        private MaskedTextBox txt_cpf;
        private Label lbl_cpf;
        private TextBox txt_nome;
        private Label lbl_nomeFuncionario;
        private TextBox txt_obs;
        private Label label1;
        private ComboBox cbo_status;
        private Label lbl_status;
        private GroupBox grupo3_botoes;
        private Button bto_cadastrar;
        private Button bto_limpar;
        private Button bto_sair;
        private Button bto_alterar;
        private NumericUpDown numeric_ID;
    }
}