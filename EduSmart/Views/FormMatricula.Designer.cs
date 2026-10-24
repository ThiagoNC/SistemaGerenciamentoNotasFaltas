namespace EduSmart.Views
{
    partial class FormMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatricula));
            pnMatricula = new Panel();
            pbMatricula = new PictureBox();
            lblGestaoMatricula = new Label();
            gbMatricula = new GroupBox();
            txtSemestre = new TextBox();
            cbProfessor = new ComboBox();
            cbDisciplina = new ComboBox();
            cbAluno = new ComboBox();
            lblSemestre = new Label();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            lblEmail = new Label();
            lblNome = new Label();
            lblAluno = new Label();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            dgvMatriculas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            NomeAluno = new DataGridViewTextBoxColumn();
            NomeDisciplina = new DataGridViewTextBoxColumn();
            NomeProfessor = new DataGridViewTextBoxColumn();
            semestre = new DataGridViewTextBoxColumn();
            pnMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMatricula).BeginInit();
            gbMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriculas).BeginInit();
            SuspendLayout();
            // 
            // pnMatricula
            // 
            pnMatricula.BackColor = Color.LightSeaGreen;
            pnMatricula.Controls.Add(pbMatricula);
            pnMatricula.Controls.Add(lblGestaoMatricula);
            pnMatricula.Dock = DockStyle.Top;
            pnMatricula.Location = new Point(0, 0);
            pnMatricula.Name = "pnMatricula";
            pnMatricula.Size = new Size(1008, 150);
            pnMatricula.TabIndex = 0;
            // 
            // pbMatricula
            // 
            pbMatricula.Image = Properties.Resources.Icon1;
            pbMatricula.Location = new Point(170, 27);
            pbMatricula.Name = "pbMatricula";
            pbMatricula.Size = new Size(100, 100);
            pbMatricula.SizeMode = PictureBoxSizeMode.Zoom;
            pbMatricula.TabIndex = 1;
            pbMatricula.TabStop = false;
            // 
            // lblGestaoMatricula
            // 
            lblGestaoMatricula.AutoSize = true;
            lblGestaoMatricula.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoMatricula.ForeColor = Color.White;
            lblGestaoMatricula.Location = new Point(276, 45);
            lblGestaoMatricula.Name = "lblGestaoMatricula";
            lblGestaoMatricula.Size = new Size(600, 65);
            lblGestaoMatricula.TabIndex = 1;
            lblGestaoMatricula.Text = "GESTÃO DE MATRÍCULAS";
            // 
            // gbMatricula
            // 
            gbMatricula.Controls.Add(txtSemestre);
            gbMatricula.Controls.Add(cbProfessor);
            gbMatricula.Controls.Add(cbDisciplina);
            gbMatricula.Controls.Add(cbAluno);
            gbMatricula.Controls.Add(lblSemestre);
            gbMatricula.Controls.Add(btnExcluir);
            gbMatricula.Controls.Add(btnSalvar);
            gbMatricula.Controls.Add(btnNovo);
            gbMatricula.Controls.Add(lblEmail);
            gbMatricula.Controls.Add(lblNome);
            gbMatricula.Controls.Add(lblAluno);
            gbMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMatricula.Location = new Point(10, 180);
            gbMatricula.Name = "gbMatricula";
            gbMatricula.Size = new Size(362, 325);
            gbMatricula.TabIndex = 2;
            gbMatricula.TabStop = false;
            gbMatricula.Text = "Informações da Matrícula";
            // 
            // txtSemestre
            // 
            txtSemestre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSemestre.Location = new Point(164, 134);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(192, 29);
            txtSemestre.TabIndex = 20;
            // 
            // cbProfessor
            // 
            cbProfessor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProfessor.FormattingEnabled = true;
            cbProfessor.Location = new Point(164, 99);
            cbProfessor.Name = "cbProfessor";
            cbProfessor.Size = new Size(192, 29);
            cbProfessor.TabIndex = 15;
            // 
            // cbDisciplina
            // 
            cbDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(164, 64);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(192, 29);
            cbDisciplina.TabIndex = 10;
            // 
            // cbAluno
            // 
            cbAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAluno.FormattingEnabled = true;
            cbAluno.Location = new Point(164, 29);
            cbAluno.Name = "cbAluno";
            cbAluno.Size = new Size(192, 29);
            cbAluno.TabIndex = 5;
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSemestre.Location = new Point(6, 136);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(78, 21);
            lblSemestre.TabIndex = 16;
            lblSemestre.Text = "Semestre:";
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
            btnExcluir.TabIndex = 27;
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
            btnSalvar.TabIndex = 26;
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
            btnNovo.TabIndex = 25;
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
            lblEmail.Size = new Size(79, 21);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Professor:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(6, 67);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 21);
            lblNome.TabIndex = 6;
            lblNome.Text = "Disciplina:";
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAluno.Location = new Point(6, 32);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(54, 21);
            lblAluno.TabIndex = 3;
            lblAluno.Text = "Aluno:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Image = Properties.Resources.refresh1;
            btnAtualizar.Location = new Point(973, 180);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(23, 23);
            btnAtualizar.TabIndex = 31;
            btnAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.Control;
            txtPesquisar.Location = new Point(817, 180);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar aluno...";
            txtPesquisar.Size = new Size(150, 23);
            txtPesquisar.TabIndex = 30;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvMatriculas
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvMatriculas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMatriculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMatriculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatriculas.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMatriculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMatriculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatriculas.Columns.AddRange(new DataGridViewColumn[] { id, NomeAluno, NomeDisciplina, NomeProfessor, semestre });
            dgvMatriculas.Location = new Point(378, 209);
            dgvMatriculas.MultiSelect = false;
            dgvMatriculas.Name = "dgvMatriculas";
            dgvMatriculas.ReadOnly = true;
            dgvMatriculas.Size = new Size(618, 296);
            dgvMatriculas.TabIndex = 35;
            dgvMatriculas.CellClick += dgvMatriculas_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // NomeAluno
            // 
            NomeAluno.DataPropertyName = "NomeAluno";
            NomeAluno.HeaderText = "Aluno";
            NomeAluno.Name = "NomeAluno";
            NomeAluno.ReadOnly = true;
            // 
            // NomeDisciplina
            // 
            NomeDisciplina.DataPropertyName = "NomeDisciplina";
            NomeDisciplina.HeaderText = "Disciplina";
            NomeDisciplina.Name = "NomeDisciplina";
            NomeDisciplina.ReadOnly = true;
            // 
            // NomeProfessor
            // 
            NomeProfessor.DataPropertyName = "NomeProfessor";
            NomeProfessor.HeaderText = "Professor";
            NomeProfessor.Name = "NomeProfessor";
            NomeProfessor.ReadOnly = true;
            // 
            // semestre
            // 
            semestre.DataPropertyName = "semestre";
            semestre.HeaderText = "Semestre";
            semestre.Name = "semestre";
            semestre.ReadOnly = true;
            // 
            // FormMatricula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(pnMatricula);
            Controls.Add(gbMatricula);
            Controls.Add(btnAtualizar);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvMatriculas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMatricula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matrícula - EduSmart";
            FormClosing += FormMatricula_FormClosing;
            Load += FormMatricula_Load;
            KeyDown += FormMatricula_KeyDown;
            pnMatricula.ResumeLayout(false);
            pnMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMatricula).EndInit();
            gbMatricula.ResumeLayout(false);
            gbMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnMatricula;
        private PictureBox pbMatricula;
        private Label lblGestaoMatricula;
        private GroupBox gbMatricula;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private Label lblEmail;
        private Label lblNome;
        private Label lblAluno;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private DataGridView dgvMatriculas;
        private Label lblSemestre;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NomeAluno;
        private DataGridViewTextBoxColumn NomeDisciplina;
        private DataGridViewTextBoxColumn NomeProfessor;
        private DataGridViewTextBoxColumn semestre;
        private ComboBox cbProfessor;
        private ComboBox cbDisciplina;
        private ComboBox cbAluno;
        private TextBox txtSemestre;
    }
}