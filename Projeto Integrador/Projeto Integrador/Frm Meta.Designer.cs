namespace frmProjeto_Integrador
{
    partial class Frm_Meta
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txt_dataFim = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.bto_pesquisa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bto_alterar = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.bto_excluir = new System.Windows.Forms.Button();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.bto_limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(12, 27);
            this.txt_codigo.MaxLength = 5;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(182, 23);
            this.txt_codigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 71);
            this.txt_nome.MaxLength = 100;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(310, 23);
            this.txt_nome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Fim";
            // 
            // txt_dataInicio
            // 
            this.txt_dataInicio.Location = new System.Drawing.Point(332, 27);
            this.txt_dataInicio.Mask = "___/___/____";
            this.txt_dataInicio.Name = "txt_dataInicio";
            this.txt_dataInicio.Size = new System.Drawing.Size(107, 23);
            this.txt_dataInicio.TabIndex = 2;
            // 
            // txt_dataFim
            // 
            this.txt_dataFim.Location = new System.Drawing.Point(445, 27);
            this.txt_dataFim.Mask = "___/___/____";
            this.txt_dataFim.Name = "txt_dataFim";
            this.txt_dataFim.Size = new System.Drawing.Size(107, 23);
            this.txt_dataFim.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(12, 130);
            this.txt_descricao.MaxLength = 255;
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(540, 56);
            this.txt_descricao.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_obs);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(6, 14);
            this.txt_obs.MaxLength = 255;
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(528, 35);
            this.txt_obs.TabIndex = 0;
            this.txt_obs.TextChanged += new System.EventHandler(this.txt_obs_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Obs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbo_status.Location = new System.Drawing.Point(332, 71);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(107, 23);
            this.cbo_status.TabIndex = 5;
            // 
            // bto_pesquisa
            // 
            this.bto_pesquisa.Location = new System.Drawing.Point(200, 27);
            this.bto_pesquisa.Name = "bto_pesquisa";
            this.bto_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.bto_pesquisa.TabIndex = 1;
            this.bto_pesquisa.Text = "...";
            this.bto_pesquisa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pesquisa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bto_alterar);
            this.groupBox2.Controls.Add(this.bto_sair);
            this.groupBox2.Controls.Add(this.bto_excluir);
            this.groupBox2.Controls.Add(this.bto_cadastrar);
            this.groupBox2.Controls.Add(this.bto_limpar);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 77);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // bto_alterar
            // 
            this.bto_alterar.Location = new System.Drawing.Point(132, 22);
            this.bto_alterar.Name = "bto_alterar";
            this.bto_alterar.Size = new System.Drawing.Size(86, 39);
            this.bto_alterar.TabIndex = 0;
            this.bto_alterar.Text = "Alterar";
            this.bto_alterar.UseVisualStyleBackColor = true;
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(409, 23);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(86, 38);
            this.bto_sair.TabIndex = 0;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            // 
            // bto_excluir
            // 
            this.bto_excluir.Location = new System.Drawing.Point(316, 23);
            this.bto_excluir.Name = "bto_excluir";
            this.bto_excluir.Size = new System.Drawing.Size(87, 38);
            this.bto_excluir.TabIndex = 0;
            this.bto_excluir.Text = "Excluir";
            this.bto_excluir.UseVisualStyleBackColor = true;
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.Location = new System.Drawing.Point(40, 22);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(86, 39);
            this.bto_cadastrar.TabIndex = 0;
            this.bto_cadastrar.Text = "Cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = true;
            // 
            // bto_limpar
            // 
            this.bto_limpar.Location = new System.Drawing.Point(224, 23);
            this.bto_limpar.Name = "bto_limpar";
            this.bto_limpar.Size = new System.Drawing.Size(86, 38);
            this.bto_limpar.TabIndex = 0;
            this.bto_limpar.Text = "Limpar";
            this.bto_limpar.UseVisualStyleBackColor = true;
            // 
            // Frm_Meta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bto_pesquisa);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dataFim);
            this.Controls.Add(this.txt_dataInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codigo);
            this.Name = "Frm_Meta";
            this.Text = "Meta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_codigo;
        private Label label1;
        private Label label2;
        private TextBox txt_nome;
        private Label label3;
        private Label label4;
        private MaskedTextBox txt_dataInicio;
        private MaskedTextBox txt_dataFim;
        private Label label5;
        private TextBox txt_descricao;
        private GroupBox groupBox1;
        private TextBox txt_obs;
        private Label label6;
        private Label label7;
        private ComboBox cbo_status;
        private Button bto_pesquisa;
        private Label label8;
        private GroupBox groupBox2;
        private Button bto_alterar;
        private Button bto_sair;
        private Button bto_excluir;
        private Button bto_cadastrar;
        private Button bto_limpar;
    }
}