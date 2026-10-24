namespace EduSmart.Views
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pnPrincipal = new Panel();
            pbPrincipal = new PictureBox();
            lblPainelPrincipal = new Label();
            gbNavegacao = new GroupBox();
            btnSair = new Button();
            btnNota = new Button();
            btnFalta = new Button();
            btnMatricula = new Button();
            btnDisciplina = new Button();
            btnProfessor = new Button();
            btnAluno = new Button();
            dgvAlertas = new DataGridView();
            NomeAluno = new DataGridViewTextBoxColumn();
            NomeDisciplina = new DataGridViewTextBoxColumn();
            NivelRisco = new DataGridViewTextBoxColumn();
            JustificativaIa = new DataGridViewTextBoxColumn();
            DataAnalise = new DataGridViewTextBoxColumn();
            pnTotalAlunos = new Panel();
            lblValorTotalAlunos = new Label();
            lblTotalAlunos = new Label();
            pnMatriculasAtivas = new Panel();
            lblValorMatriculasAtivas = new Label();
            lblMatriculasAtivas = new Label();
            pnAlertasCriticos = new Panel();
            lblAlertasCriticos = new Label();
            lblValorAlertasCriticos = new Label();
            btnExecutarIA = new Button();
            btnAtualizarAlertas = new Button();
            pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrincipal).BeginInit();
            gbNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).BeginInit();
            pnTotalAlunos.SuspendLayout();
            pnMatriculasAtivas.SuspendLayout();
            pnAlertasCriticos.SuspendLayout();
            SuspendLayout();
            // 
            // pnPrincipal
            // 
            pnPrincipal.BackColor = Color.LightSeaGreen;
            pnPrincipal.Controls.Add(pbPrincipal);
            pnPrincipal.Controls.Add(lblPainelPrincipal);
            pnPrincipal.Dock = DockStyle.Top;
            pnPrincipal.Location = new Point(0, 0);
            pnPrincipal.Name = "pnPrincipal";
            pnPrincipal.Size = new Size(1008, 150);
            pnPrincipal.TabIndex = 0;
            // 
            // pbPrincipal
            // 
            pbPrincipal.Image = Properties.Resources.Icon1;
            pbPrincipal.Location = new Point(206, 25);
            pbPrincipal.Name = "pbPrincipal";
            pbPrincipal.Size = new Size(100, 100);
            pbPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            pbPrincipal.TabIndex = 3;
            pbPrincipal.TabStop = false;
            // 
            // lblPainelPrincipal
            // 
            lblPainelPrincipal.AutoSize = true;
            lblPainelPrincipal.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPainelPrincipal.ForeColor = Color.White;
            lblPainelPrincipal.Location = new Point(312, 43);
            lblPainelPrincipal.Name = "lblPainelPrincipal";
            lblPainelPrincipal.Size = new Size(448, 65);
            lblPainelPrincipal.TabIndex = 2;
            lblPainelPrincipal.Text = "PAINEL PRINCIPAL";
            // 
            // gbNavegacao
            // 
            gbNavegacao.BackColor = Color.White;
            gbNavegacao.Controls.Add(btnSair);
            gbNavegacao.Controls.Add(btnNota);
            gbNavegacao.Controls.Add(btnFalta);
            gbNavegacao.Controls.Add(btnMatricula);
            gbNavegacao.Controls.Add(btnDisciplina);
            gbNavegacao.Controls.Add(btnProfessor);
            gbNavegacao.Controls.Add(btnAluno);
            gbNavegacao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbNavegacao.Location = new Point(0, 151);
            gbNavegacao.Name = "gbNavegacao";
            gbNavegacao.Size = new Size(179, 363);
            gbNavegacao.TabIndex = 1;
            gbNavegacao.TabStop = false;
            gbNavegacao.Text = "Navegação";
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.Red;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(6, 312);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(167, 40);
            btnSair.TabIndex = 6;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnNota
            // 
            btnNota.FlatStyle = FlatStyle.Flat;
            btnNota.ImageAlign = ContentAlignment.MiddleLeft;
            btnNota.Location = new Point(6, 253);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(167, 40);
            btnNota.TabIndex = 5;
            btnNota.Text = "NOTAS";
            btnNota.UseVisualStyleBackColor = true;
            btnNota.Click += btnNota_Click;
            // 
            // btnFalta
            // 
            btnFalta.FlatStyle = FlatStyle.Flat;
            btnFalta.ImageAlign = ContentAlignment.MiddleLeft;
            btnFalta.Location = new Point(6, 207);
            btnFalta.Name = "btnFalta";
            btnFalta.Size = new Size(167, 40);
            btnFalta.TabIndex = 4;
            btnFalta.Text = "FALTAS";
            btnFalta.UseVisualStyleBackColor = true;
            btnFalta.Click += btnFalta_Click;
            // 
            // btnMatricula
            // 
            btnMatricula.FlatStyle = FlatStyle.Flat;
            btnMatricula.ImageAlign = ContentAlignment.MiddleLeft;
            btnMatricula.Location = new Point(6, 161);
            btnMatricula.Name = "btnMatricula";
            btnMatricula.Size = new Size(167, 40);
            btnMatricula.TabIndex = 3;
            btnMatricula.Text = "MATRÍCULAS";
            btnMatricula.UseVisualStyleBackColor = true;
            btnMatricula.Click += btnMatricula_Click;
            // 
            // btnDisciplina
            // 
            btnDisciplina.FlatStyle = FlatStyle.Flat;
            btnDisciplina.ImageAlign = ContentAlignment.MiddleLeft;
            btnDisciplina.Location = new Point(6, 115);
            btnDisciplina.Name = "btnDisciplina";
            btnDisciplina.Size = new Size(167, 40);
            btnDisciplina.TabIndex = 2;
            btnDisciplina.Text = "DISCIPLINAS";
            btnDisciplina.UseVisualStyleBackColor = true;
            btnDisciplina.Click += btnDisciplina_Click;
            // 
            // btnProfessor
            // 
            btnProfessor.FlatStyle = FlatStyle.Flat;
            btnProfessor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfessor.Location = new Point(6, 69);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Size = new Size(167, 40);
            btnProfessor.TabIndex = 1;
            btnProfessor.Text = "PROFESSORES";
            btnProfessor.UseVisualStyleBackColor = true;
            btnProfessor.Click += btnProfessor_Click;
            // 
            // btnAluno
            // 
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAluno.Location = new Point(6, 23);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(167, 40);
            btnAluno.TabIndex = 0;
            btnAluno.Text = "ALUNOS";
            btnAluno.UseVisualStyleBackColor = true;
            btnAluno.Click += btnAluno_Click;
            // 
            // dgvAlertas
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvAlertas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlertas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlertas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlertas.BackgroundColor = Color.White;
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertas.Columns.AddRange(new DataGridViewColumn[] { NomeAluno, NomeDisciplina, NivelRisco, JustificativaIa, DataAnalise });
            dgvAlertas.Location = new Point(185, 220);
            dgvAlertas.MultiSelect = false;
            dgvAlertas.Name = "dgvAlertas";
            dgvAlertas.ReadOnly = true;
            dgvAlertas.Size = new Size(816, 283);
            dgvAlertas.TabIndex = 7;
            dgvAlertas.CellFormatting += dgvAlertas_CellFormatting;
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
            // NivelRisco
            // 
            NivelRisco.DataPropertyName = "NivelRisco";
            NivelRisco.HeaderText = "Nível de Risco";
            NivelRisco.Name = "NivelRisco";
            NivelRisco.ReadOnly = true;
            // 
            // JustificativaIa
            // 
            JustificativaIa.DataPropertyName = "JustificativaIa";
            JustificativaIa.HeaderText = "Justificativa da IA";
            JustificativaIa.Name = "JustificativaIa";
            JustificativaIa.ReadOnly = true;
            // 
            // DataAnalise
            // 
            DataAnalise.DataPropertyName = "DataAnalise";
            DataAnalise.HeaderText = "Análise";
            DataAnalise.Name = "DataAnalise";
            DataAnalise.ReadOnly = true;
            // 
            // pnTotalAlunos
            // 
            pnTotalAlunos.BackColor = Color.White;
            pnTotalAlunos.Controls.Add(lblValorTotalAlunos);
            pnTotalAlunos.Controls.Add(lblTotalAlunos);
            pnTotalAlunos.Location = new Point(185, 156);
            pnTotalAlunos.Name = "pnTotalAlunos";
            pnTotalAlunos.Size = new Size(200, 58);
            pnTotalAlunos.TabIndex = 8;
            // 
            // lblValorTotalAlunos
            // 
            lblValorTotalAlunos.AutoSize = true;
            lblValorTotalAlunos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotalAlunos.Location = new Point(6, 23);
            lblValorTotalAlunos.Name = "lblValorTotalAlunos";
            lblValorTotalAlunos.Size = new Size(25, 30);
            lblValorTotalAlunos.TabIndex = 1;
            lblValorTotalAlunos.Text = "0";
            // 
            // lblTotalAlunos
            // 
            lblTotalAlunos.AutoSize = true;
            lblTotalAlunos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAlunos.Location = new Point(6, 6);
            lblTotalAlunos.Name = "lblTotalAlunos";
            lblTotalAlunos.Size = new Size(105, 17);
            lblTotalAlunos.TabIndex = 0;
            lblTotalAlunos.Text = "Total de Alunos";
            // 
            // pnMatriculasAtivas
            // 
            pnMatriculasAtivas.BackColor = Color.White;
            pnMatriculasAtivas.Controls.Add(lblValorMatriculasAtivas);
            pnMatriculasAtivas.Controls.Add(lblMatriculasAtivas);
            pnMatriculasAtivas.Location = new Point(391, 156);
            pnMatriculasAtivas.Name = "pnMatriculasAtivas";
            pnMatriculasAtivas.Size = new Size(200, 58);
            pnMatriculasAtivas.TabIndex = 9;
            // 
            // lblValorMatriculasAtivas
            // 
            lblValorMatriculasAtivas.AutoSize = true;
            lblValorMatriculasAtivas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorMatriculasAtivas.Location = new Point(6, 23);
            lblValorMatriculasAtivas.Name = "lblValorMatriculasAtivas";
            lblValorMatriculasAtivas.Size = new Size(25, 30);
            lblValorMatriculasAtivas.TabIndex = 1;
            lblValorMatriculasAtivas.Text = "0";
            // 
            // lblMatriculasAtivas
            // 
            lblMatriculasAtivas.AutoSize = true;
            lblMatriculasAtivas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatriculasAtivas.Location = new Point(6, 6);
            lblMatriculasAtivas.Name = "lblMatriculasAtivas";
            lblMatriculasAtivas.Size = new Size(114, 17);
            lblMatriculasAtivas.TabIndex = 0;
            lblMatriculasAtivas.Text = "Matrículas Ativas";
            // 
            // pnAlertasCriticos
            // 
            pnAlertasCriticos.BackColor = Color.White;
            pnAlertasCriticos.Controls.Add(lblAlertasCriticos);
            pnAlertasCriticos.Controls.Add(lblValorAlertasCriticos);
            pnAlertasCriticos.Location = new Point(597, 156);
            pnAlertasCriticos.Name = "pnAlertasCriticos";
            pnAlertasCriticos.Size = new Size(200, 58);
            pnAlertasCriticos.TabIndex = 10;
            // 
            // lblAlertasCriticos
            // 
            lblAlertasCriticos.AutoSize = true;
            lblAlertasCriticos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlertasCriticos.Location = new Point(7, 6);
            lblAlertasCriticos.Name = "lblAlertasCriticos";
            lblAlertasCriticos.Size = new Size(141, 17);
            lblAlertasCriticos.TabIndex = 0;
            lblAlertasCriticos.Text = "Alertas Críticos (Alto)";
            // 
            // lblValorAlertasCriticos
            // 
            lblValorAlertasCriticos.AutoSize = true;
            lblValorAlertasCriticos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorAlertasCriticos.Location = new Point(7, 23);
            lblValorAlertasCriticos.Name = "lblValorAlertasCriticos";
            lblValorAlertasCriticos.Size = new Size(25, 30);
            lblValorAlertasCriticos.TabIndex = 1;
            lblValorAlertasCriticos.Text = "0";
            // 
            // btnExecutarIA
            // 
            btnExecutarIA.BackColor = Color.MediumSeaGreen;
            btnExecutarIA.FlatStyle = FlatStyle.Flat;
            btnExecutarIA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExecutarIA.ForeColor = Color.White;
            btnExecutarIA.ImageAlign = ContentAlignment.MiddleLeft;
            btnExecutarIA.Location = new Point(803, 156);
            btnExecutarIA.Name = "btnExecutarIA";
            btnExecutarIA.Size = new Size(198, 26);
            btnExecutarIA.TabIndex = 7;
            btnExecutarIA.Text = "Executar Análise de Risco (IA)";
            btnExecutarIA.UseVisualStyleBackColor = false;
            btnExecutarIA.Click += btnExecutarIA_Click;
            // 
            // btnAtualizarAlertas
            // 
            btnAtualizarAlertas.BackColor = SystemColors.Control;
            btnAtualizarAlertas.FlatStyle = FlatStyle.Flat;
            btnAtualizarAlertas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarAlertas.ForeColor = SystemColors.ControlText;
            btnAtualizarAlertas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizarAlertas.Location = new Point(803, 188);
            btnAtualizarAlertas.Name = "btnAtualizarAlertas";
            btnAtualizarAlertas.Size = new Size(198, 26);
            btnAtualizarAlertas.TabIndex = 11;
            btnAtualizarAlertas.Text = "Atualizar Alertas de Risco (IA)";
            btnAtualizarAlertas.UseVisualStyleBackColor = false;
            btnAtualizarAlertas.Click += btnAtualizarAlertas_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(btnAtualizarAlertas);
            Controls.Add(btnExecutarIA);
            Controls.Add(pnAlertasCriticos);
            Controls.Add(pnMatriculasAtivas);
            Controls.Add(pnTotalAlunos);
            Controls.Add(dgvAlertas);
            Controls.Add(gbNavegacao);
            Controls.Add(pnPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - EduSmart";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            KeyDown += FormPrincipal_KeyDown;
            pnPrincipal.ResumeLayout(false);
            pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrincipal).EndInit();
            gbNavegacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).EndInit();
            pnTotalAlunos.ResumeLayout(false);
            pnTotalAlunos.PerformLayout();
            pnMatriculasAtivas.ResumeLayout(false);
            pnMatriculasAtivas.PerformLayout();
            pnAlertasCriticos.ResumeLayout(false);
            pnAlertasCriticos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnPrincipal;
        private PictureBox pbPrincipal;
        private Label lblPainelPrincipal;
        private GroupBox gbNavegacao;
        private DataGridView dgvAlertas;
        private Button btnAluno;
        private Button btnFalta;
        private Button btnMatricula;
        private Button btnDisciplina;
        private Button btnProfessor;
        private Button btnNota;
        private Button btnSair;
        private Panel pnTotalAlunos;
        private Label lblValorTotalAlunos;
        private Label lblTotalAlunos;
        private Panel pnMatriculasAtivas;
        private Label lblValorMatriculasAtivas;
        private Label lblMatriculasAtivas;
        private Panel pnAlertasCriticos;
        private Label lblValorAlertasCriticos;
        private Label lblAlertasCriticos;
        private Button btnExecutarIA;
        private Button btnAtualizarAlertas;
        private DataGridViewTextBoxColumn NomeAluno;
        private DataGridViewTextBoxColumn NomeDisciplina;
        private DataGridViewTextBoxColumn NivelRisco;
        private DataGridViewTextBoxColumn JustificativaIa;
        private DataGridViewTextBoxColumn DataAnalise;
    }
}