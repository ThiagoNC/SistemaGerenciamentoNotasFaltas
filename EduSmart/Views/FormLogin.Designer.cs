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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbImagem = new PictureBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lklEsqueciSenha = new LinkLabel();
            btnEntrar = new Button();
            btnCancelar = new Button();
            pbOlho = new PictureBox();
            pbSenha = new PictureBox();
            pbUsuario = new PictureBox();
            pnEduSmart = new Panel();
            lblVersao = new Label();
            pnCor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOlho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            pnEduSmart.SuspendLayout();
            SuspendLayout();
            // 
            // pbImagem
            // 
            pbImagem.BackColor = Color.Transparent;
            pbImagem.Image = Properties.Resources.Logo;
            pbImagem.Location = new Point(0, 1);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(434, 256);
            pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagem.TabIndex = 0;
            pbImagem.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(82, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(139, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(139, 258);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(250, 29);
            txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = Color.DimGray;
            lblSenha.Location = new Point(82, 266);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // lklEsqueciSenha
            // 
            lklEsqueciSenha.AutoSize = true;
            lklEsqueciSenha.Location = new Point(271, 295);
            lklEsqueciSenha.Name = "lklEsqueciSenha";
            lklEsqueciSenha.Size = new Size(118, 15);
            lklEsqueciSenha.TabIndex = 6;
            lklEsqueciSenha.TabStop = true;
            lklEsqueciSenha.Text = "Esqueci minha senha";
            lklEsqueciSenha.LinkClicked += lklEsqueciSenha_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.LightSeaGreen;
            btnEntrar.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(45, 324);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(238, 45);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.FlatAppearance.BorderColor = Color.LightGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(289, 324);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pbOlho
            // 
            pbOlho.BackColor = Color.Transparent;
            pbOlho.BorderStyle = BorderStyle.FixedSingle;
            pbOlho.Image = Properties.Resources.olho;
            pbOlho.Location = new Point(360, 259);
            pbOlho.Name = "pbOlho";
            pbOlho.Size = new Size(28, 28);
            pbOlho.SizeMode = PictureBoxSizeMode.Zoom;
            pbOlho.TabIndex = 10;
            pbOlho.TabStop = false;
            pbOlho.Click += pcOlho_Click;
            // 
            // pbSenha
            // 
            pbSenha.Image = Properties.Resources.senha;
            pbSenha.Location = new Point(45, 258);
            pbSenha.Name = "pbSenha";
            pbSenha.Size = new Size(29, 29);
            pbSenha.SizeMode = PictureBoxSizeMode.Zoom;
            pbSenha.TabIndex = 6;
            pbSenha.TabStop = false;
            // 
            // pbUsuario
            // 
            pbUsuario.Image = Properties.Resources.usuario;
            pbUsuario.Location = new Point(45, 223);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(29, 29);
            pbUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pbUsuario.TabIndex = 5;
            pbUsuario.TabStop = false;
            // 
            // pnEduSmart
            // 
            pnEduSmart.BackColor = Color.White;
            pnEduSmart.Controls.Add(lblVersao);
            pnEduSmart.Dock = DockStyle.Bottom;
            pnEduSmart.Location = new Point(0, 386);
            pnEduSmart.Name = "pnEduSmart";
            pnEduSmart.Size = new Size(434, 25);
            pnEduSmart.TabIndex = 11;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.ForeColor = Color.DimGray;
            lblVersao.Location = new Point(176, 5);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(82, 15);
            lblVersao.TabIndex = 12;
            lblVersao.Text = "EduSmart v1.0";
            // 
            // pnCor
            // 
            pnCor.Location = new Point(0, 0);
            pnCor.Name = "pnCor";
            pnCor.Size = new Size(434, 76);
            pnCor.TabIndex = 12;
            // 
            // FormLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            CancelButton = btnCancelar;
            ClientSize = new Size(434, 411);
            Controls.Add(pnCor);
            Controls.Add(pnEduSmart);
            Controls.Add(pbOlho);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(lklEsqueciSenha);
            Controls.Add(pbSenha);
            Controls.Add(pbUsuario);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(pbImagem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - EduSmart";
            FormClosing += FormLogin_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOlho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            pnEduSmart.ResumeLayout(false);
            pnEduSmart.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagem;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblSenha;
        private LinkLabel lklEsqueciSenha;
        private Button btnEntrar;
        private Button btnCancelar;
        private PictureBox pbOlho;
        private PictureBox pbSenha;
        private PictureBox pbUsuario;
        private Panel pnEduSmart;
        private Label lblVersao;
        private Panel pnCor;
    }
}
