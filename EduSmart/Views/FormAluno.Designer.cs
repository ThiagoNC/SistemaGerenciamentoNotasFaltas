namespace EduSmart.Views
{
    partial class FormAluno
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            pnAluno = new Panel();
            pbAluno = new PictureBox();
            lblGestaoAluno = new Label();
            gbAluno = new GroupBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            txtRa = new TextBox();
            lblRA = new Label();
            dgvAlunos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            ra = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            txtPesquisar = new TextBox();
            btnAtualizar = new Button();
            pnAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAluno).BeginInit();
            gbAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // pnAluno
            // 
            pnAluno.BackColor = Color.LightSeaGreen;
            pnAluno.Controls.Add(pbAluno);
            pnAluno.Controls.Add(lblGestaoAluno);
            pnAluno.Dock = DockStyle.Top;
            pnAluno.Location = new Point(0, 0);
            pnAluno.Name = "pnAluno";
            pnAluno.Size = new Size(1008, 150);
            pnAluno.TabIndex = 0;
            // 
            // pbAluno
            // 
            pbAluno.Image = Properties.Resources.Icon1;
            pbAluno.Location = new Point(170, 27);
            pbAluno.Name = "pbAluno";
            pbAluno.Size = new Size(100, 100);
            pbAluno.SizeMode = PictureBoxSizeMode.Zoom;
            pbAluno.TabIndex = 1;
            pbAluno.TabStop = false;
            // 
            // lblGestaoAluno
            // 
            lblGestaoAluno.AutoSize = true;
            lblGestaoAluno.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoAluno.ForeColor = Color.White;
            lblGestaoAluno.Location = new Point(276, 45);
            lblGestaoAluno.Name = "lblGestaoAluno";
            lblGestaoAluno.Size = new Size(491, 65);
            lblGestaoAluno.TabIndex = 0;
            lblGestaoAluno.Text = "GESTÃO DE ALUNOS";
            // 
            // gbAluno
            // 
            gbAluno.Controls.Add(btnExcluir);
            gbAluno.Controls.Add(btnSalvar);
            gbAluno.Controls.Add(btnNovo);
            gbAluno.Controls.Add(lblEmail);
            gbAluno.Controls.Add(txtEmail);
            gbAluno.Controls.Add(txtNome);
            gbAluno.Controls.Add(lblNome);
            gbAluno.Controls.Add(txtRa);
            gbAluno.Controls.Add(lblRA);
            gbAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbAluno.Location = new Point(10, 180);
            gbAluno.Name = "gbAluno";
            gbAluno.Size = new Size(362, 325);
            gbAluno.TabIndex = 5;
            gbAluno.TabStop = false;
            gbAluno.Text = "Informações do Aluno";
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
            btnExcluir.TabIndex = 8;
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
            btnSalvar.TabIndex = 7;
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
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(6, 102);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(164, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 29);
            txtEmail.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(164, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(192, 29);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(6, 67);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // txtRa
            // 
            txtRa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRa.Location = new Point(164, 29);
            txtRa.Name = "txtRa";
            txtRa.Size = new Size(192, 29);
            txtRa.TabIndex = 1;
            // 
            // lblRA
            // 
            lblRA.AutoSize = true;
            lblRA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRA.Location = new Point(6, 32);
            lblRA.Name = "lblRA";
            lblRA.Size = new Size(33, 21);
            lblRA.TabIndex = 0;
            lblRA.Text = "RA:";
            // 
            // dgvAlunos
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlunos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Columns.AddRange(new DataGridViewColumn[] { id, ra, nome, email });
            dgvAlunos.Location = new Point(378, 209);
            dgvAlunos.MultiSelect = false;
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.ReadOnly = true;
            dgvAlunos.Size = new Size(618, 296);
            dgvAlunos.TabIndex = 6;
            dgvAlunos.CellClick += dgvAlunos_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // ra
            // 
            ra.DataPropertyName = "ra";
            ra.HeaderText = "RA";
            ra.Name = "ra";
            ra.ReadOnly = true;
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
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.Control;
            txtPesquisar.Location = new Point(817, 180);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar aluno...";
            txtPesquisar.Size = new Size(150, 23);
            txtPesquisar.TabIndex = 7;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Image = Properties.Resources.refresh1;
            btnAtualizar.Location = new Point(973, 180);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(23, 23);
            btnAtualizar.TabIndex = 70;
            btnAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(btnAtualizar);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvAlunos);
            Controls.Add(gbAluno);
            Controls.Add(pnAluno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alunos - EduSmart";
            FormClosing += FormAluno_FormClosing;
            Load += FormAluno_Load;
            KeyDown += FormAluno_KeyDown;
            pnAluno.ResumeLayout(false);
            pnAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAluno).EndInit();
            gbAluno.ResumeLayout(false);
            gbAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnAluno;
        private Label lblGestaoAluno;
        private PictureBox pbAluno;
        private GroupBox gbAluno;
        private DataGridView dgvAlunos;
        private TextBox txtPesquisar;
        private Button btnAtualizar;
        private TextBox txtRa;
        private Label lblRA;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnSalvar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ra;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn email;
    }
}