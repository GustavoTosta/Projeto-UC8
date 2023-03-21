namespace Projeto_Integrador
{
    partial class MDITelaIncial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDITelaIncial));
            this.pic_funcionario = new System.Windows.Forms.PictureBox();
            this.pic2_estatisticas = new System.Windows.Forms.PictureBox();
            this.pic3_venda = new System.Windows.Forms.PictureBox();
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.lbl_Estatisticas = new System.Windows.Forms.Label();
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.grupo_1 = new System.Windows.Forms.GroupBox();
            this.pic_3 = new System.Windows.Forms.PictureBox();
            this.lbl_Fornecedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_estatisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_venda)).BeginInit();
            this.grupo_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_funcionario
            // 
            this.pic_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_funcionario.Image = global::Projeto_Integrador.Properties.Resources._554744;
            this.pic_funcionario.Location = new System.Drawing.Point(42, 149);
            this.pic_funcionario.Name = "pic_funcionario";
            this.pic_funcionario.Size = new System.Drawing.Size(140, 127);
            this.pic_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_funcionario.TabIndex = 4;
            this.pic_funcionario.TabStop = false;
            this.pic_funcionario.Click += new System.EventHandler(this.pic_1_Click);
            // 
            // pic2_estatisticas
            // 
            this.pic2_estatisticas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2_estatisticas.Image = ((System.Drawing.Image)(resources.GetObject("pic2_estatisticas.Image")));
            this.pic2_estatisticas.Location = new System.Drawing.Point(214, 149);
            this.pic2_estatisticas.Name = "pic2_estatisticas";
            this.pic2_estatisticas.Size = new System.Drawing.Size(140, 127);
            this.pic2_estatisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2_estatisticas.TabIndex = 8;
            this.pic2_estatisticas.TabStop = false;
            this.pic2_estatisticas.Click += new System.EventHandler(this.pic2_estatisticas_Click);
            // 
            // pic3_venda
            // 
            this.pic3_venda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic3_venda.Image = ((System.Drawing.Image)(resources.GetObject("pic3_venda.Image")));
            this.pic3_venda.Location = new System.Drawing.Point(385, 149);
            this.pic3_venda.Name = "pic3_venda";
            this.pic3_venda.Size = new System.Drawing.Size(140, 127);
            this.pic3_venda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3_venda.TabIndex = 9;
            this.pic3_venda.TabStop = false;
            this.pic3_venda.Click += new System.EventHandler(this.pic3_venda_Click);
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.Location = new System.Drawing.Point(53, 279);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(110, 15);
            this.lbl_funcionario.TabIndex = 11;
            this.lbl_funcionario.Text = "Tela do Funcionário";
            this.lbl_funcionario.Click += new System.EventHandler(this.lbl_funcionario_Click);
            // 
            // lbl_Estatisticas
            // 
            this.lbl_Estatisticas.AutoSize = true;
            this.lbl_Estatisticas.Location = new System.Drawing.Point(225, 279);
            this.lbl_Estatisticas.Name = "lbl_Estatisticas";
            this.lbl_Estatisticas.Size = new System.Drawing.Size(116, 15);
            this.lbl_Estatisticas.TabIndex = 12;
            this.lbl_Estatisticas.Text = "Estatísticas/Relatório";
            this.lbl_Estatisticas.Click += new System.EventHandler(this.lbl_Estatisticas_Click);
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Location = new System.Drawing.Point(387, 279);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(138, 15);
            this.lbl_produtos.TabIndex = 13;
            this.lbl_produtos.Text = "Gerenciador de produtos";
            this.lbl_produtos.Click += new System.EventHandler(this.lbl_produtos_Click);
            // 
            // grupo_1
            // 
            this.grupo_1.Controls.Add(this.pic_3);
            this.grupo_1.Controls.Add(this.lbl_Fornecedores);
            this.grupo_1.Controls.Add(this.pic3_venda);
            this.grupo_1.Controls.Add(this.lbl_produtos);
            this.grupo_1.Controls.Add(this.pic_funcionario);
            this.grupo_1.Controls.Add(this.lbl_Estatisticas);
            this.grupo_1.Controls.Add(this.pic2_estatisticas);
            this.grupo_1.Controls.Add(this.lbl_funcionario);
            this.grupo_1.Location = new System.Drawing.Point(-16, -10);
            this.grupo_1.Name = "grupo_1";
            this.grupo_1.Size = new System.Drawing.Size(733, 435);
            this.grupo_1.TabIndex = 15;
            this.grupo_1.TabStop = false;
            this.grupo_1.Enter += new System.EventHandler(this.grupo_1_Enter);
            // 
            // pic_3
            // 
            this.pic_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_3.Image = ((System.Drawing.Image)(resources.GetObject("pic_3.Image")));
            this.pic_3.Location = new System.Drawing.Point(562, 149);
            this.pic_3.Name = "pic_3";
            this.pic_3.Size = new System.Drawing.Size(140, 127);
            this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_3.TabIndex = 14;
            this.pic_3.TabStop = false;
            this.pic_3.Click += new System.EventHandler(this.pic_3_Click);
            // 
            // lbl_Fornecedores
            // 
            this.lbl_Fornecedores.AutoSize = true;
            this.lbl_Fornecedores.Location = new System.Drawing.Point(572, 279);
            this.lbl_Fornecedores.Name = "lbl_Fornecedores";
            this.lbl_Fornecedores.Size = new System.Drawing.Size(119, 15);
            this.lbl_Fornecedores.TabIndex = 15;
            this.lbl_Fornecedores.Text = "Lista de fornecedores";
            // 
            // MDITelaIncial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.Controls.Add(this.grupo_1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDITelaIncial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de escolha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDITelaIncial_FormClosed);
            this.Load += new System.EventHandler(this.MDITelaIncial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_estatisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_venda)).EndInit();
            this.grupo_1.ResumeLayout(false);
            this.grupo_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private PictureBox pic_funcionario;
        private PictureBox pic2_estatisticas;
        private PictureBox pic3_venda;
        private Label lbl_funcionario;
        private Label lbl_Estatisticas;
        private Label lbl_produtos;
        private GroupBox grupo_1;
        private PictureBox pic_3;
        private Label lbl_Fornecedores;
    }
}



