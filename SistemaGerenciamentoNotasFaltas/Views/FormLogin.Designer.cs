namespace SistemaGerenciamentoNotasFaltas
{
    partial class FormLogin
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
            pcImagem = new PictureBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            pcUsuario = new PictureBox();
            pcSenha = new PictureBox();
            lklEsqueciSenha = new LinkLabel();
            btnEntrar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcSenha).BeginInit();
            SuspendLayout();
            // 
            // pcImagem
            // 
            pcImagem.Location = new Point(143, 20);
            pcImagem.Name = "pcImagem";
            pcImagem.Size = new Size(140, 140);
            pcImagem.TabIndex = 0;
            pcImagem.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(80, 235);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(139, 228);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 29);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(139, 263);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(250, 29);
            txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(80, 270);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // pcUsuario
            // 
            pcUsuario.Location = new Point(45, 228);
            pcUsuario.Name = "pcUsuario";
            pcUsuario.Size = new Size(29, 29);
            pcUsuario.TabIndex = 5;
            pcUsuario.TabStop = false;
            // 
            // pcSenha
            // 
            pcSenha.Location = new Point(45, 263);
            pcSenha.Name = "pcSenha";
            pcSenha.Size = new Size(29, 29);
            pcSenha.TabIndex = 6;
            pcSenha.TabStop = false;
            // 
            // lklEsqueciSenha
            // 
            lklEsqueciSenha.AutoSize = true;
            lklEsqueciSenha.Location = new Point(271, 295);
            lklEsqueciSenha.Name = "lklEsqueciSenha";
            lklEsqueciSenha.Size = new Size(118, 15);
            lklEsqueciSenha.TabIndex = 7;
            lklEsqueciSenha.TabStop = true;
            lklEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.RoyalBlue;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(45, 326);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(238, 45);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(289, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(lklEsqueciSenha);
            Controls.Add(pcSenha);
            Controls.Add(pcUsuario);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(pcImagem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - EduSmart";
            ((System.ComponentModel.ISupportInitialize)pcImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcImagem;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private PictureBox pcUsuario;
        private PictureBox pcSenha;
        private LinkLabel lklEsqueciSenha;
        private Button btnEntrar;
        private Button btnCancelar;
    }
}
