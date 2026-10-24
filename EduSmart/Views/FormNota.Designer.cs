namespace EduSmart.Views
{
    partial class FormNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNota));
            pnNota = new Panel();
            pbNota = new PictureBox();
            lblGestaoNota = new Label();
            gbNota = new GroupBox();
            cbTipo = new ComboBox();
            lblValor = new Label();
            nudValor = new NumericUpDown();
            lblMatricula = new Label();
            cbMatricula = new ComboBox();
            cbAluno = new ComboBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            lblTipo = new Label();
            lblAluno = new Label();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            dgvNotas = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            id = new DataGridViewTextBoxColumn();
            NomeAluno = new DataGridViewTextBoxColumn();
            NomeDisciplina = new DataGridViewTextBoxColumn();
            NomeProfessor = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            dataLancamento = new DataGridViewTextBoxColumn();
            pnNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNota).BeginInit();
            gbNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // pnNota
            // 
            pnNota.BackColor = Color.LightSeaGreen;
            pnNota.Controls.Add(pbNota);
            pnNota.Controls.Add(lblGestaoNota);
            pnNota.Dock = DockStyle.Top;
            pnNota.Location = new Point(0, 0);
            pnNota.Name = "pnNota";
            pnNota.Size = new Size(1008, 150);
            pnNota.TabIndex = 31;
            // 
            // pbNota
            // 
            pbNota.Image = Properties.Resources.Icon1;
            pbNota.Location = new Point(170, 27);
            pbNota.Name = "pbNota";
            pbNota.Size = new Size(100, 100);
            pbNota.SizeMode = PictureBoxSizeMode.Zoom;
            pbNota.TabIndex = 1;
            pbNota.TabStop = false;
            // 
            // lblGestaoNota
            // 
            lblGestaoNota.AutoSize = true;
            lblGestaoNota.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoNota.ForeColor = Color.White;
            lblGestaoNota.Location = new Point(276, 45);
            lblGestaoNota.Name = "lblGestaoNota";
            lblGestaoNota.Size = new Size(455, 65);
            lblGestaoNota.TabIndex = 1;
            lblGestaoNota.Text = "GESTÃO DE NOTAS";
            // 
            // gbNota
            // 
            gbNota.Controls.Add(cbTipo);
            gbNota.Controls.Add(lblValor);
            gbNota.Controls.Add(nudValor);
            gbNota.Controls.Add(lblMatricula);
            gbNota.Controls.Add(cbMatricula);
            gbNota.Controls.Add(cbAluno);
            gbNota.Controls.Add(btnExcluir);
            gbNota.Controls.Add(btnSalvar);
            gbNota.Controls.Add(btnNovo);
            gbNota.Controls.Add(lblTipo);
            gbNota.Controls.Add(lblAluno);
            gbNota.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbNota.Location = new Point(10, 180);
            gbNota.Name = "gbNota";
            gbNota.Size = new Size(362, 325);
            gbNota.TabIndex = 32;
            gbNota.TabStop = false;
            gbNota.Text = "Informações da Nota";
            // 
            // cbTipo
            // 
            cbTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(164, 99);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(192, 29);
            cbTipo.TabIndex = 24;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(6, 139);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(49, 21);
            lblValor.TabIndex = 16;
            lblValor.Text = "Valor:";
            // 
            // nudValor
            // 
            nudValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudValor.Location = new Point(164, 137);
            nudValor.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(192, 29);
            nudValor.TabIndex = 20;
            nudValor.TextAlign = HorizontalAlignment.Center;
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
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(6, 102);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 21);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo:";
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
            btnAtualizar.TabIndex = 34;
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
            txtPesquisar.TabIndex = 33;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvNotas
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvNotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotas.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Columns.AddRange(new DataGridViewColumn[] { id, NomeAluno, NomeDisciplina, NomeProfessor, tipo, valor, dataLancamento });
            dgvNotas.Location = new Point(378, 209);
            dgvNotas.MultiSelect = false;
            dgvNotas.Name = "dgvNotas";
            dgvNotas.ReadOnly = true;
            dgvNotas.Size = new Size(618, 296);
            dgvNotas.TabIndex = 35;
            dgvNotas.CellClick += dgvNotas_CellClick;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
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
            // tipo
            // 
            tipo.DataPropertyName = "tipo";
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            // 
            // valor
            // 
            valor.DataPropertyName = "valor";
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // dataLancamento
            // 
            dataLancamento.DataPropertyName = "dataLancamento";
            dataLancamento.HeaderText = "Lançamento";
            dataLancamento.Name = "dataLancamento";
            dataLancamento.ReadOnly = true;
            // 
            // FormNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(pnNota);
            Controls.Add(gbNota);
            Controls.Add(btnAtualizar);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvNotas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nota - EduSmart";
            FormClosing += FormNota_FormClosing;
            Load += FormNota_Load;
            KeyDown += FormNota_KeyDown;
            pnNota.ResumeLayout(false);
            pnNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNota).EndInit();
            gbNota.ResumeLayout(false);
            gbNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnNota;
        private PictureBox pbNota;
        private Label lblGestaoNota;
        private GroupBox gbNota;
        private Label lblValor;
        private Label lblMatricula;
        private ComboBox cbMatricula;
        private ComboBox cbAluno;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private Label lblTipo;
        private Label lblAluno;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private DataGridView dgvNotas;
        private NumericUpDown nudValor;
        private ComboBox cbTipo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NomeAluno;
        private DataGridViewTextBoxColumn NomeDisciplina;
        private DataGridViewTextBoxColumn NomeProfessor;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn dataLancamento;
    }
}