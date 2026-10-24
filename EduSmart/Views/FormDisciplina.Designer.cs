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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisciplina));
            pnDisciplina = new Panel();
            pbDisciplina = new PictureBox();
            lblGestaoDisciplina = new Label();
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
            pnDisciplina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDisciplina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisciplinas).BeginInit();
            gbDisciplina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // pnDisciplina
            // 
            pnDisciplina.BackColor = Color.LightSeaGreen;
            pnDisciplina.Controls.Add(pbDisciplina);
            pnDisciplina.Controls.Add(lblGestaoDisciplina);
            pnDisciplina.Dock = DockStyle.Top;
            pnDisciplina.Location = new Point(0, 0);
            pnDisciplina.Name = "pnDisciplina";
            pnDisciplina.Size = new Size(1008, 150);
            pnDisciplina.TabIndex = 0;
            // 
            // pbDisciplina
            // 
            pbDisciplina.Image = Properties.Resources.Icon1;
            pbDisciplina.Location = new Point(170, 27);
            pbDisciplina.Name = "pbDisciplina";
            pbDisciplina.Size = new Size(100, 100);
            pbDisciplina.SizeMode = PictureBoxSizeMode.Zoom;
            pbDisciplina.TabIndex = 1;
            pbDisciplina.TabStop = false;
            // 
            // lblGestaoDisciplina
            // 
            lblGestaoDisciplina.AutoSize = true;
            lblGestaoDisciplina.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoDisciplina.ForeColor = Color.White;
            lblGestaoDisciplina.Location = new Point(276, 45);
            lblGestaoDisciplina.Name = "lblGestaoDisciplina";
            lblGestaoDisciplina.Size = new Size(587, 65);
            lblGestaoDisciplina.TabIndex = 1;
            lblGestaoDisciplina.Text = "GESTÃO DE DISCIPLINAS";
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
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dgvDisciplinas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDisciplinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDisciplinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisciplinas.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDisciplinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            Controls.Add(pnDisciplina);
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
            pnDisciplina.ResumeLayout(false);
            pnDisciplina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDisciplina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisciplinas).EndInit();
            gbDisciplina.ResumeLayout(false);
            gbDisciplina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnDisciplina;
        private PictureBox pbDisciplina;
        private Label lblGestaoDisciplina;
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