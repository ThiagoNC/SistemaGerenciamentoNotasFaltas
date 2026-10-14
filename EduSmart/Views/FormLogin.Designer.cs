namespace EduSmart
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lklEsqueciSenha = new LinkLabel();
            btnEntrar = new Button();
            btnCancelar = new Button();
            pcOlho = new PictureBox();
            pcSenha = new PictureBox();
            pcUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcOlho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcUsuario).BeginInit();
            SuspendLayout();
            // 
            // pcImagem
            // 
            pcImagem.BackColor = Color.Transparent;
            pcImagem.Image = Properties.Resources.Logo;
            pcImagem.Location = new Point(0, 1);
            pcImagem.Name = "pcImagem";
            pcImagem.Size = new Size(434, 256);
            pcImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pcImagem.TabIndex = 0;
            pcImagem.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(80, 235);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(139, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(139, 263);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(250, 29);
            txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = Color.DimGray;
            lblSenha.Location = new Point(80, 270);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
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
            lklEsqueciSenha.LinkClicked += lklEsqueciSenha_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.LightSeaGreen;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(45, 326);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(238, 45);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(289, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pcOlho
            // 
            pcOlho.Image = Properties.Resources.olho;
            pcOlho.Location = new Point(360, 264);
            pcOlho.Name = "pcOlho";
            pcOlho.Size = new Size(28, 26);
            pcOlho.SizeMode = PictureBoxSizeMode.Zoom;
            pcOlho.TabIndex = 10;
            pcOlho.TabStop = false;
            pcOlho.Click += pcOlho_Click;
            // 
            // pcSenha
            // 
            pcSenha.Image = Properties.Resources.senha;
            pcSenha.Location = new Point(45, 263);
            pcSenha.Name = "pcSenha";
            pcSenha.Size = new Size(29, 29);
            pcSenha.SizeMode = PictureBoxSizeMode.Zoom;
            pcSenha.TabIndex = 6;
            pcSenha.TabStop = false;
            // 
            // pcUsuario
            // 
            pcUsuario.Image = Properties.Resources.usuario;
            pcUsuario.Location = new Point(45, 228);
            pcUsuario.Name = "pcUsuario";
            pcUsuario.Size = new Size(29, 29);
            pcUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pcUsuario.TabIndex = 5;
            pcUsuario.TabStop = false;
            // 
            // FormLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            CancelButton = btnCancelar;
            ClientSize = new Size(434, 411);
            Controls.Add(pcOlho);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(lklEsqueciSenha);
            Controls.Add(pcSenha);
            Controls.Add(pcUsuario);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(pcImagem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - EduSmart";
            FormClosing += FormLogin_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pcImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcOlho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcImagem;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblSenha;
        private LinkLabel lklEsqueciSenha;
        private Button btnEntrar;
        private Button btnCancelar;
        private PictureBox pcOlho;
        private PictureBox pcSenha;
        private PictureBox pcUsuario;
    }
}
