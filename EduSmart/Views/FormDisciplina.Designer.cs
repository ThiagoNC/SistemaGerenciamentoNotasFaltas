namespace EduSmart.Views
{
    partial class FormDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisciplina));
            pnDisciplinas = new Panel();
            pbDisciplinas = new PictureBox();
            lblGestaoDisciplinas = new Label();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            dgvDisciplinas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cargaHoraria = new DataGridViewTextBoxColumn();
            gbDisciplina = new GroupBox();
            nudCargaHoraria = new NumericUpDown();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            lblCargaHoraria = new Label();
            pnDisciplinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDisciplinas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisciplinas).BeginInit();
            gbDisciplina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // pnDisciplinas
            // 
            pnDisciplinas.BackColor = Color.LightSeaGreen;
            pnDisciplinas.Controls.Add(pbDisciplinas);
            pnDisciplinas.Controls.Add(lblGestaoDisciplinas);
            pnDisciplinas.Dock = DockStyle.Top;
            pnDisciplinas.Location = new Point(0, 0);
            pnDisciplinas.Name = "pnDisciplinas";
            pnDisciplinas.Size = new Size(1008, 150);
            pnDisciplinas.TabIndex = 0;
            // 
            // pbDisciplinas
            // 
            pbDisciplinas.Image = Properties.Resources.Icon1;
            pbDisciplinas.Location = new Point(170, 27);
            pbDisciplinas.Name = "pbDisciplinas";
            pbDisciplinas.Size = new Size(100, 100);
            pbDisciplinas.SizeMode = PictureBoxSizeMode.Zoom;
            pbDisciplinas.TabIndex = 1;
            pbDisciplinas.TabStop = false;
            // 
            // lblGestaoDisciplinas
            // 
            lblGestaoDisciplinas.AutoSize = true;
            lblGestaoDisciplinas.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoDisciplinas.ForeColor = Color.White;
            lblGestaoDisciplinas.Location = new Point(276, 45);
            lblGestaoDisciplinas.Name = "lblGestaoDisciplinas";
            lblGestaoDisciplinas.Size = new Size(587, 65);
            lblGestaoDisciplinas.TabIndex = 1;
            lblGestaoDisciplinas.Text = "GESTÃO DE DISCIPLINAS";
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
            txtPesquisar.PlaceholderText = "Pesquisar disciplina...";
            txtPesquisar.Size = new Size(150, 23);
            txtPesquisar.TabIndex = 20;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvDisciplinas
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvDisciplinas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDisciplinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDisciplinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisciplinas.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDisciplinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisciplinas.Columns.AddRange(new DataGridViewColumn[] { id, nome, cargaHoraria });
            dgvDisciplinas.Location = new Point(378, 209);
            dgvDisciplinas.MultiSelect = false;
            dgvDisciplinas.Name = "dgvDisciplinas";
            dgvDisciplinas.ReadOnly = true;
            dgvDisciplinas.Size = new Size(618, 296);
            dgvDisciplinas.TabIndex = 25;
            dgvDisciplinas.CellClick += dgvDisciplinas_CellClick;
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
            // cargaHoraria
            // 
            cargaHoraria.DataPropertyName = "cargaHoraria";
            cargaHoraria.HeaderText = "Carga Horária";
            cargaHoraria.Name = "cargaHoraria";
            cargaHoraria.ReadOnly = true;
            // 
            // gbDisciplina
            // 
            gbDisciplina.Controls.Add(nudCargaHoraria);
            gbDisciplina.Controls.Add(btnExcluir);
            gbDisciplina.Controls.Add(btnSalvar);
            gbDisciplina.Controls.Add(btnNovo);
            gbDisciplina.Controls.Add(txtNome);
            gbDisciplina.Controls.Add(lblNome);
            gbDisciplina.Controls.Add(lblCargaHoraria);
            gbDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDisciplina.Location = new Point(10, 180);
            gbDisciplina.Name = "gbDisciplina";
            gbDisciplina.Size = new Size(362, 325);
            gbDisciplina.TabIndex = 2;
            gbDisciplina.TabStop = false;
            gbDisciplina.Text = "Informações da Disciplina";
            // 
            // nudCargaHoraria
            // 
            nudCargaHoraria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCargaHoraria.Location = new Point(164, 65);
            nudCargaHoraria.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudCargaHoraria.Name = "nudCargaHoraria";
            nudCargaHoraria.Size = new Size(192, 29);
            nudCargaHoraria.TabIndex = 10;
            nudCargaHoraria.TextAlign = HorizontalAlignment.Center;
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
            btnExcluir.TabIndex = 17;
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
            btnSalvar.TabIndex = 16;
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
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
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
            // lblCargaHoraria
            // 
            lblCargaHoraria.AutoSize = true;
            lblCargaHoraria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCargaHoraria.Location = new Point(6, 67);
            lblCargaHoraria.Name = "lblCargaHoraria";
            lblCargaHoraria.Size = new Size(110, 21);
            lblCargaHoraria.TabIndex = 6;
            lblCargaHoraria.Text = "Carga Horária:";
            // 
            // FormDisciplina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(pnDisciplinas);
            Controls.Add(btnAtualizar);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvDisciplinas);
            Controls.Add(gbDisciplina);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDisciplina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disciplinas - EduSmart";
            FormClosing += FormDisciplina_FormClosing;
            Load += FormDisciplina_Load;
            KeyDown += FormDisciplina_KeyDown;
            pnDisciplinas.ResumeLayout(false);
            pnDisciplinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDisciplinas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisciplinas).EndInit();
            gbDisciplina.ResumeLayout(false);
            gbDisciplina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnDisciplinas;
        private PictureBox pbDisciplinas;
        private Label lblGestaoDisciplinas;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private DataGridView dgvDisciplinas;
        private GroupBox gbDisciplina;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCargaHoraria;
        private NumericUpDown nudCargaHoraria;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cargaHoraria;
    }
}