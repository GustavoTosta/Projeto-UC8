namespace Projeto_Integrador
{
    partial class frmVenda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bto_adicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_valorProduto = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nomeProduto = new System.Windows.Forms.Label();
            this.bto_limparCarrinho = new System.Windows.Forms.Button();
            this.bto_finalizarCompra = new System.Windows.Forms.Button();
            this.txt_pesquisaProduto = new System.Windows.Forms.TextBox();
            this.lbl_escolhaProduto = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.grupo_3 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbo_quantidadeDisponivel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grupo_3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(407, 148);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_quantidadeDisponivel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.cbo_categoria);
            this.groupBox1.Controls.Add(this.bto_adicionar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbo_status);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_quantidade);
            this.groupBox1.Controls.Add(this.lbl_valorProduto);
            this.groupBox1.Controls.Add(this.lbl_categoria);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_nomeProduto);
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do produto";
            // 
            // bto_adicionar
            // 
            this.bto_adicionar.Location = new System.Drawing.Point(242, 155);
            this.bto_adicionar.Name = "bto_adicionar";
            this.bto_adicionar.Size = new System.Drawing.Size(97, 51);
            this.bto_adicionar.TabIndex = 12;
            this.bto_adicionar.Text = "Adicionar ao carrinho";
            this.bto_adicionar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade Disponivel";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Location = new System.Drawing.Point(15, 139);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(85, 23);
            this.cbo_status.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(121, 68);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(69, 15);
            this.lbl_quantidade.TabIndex = 6;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_valorProduto
            // 
            this.lbl_valorProduto.AutoSize = true;
            this.lbl_valorProduto.Location = new System.Drawing.Point(15, 69);
            this.lbl_valorProduto.Name = "lbl_valorProduto";
            this.lbl_valorProduto.Size = new System.Drawing.Size(96, 15);
            this.lbl_valorProduto.TabIndex = 4;
            this.lbl_valorProduto.Text = "Valor do produto";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(171, 19);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_categoria.TabIndex = 3;
            this.lbl_categoria.Text = "Categoria";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(15, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(134, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nomeProduto
            // 
            this.lbl_nomeProduto.AutoSize = true;
            this.lbl_nomeProduto.Location = new System.Drawing.Point(14, 19);
            this.lbl_nomeProduto.Name = "lbl_nomeProduto";
            this.lbl_nomeProduto.Size = new System.Drawing.Size(86, 15);
            this.lbl_nomeProduto.TabIndex = 0;
            this.lbl_nomeProduto.Text = "Nome Produto";
            // 
            // bto_limparCarrinho
            // 
            this.bto_limparCarrinho.Location = new System.Drawing.Point(6, 181);
            this.bto_limparCarrinho.Name = "bto_limparCarrinho";
            this.bto_limparCarrinho.Size = new System.Drawing.Size(129, 23);
            this.bto_limparCarrinho.TabIndex = 12;
            this.bto_limparCarrinho.Text = "Limpar Carrinho";
            this.bto_limparCarrinho.UseVisualStyleBackColor = true;
            // 
            // bto_finalizarCompra
            // 
            this.bto_finalizarCompra.Location = new System.Drawing.Point(295, 181);
            this.bto_finalizarCompra.Name = "bto_finalizarCompra";
            this.bto_finalizarCompra.Size = new System.Drawing.Size(118, 23);
            this.bto_finalizarCompra.TabIndex = 11;
            this.bto_finalizarCompra.Text = "Finalizar compra";
            this.bto_finalizarCompra.UseVisualStyleBackColor = true;
            // 
            // txt_pesquisaProduto
            // 
            this.txt_pesquisaProduto.Location = new System.Drawing.Point(6, 32);
            this.txt_pesquisaProduto.Name = "txt_pesquisaProduto";
            this.txt_pesquisaProduto.PlaceholderText = "Pesquise o produto pelo nome";
            this.txt_pesquisaProduto.Size = new System.Drawing.Size(303, 23);
            this.txt_pesquisaProduto.TabIndex = 5;
            // 
            // lbl_escolhaProduto
            // 
            this.lbl_escolhaProduto.AutoSize = true;
            this.lbl_escolhaProduto.Location = new System.Drawing.Point(6, 14);
            this.lbl_escolhaProduto.Name = "lbl_escolhaProduto";
            this.lbl_escolhaProduto.Size = new System.Drawing.Size(86, 15);
            this.lbl_escolhaProduto.TabIndex = 6;
            this.lbl_escolhaProduto.Text = "Nome Produto";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(315, 33);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(98, 23);
            this.comboBox5.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Categoria produto";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grupo_3
            // 
            this.grupo_3.Controls.Add(this.dataGridView1);
            this.grupo_3.Controls.Add(this.txt_pesquisaProduto);
            this.grupo_3.Controls.Add(this.label16);
            this.grupo_3.Controls.Add(this.lbl_escolhaProduto);
            this.grupo_3.Controls.Add(this.comboBox5);
            this.grupo_3.Location = new System.Drawing.Point(360, 24);
            this.grupo_3.Name = "grupo_3";
            this.grupo_3.Size = new System.Drawing.Size(428, 212);
            this.grupo_3.TabIndex = 14;
            this.grupo_3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bto_limparCarrinho);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.bto_finalizarCompra);
            this.groupBox3.Location = new System.Drawing.Point(360, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 210);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carrinho";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(407, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(171, 37);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(121, 23);
            this.cbo_categoria.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 87);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // cbo_quantidadeDisponivel
            // 
            this.cbo_quantidadeDisponivel.FormattingEnabled = true;
            this.cbo_quantidadeDisponivel.Location = new System.Drawing.Point(204, 87);
            this.cbo_quantidadeDisponivel.Name = "cbo_quantidadeDisponivel";
            this.cbo_quantidadeDisponivel.Size = new System.Drawing.Size(84, 23);
            this.cbo_quantidadeDisponivel.TabIndex = 16;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grupo_3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVenda";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupo_3.ResumeLayout(false);
            this.grupo_3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button bto_adicionar;
        private Label label6;
        private ComboBox cbo_status;
        private Label label5;
        private Label lbl_quantidade;
        private Label lbl_valorProduto;
        private Label lbl_categoria;
        private TextBox txt_nome;
        private Label lbl_nomeProduto;
        private Button bto_limparCarrinho;
        private Button bto_finalizarCompra;
        private TextBox txt_pesquisaProduto;
        private Label lbl_escolhaProduto;
        private ComboBox comboBox5;
        private Label label16;
        private Button button4;
        private GroupBox grupo_3;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private ComboBox cbo_categoria;
        private NumericUpDown numericUpDown1;
        private ComboBox cbo_quantidadeDisponivel;
        private ComboBox comboBox1;
    }
}