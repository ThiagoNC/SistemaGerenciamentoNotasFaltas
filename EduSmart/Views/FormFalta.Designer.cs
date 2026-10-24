namespace EduSmart.Views
{
    partial class FormFalta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFalta));
            pnFalta = new Panel();
            pbFalta = new PictureBox();
            lblGestaoFalta = new Label();
            gbFalta = new GroupBox();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            dtpDataFalta = new DateTimePicker();
            lblMatricula = new Label();
            cbMatricula = new ComboBox();
            cbAluno = new ComboBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            lblData = new Label();
            lblAluno = new Label();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            dgvFaltas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            NomeAluno = new DataGridViewTextBoxColumn();
            NomeDisciplina = new DataGridViewTextBoxColumn();
            NomeProfessor = new DataGridViewTextBoxColumn();
            dataFalta = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            pnFalta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFalta).BeginInit();
            gbFalta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFaltas).BeginInit();
            SuspendLayout();
            // 
            // pnFalta
            // 
            pnFalta.BackColor = Color.LightSeaGreen;
            pnFalta.Controls.Add(pbFalta);
            pnFalta.Controls.Add(lblGestaoFalta);
            pnFalta.Dock = DockStyle.Top;
            pnFalta.Location = new Point(0, 0);
            pnFalta.Name = "pnFalta";
            pnFalta.Size = new Size(1008, 150);
            pnFalta.TabIndex = 0;
            // 
            // pbFalta
            // 
            pbFalta.Image = Properties.Resources.Icon1;
            pbFalta.Location = new Point(170, 27);
            pbFalta.Name = "pbFalta";
            pbFalta.Size = new Size(100, 100);
            pbFalta.SizeMode = PictureBoxSizeMode.Zoom;
            pbFalta.TabIndex = 1;
            pbFalta.TabStop = false;
            // 
            // lblGestaoFalta
            // 
            lblGestaoFalta.AutoSize = true;
            lblGestaoFalta.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoFalta.ForeColor = Color.White;
            lblGestaoFalta.Location = new Point(276, 45);
            lblGestaoFalta.Name = "lblGestaoFalta";
            lblGestaoFalta.Size = new Size(461, 65);
            lblGestaoFalta.TabIndex = 1;
            lblGestaoFalta.Text = "GESTÃO DE FALTAS";
            // 
            // gbFalta
            // 
            gbFalta.Controls.Add(lblQuantidade);
            gbFalta.Controls.Add(nudQuantidade);
            gbFalta.Controls.Add(dtpDataFalta);
            gbFalta.Controls.Add(lblMatricula);
            gbFalta.Controls.Add(cbMatricula);
            gbFalta.Controls.Add(cbAluno);
            gbFalta.Controls.Add(btnExcluir);
            gbFalta.Controls.Add(btnSalvar);
            gbFalta.Controls.Add(btnNovo);
            gbFalta.Controls.Add(lblData);
            gbFalta.Controls.Add(lblAluno);
            gbFalta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFalta.Location = new Point(10, 180);
            gbFalta.Name = "gbFalta";
            gbFalta.Size = new Size(362, 325);
            gbFalta.TabIndex = 2;
            gbFalta.TabStop = false;
            gbFalta.Text = "Informações da Falta";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(6, 139);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(94, 21);
            lblQuantidade.TabIndex = 16;
            lblQuantidade.Text = "Quantidade:";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantidade.Location = new Point(164, 137);
            nudQuantidade.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(192, 29);
            nudQuantidade.TabIndex = 20;
            nudQuantidade.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpDataFalta
            // 
            dtpDataFalta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataFalta.Format = DateTimePickerFormat.Short;
            dtpDataFalta.Location = new Point(164, 102);
            dtpDataFalta.Name = "dtpDataFalta";
            dtpDataFalta.Size = new Size(192, 29);
            dtpDataFalta.TabIndex = 15;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatricula.Location = new Point(6, 67);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(78, 21);
            lblMatricula.TabIndex = 6;
            lblMatricula.Text = "Matrícula:";
            // 
            // cbMatricula
            // 
            cbMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMatricula.FormattingEnabled = true;
            cbMatricula.Location = new Point(164, 64);
            cbMatricula.Name = "cbMatricula";
            cbMatricula.Size = new Size(192, 29);
            cbMatricula.TabIndex = 10;
            cbMatricula.SelectedIndexChanged += cbMatricula_SelectedIndexChanged;
            // 
            // cbAluno
            // 
            cbAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAluno.FormattingEnabled = true;
            cbAluno.Location = new Point(164, 29);
            cbAluno.Name = "cbAluno";
            cbAluno.Size = new Size(192, 29);
            cbAluno.TabIndex = 5;
            cbAluno.SelectedIndexChanged += cbAluno_SelectedIndexChanged;
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
            btnExcluir.TabIndex = 23;
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
            btnSalvar.TabIndex = 22;
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
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(6, 102);
            lblData.Name = "lblData";
            lblData.Size = new Size(45, 21);
            lblData.TabIndex = 11;
            lblData.Text = "Data:";
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
            btnAtualizar.TabIndex = 26;
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
            txtPesquisar.TabIndex = 25;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvFaltas
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvFaltas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFaltas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFaltas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFaltas.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFaltas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFaltas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaltas.Columns.AddRange(new DataGridViewColumn[] { id, NomeAluno, NomeDisciplina, NomeProfessor, dataFalta, quantidade });
            dgvFaltas.Location = new Point(378, 209);
            dgvFaltas.MultiSelect = false;
            dgvFaltas.Name = "dgvFaltas";
            dgvFaltas.ReadOnly = true;
            dgvFaltas.Size = new Size(618, 296);
            dgvFaltas.TabIndex = 30;
            dgvFaltas.CellClick += dgvFaltas_CellClick;
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
            // dataFalta
            // 
            dataFalta.DataPropertyName = "dataFalta";
            dataFalta.HeaderText = "Data";
            dataFalta.Name = "dataFalta";
            dataFalta.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "quantidade";
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // FormFalta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(pnFalta);
            Controls.Add(gbFalta);
            Controls.Add(btnAtualizar);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvFaltas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFalta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falta - EduSmart";
            FormClosing += FormFalta_FormClosing;
            Load += FormFalta_Load;
            KeyDown += FormFalta_KeyDown;
            pnFalta.ResumeLayout(false);
            pnFalta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFalta).EndInit();
            gbFalta.ResumeLayout(false);
            gbFalta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFaltas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnFalta;
        private PictureBox pbFalta;
        private Label lblGestaoFalta;
        private GroupBox gbFalta;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private Label lblData;
        private Label lblAluno;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private DataGridView dgvFaltas;
        private ComboBox cbAluno;
        private Label lblMatricula;
        private ComboBox cbMatricula;
        private DateTimePicker dtpDataFalta;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NomeAluno;
        private DataGridViewTextBoxColumn NomeDisciplina;
        private DataGridViewTextBoxColumn NomeProfessor;
        private DataGridViewTextBoxColumn dataFalta;
        private DataGridViewTextBoxColumn quantidade;
    }
}