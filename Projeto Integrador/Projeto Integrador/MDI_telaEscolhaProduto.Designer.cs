namespace Projeto_Integrador
{
    partial class MDI_telaEscolhaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_telaEscolhaProduto));
            this.pic_estoque = new System.Windows.Forms.PictureBox();
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.pic_Categoria = new System.Windows.Forms.PictureBox();
            this.lbl_Venda = new System.Windows.Forms.Label();
            this.pic_estatisticas = new System.Windows.Forms.PictureBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.pic_produto = new System.Windows.Forms.PictureBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.bto_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estatisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_estoque
            // 
            this.pic_estoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_estoque.Image = ((System.Drawing.Image)(resources.GetObject("pic_estoque.Image")));
            this.pic_estoque.Location = new System.Drawing.Point(648, 140);
            this.pic_estoque.Name = "pic_estoque";
            this.pic_estoque.Size = new System.Drawing.Size(140, 127);
            this.pic_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_estoque.TabIndex = 16;
            this.pic_estoque.TabStop = false;
            this.pic_estoque.Click += new System.EventHandler(this.pic3_venda_Click);
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Location = new System.Drawing.Point(691, 270);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(49, 15);
            this.lbl_produtos.TabIndex = 19;
            this.lbl_produtos.Text = "Estoque";
            this.lbl_produtos.Click += new System.EventHandler(this.lbl_produtos_Click);
            // 
            // pic_Categoria
            // 
            this.pic_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Categoria.Image = ((System.Drawing.Image)(resources.GetObject("pic_Categoria.Image")));
            this.pic_Categoria.Location = new System.Drawing.Point(31, 140);
            this.pic_Categoria.Name = "pic_Categoria";
            this.pic_Categoria.Size = new System.Drawing.Size(140, 127);
            this.pic_Categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Categoria.TabIndex = 14;
            this.pic_Categoria.TabStop = false;
            this.pic_Categoria.Click += new System.EventHandler(this.pic_funcionario_Click);
            // 
            // lbl_Venda
            // 
            this.lbl_Venda.AutoSize = true;
            this.lbl_Venda.Location = new System.Drawing.Point(490, 270);
            this.lbl_Venda.Name = "lbl_Venda";
            this.lbl_Venda.Size = new System.Drawing.Size(39, 15);
            this.lbl_Venda.TabIndex = 18;
            this.lbl_Venda.Text = "Venda";
            this.lbl_Venda.Click += new System.EventHandler(this.lbl_Estatisticas_Click);
            // 
            // pic_estatisticas
            // 
            this.pic_estatisticas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_estatisticas.Image = ((System.Drawing.Image)(resources.GetObject("pic_estatisticas.Image")));
            this.pic_estatisticas.Location = new System.Drawing.Point(441, 140);
            this.pic_estatisticas.Name = "pic_estatisticas";
            this.pic_estatisticas.Size = new System.Drawing.Size(140, 127);
            this.pic_estatisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_estatisticas.TabIndex = 15;
            this.pic_estatisticas.TabStop = false;
            this.pic_estatisticas.Click += new System.EventHandler(this.pic2_estatisticas_Click);
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(54, 270);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(97, 15);
            this.lbl_categoria.TabIndex = 17;
            this.lbl_categoria.Text = "Tela da Categoria";
            this.lbl_categoria.Click += new System.EventHandler(this.lbl_funcionario_Click);
            // 
            // pic_produto
            // 
            this.pic_produto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_produto.Image = ((System.Drawing.Image)(resources.GetObject("pic_produto.Image")));
            this.pic_produto.Location = new System.Drawing.Point(233, 140);
            this.pic_produto.Name = "pic_produto";
            this.pic_produto.Size = new System.Drawing.Size(140, 127);
            this.pic_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_produto.TabIndex = 20;
            this.pic_produto.TabStop = false;
            this.pic_produto.Click += new System.EventHandler(this.pic_produto_Click);
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(275, 270);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(50, 15);
            this.lbl_produto.TabIndex = 21;
            this.lbl_produto.Text = "Produto";
            // 
            // bto_voltar
            // 
            this.bto_voltar.Location = new System.Drawing.Point(31, 403);
            this.bto_voltar.Name = "bto_voltar";
            this.bto_voltar.Size = new System.Drawing.Size(90, 35);
            this.bto_voltar.TabIndex = 23;
            this.bto_voltar.Text = "Voltar";
            this.bto_voltar.UseVisualStyleBackColor = true;
            this.bto_voltar.Click += new System.EventHandler(this.bto_voltar_Click);
            // 
            // MDI_telaEscolhaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bto_voltar);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.pic_produto);
            this.Controls.Add(this.pic_estoque);
            this.Controls.Add(this.lbl_produtos);
            this.Controls.Add(this.pic_Categoria);
            this.Controls.Add(this.lbl_Venda);
            this.Controls.Add(this.pic_estatisticas);
            this.Controls.Add(this.lbl_categoria);
            this.Name = "MDI_telaEscolhaProduto";
            this.Text = "Tela de Escolha de produto";
            this.Load += new System.EventHandler(this.frm_telaEscolhaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estatisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_estoque;
        private Label lbl_produtos;
        private PictureBox pic_Categoria;
        private Label lbl_Venda;
        private PictureBox pic_estatisticas;
        private Label lbl_categoria;
        private PictureBox pic_produto;
        private Label lbl_produto;
        private Button bto_voltar;
    }
}