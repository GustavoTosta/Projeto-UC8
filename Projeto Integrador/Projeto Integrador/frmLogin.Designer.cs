namespace frmProjeto_Integrador
{
    partial class frm_Login
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bto_ok = new System.Windows.Forms.Button();
            this.bto_sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(15, 33);
            this.txt_usuario.MaxLength = 100;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(451, 23);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(15, 85);
            this.txt_senha.MaxLength = 50;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(451, 23);
            this.txt_senha.TabIndex = 3;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // bto_ok
            // 
            this.bto_ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bto_ok.Location = new System.Drawing.Point(268, 183);
            this.bto_ok.Name = "bto_ok";
            this.bto_ok.Size = new System.Drawing.Size(93, 39);
            this.bto_ok.TabIndex = 4;
            this.bto_ok.Text = "OK";
            this.bto_ok.UseVisualStyleBackColor = true;
            this.bto_ok.Click += new System.EventHandler(this.bto_ok_Click);
            // 
            // bto_sair
            // 
            this.bto_sair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bto_sair.Location = new System.Drawing.Point(373, 183);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(93, 39);
            this.bto_sair.TabIndex = 5;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;
            this.bto_sair.Click += new System.EventHandler(this.bto_sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.bto_sair);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bto_ok);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bto_sair;
            this.ClientSize = new System.Drawing.Size(508, 263);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label label1;
        private Label label2;
        private Button bto_ok;
        private Button bto_sair;
        private GroupBox groupBox1;
    }
}