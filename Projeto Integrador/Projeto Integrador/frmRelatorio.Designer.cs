namespace Projeto_Integrador
{
    partial class frmRelatorio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbl_produtosVendidos = new System.Windows.Forms.Label();
            this.lbl_mesesVendas = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_relatorio = new System.Windows.Forms.TextBox();
            this.bto_registrar = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.lbl_produtosVendidos);
            this.groupBox1.Controls.Add(this.lbl_mesesVendas);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(538, 38);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 5;
            // 
            // lbl_produtosVendidos
            // 
            this.lbl_produtosVendidos.AutoSize = true;
            this.lbl_produtosVendidos.Location = new System.Drawing.Point(538, 19);
            this.lbl_produtosVendidos.Name = "lbl_produtosVendidos";
            this.lbl_produtosVendidos.Size = new System.Drawing.Size(134, 15);
            this.lbl_produtosVendidos.TabIndex = 4;
            this.lbl_produtosVendidos.Text = "produtos mais vendidos";
            // 
            // lbl_mesesVendas
            // 
            this.lbl_mesesVendas.AutoSize = true;
            this.lbl_mesesVendas.Location = new System.Drawing.Point(267, 19);
            this.lbl_mesesVendas.Name = "lbl_mesesVendas";
            this.lbl_mesesVendas.Size = new System.Drawing.Size(96, 15);
            this.lbl_mesesVendas.TabIndex = 3;
            this.lbl_mesesVendas.Text = "meses de vendas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(267, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "rank de vendas";
            // 
            // txt_relatorio
            // 
            this.txt_relatorio.Location = new System.Drawing.Point(41, 234);
            this.txt_relatorio.Multiline = true;
            this.txt_relatorio.Name = "txt_relatorio";
            this.txt_relatorio.PlaceholderText = "Envie aqui seu relatório";
            this.txt_relatorio.Size = new System.Drawing.Size(726, 161);
            this.txt_relatorio.TabIndex = 2;
            // 
            // bto_registrar
            // 
            this.bto_registrar.Location = new System.Drawing.Point(649, 401);
            this.bto_registrar.Name = "bto_registrar";
            this.bto_registrar.Size = new System.Drawing.Size(118, 37);
            this.bto_registrar.TabIndex = 3;
            this.bto_registrar.Text = "Registrar relatório";
            this.bto_registrar.UseVisualStyleBackColor = true;
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(41, 401);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(79, 37);
            this.bto_sair.TabIndex = 6;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bto_sair);
            this.Controls.Add(this.bto_registrar);
            this.Controls.Add(this.txt_relatorio);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRelatorio";
            this.Text = "Relatorio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorio_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridView dataGridView3;
        private Label lbl_produtosVendidos;
        private Label lbl_mesesVendas;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox txt_relatorio;
        private Button bto_registrar;
        private Button bto_sair;
    }
}