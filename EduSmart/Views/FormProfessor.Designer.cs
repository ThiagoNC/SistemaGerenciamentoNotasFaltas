namespace EduSmart.Views
{
    partial class FormProfessor
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessor));
            pnProfessor = new Panel();
            pbProfessor = new PictureBox();
            lblGestaoProfessor = new Label();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            dgvProfessores = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            senhaHash = new DataGridViewTextBoxColumn();
            gbProfessor = new GroupBox();
            pbOlho = new PictureBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            txtSenha = new TextBox();
            lblSenhaHash = new Label();
            pnProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfessor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).BeginInit();
            gbProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOlho).BeginInit();
            SuspendLayout();
            // 
            // pnProfessor
            // 
            pnProfessor.BackColor = Color.LightSeaGreen;
            pnProfessor.Controls.Add(pbProfessor);
            pnProfessor.Controls.Add(lblGestaoProfessor);
            pnProfessor.Dock = DockStyle.Top;
            pnProfessor.Location = new Point(0, 0);
            pnProfessor.Name = "pnProfessor";
            pnProfessor.Size = new Size(1008, 150);
            pnProfessor.TabIndex = 0;
            // 
            // pbProfessor
            // 
            pbProfessor.Image = Properties.Resources.Icon1;
            pbProfessor.Location = new Point(170, 27);
            pbProfessor.Name = "pbProfessor";
            pbProfessor.Size = new Size(100, 100);
            pbProfessor.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfessor.TabIndex = 1;
            pbProfessor.TabStop = false;
            // 
            // lblGestaoProfessor
            // 
            lblGestaoProfessor.AutoSize = true;
            lblGestaoProfessor.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoProfessor.ForeColor = Color.White;
            lblGestaoProfessor.Location = new Point(276, 45);
            lblGestaoProfessor.Name = "lblGestaoProfessor";
            lblGestaoProfessor.Size = new Size(618, 65);
            lblGestaoProfessor.TabIndex = 1;
            lblGestaoProfessor.Text = "GESTÃO DE PROFESSORES";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Image = Properties.Resources.refresh1;
            btnAtualizar.Location = new Point(973, 180);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(23, 23);
            btnAtualizar.TabIndex = 21;
            btnAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.Control;
            txtPesquisar.Location = new Point(817, 180);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar professores...";
            txtPesquisar.Size = new Size(150, 23);
            txtPesquisar.TabIndex = 20;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvProfessores
            // 
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dgvProfessores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProfessores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProfessores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProfessores.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProfessores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfessores.Columns.AddRange(new DataGridViewColumn[] { id, nome, email, senhaHash });
            dgvProfessores.Location = new Point(378, 209);
            dgvProfessores.MultiSelect = false;
            dgvProfessores.Name = "dgvProfessores";
            dgvProfessores.ReadOnly = true;
            dgvProfessores.Size = new Size(618, 296);
            dgvProfessores.TabIndex = 25;
            dgvProfessores.CellClick += dgvProfessors_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "E-mail";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // senhaHash
            // 
            senhaHash.DataPropertyName = "senhaHash";
            senhaHash.HeaderText = "Senha";
            senhaHash.Name = "senhaHash";
            senhaHash.ReadOnly = true;
            senhaHash.Visible = false;
            // 
            // gbProfessor
            // 
            gbProfessor.Controls.Add(pbOlho);
            gbProfessor.Controls.Add(btnExcluir);
            gbProfessor.Controls.Add(btnSalvar);
            gbProfessor.Controls.Add(btnNovo);
            gbProfessor.Controls.Add(lblEmail);
            gbProfessor.Controls.Add(txtEmail);
            gbProfessor.Controls.Add(txtNome);
            gbProfessor.Controls.Add(lblNome);
            gbProfessor.Controls.Add(txtSenha);
            gbProfessor.Controls.Add(lblSenhaHash);
            gbProfessor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProfessor.Location = new Point(10, 180);
            gbProfessor.Name = "gbProfessor";
            gbProfessor.Size = new Size(362, 325);
            gbProfessor.TabIndex = 2;
            gbProfessor.TabStop = false;
            gbProfessor.Text = "Informações do Professor";
            // 
            // pbOlho
            // 
            pbOlho.BorderStyle = BorderStyle.FixedSingle;
            pbOlho.Image = Properties.Resources.olho;
            pbOlho.Location = new Point(328, 99);
            pbOlho.Name = "pbOlho";
            pbOlho.Size = new Size(28, 29);
            pbOlho.SizeMode = PictureBoxSizeMode.Zoom;
            pbOlho.TabIndex = 11;
            pbOlho.TabStop = false;
            pbOlho.Click += pcOlho_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(242, 227);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 35);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LightSeaGreen;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(126, 227);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 35);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Green;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(10, 227);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 35);
            btnNovo.TabIndex = 16;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(6, 67);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(164, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 29);
            txtEmail.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(164, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(192, 29);
            txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(6, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(164, 99);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(192, 29);
            txtSenha.TabIndex = 15;
            // 
            // lblSenhaHash
            // 
            lblSenhaHash.AutoSize = true;
            lblSenhaHash.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenhaHash.Location = new Point(6, 102);
            lblSenhaHash.Name = "lblSenhaHash";
            lblSenhaHash.Size = new Size(56, 21);
            lblSenhaHash.TabIndex = 11;
            lblSenhaHash.Text = "Senha:";
            // 
            // FormProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(pnProfessor);
            Controls.Add(btnAtualizar);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvProfessores);
            Controls.Add(gbProfessor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Professores - EduSmart";
            FormClosing += FormProfessor_FormClosing;
            Load += FormProfessor_Load;
            KeyDown += FormProfessor_KeyDown;
            pnProfessor.ResumeLayout(false);
            pnProfessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfessor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).EndInit();
            gbProfessor.ResumeLayout(false);
            gbProfessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOlho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnProfessor;
        private PictureBox pbProfessor;
        private Label lblGestaoProfessor;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private DataGridView dgvProfessores;
        private GroupBox gbProfessor;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtSenha;
        private Label lblSenhaHash;
        private PictureBox pbOlho;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn senhaHash;
    }
}