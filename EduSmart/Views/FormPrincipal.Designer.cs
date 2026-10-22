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
            lblUsuario = new Label();
            gbMenu = new GroupBox();
            panel1 = new Panel();
            gbRisco = new GroupBox();
            dgvAlunos = new DataGridView();
            btnAluno = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrincipal).BeginInit();
            gbMenu.SuspendLayout();
            gbRisco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // pnPrincipal
            // 
            pnPrincipal.BackColor = Color.LightSeaGreen;
            pnPrincipal.Controls.Add(lblUsuario);
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
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(322, 108);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(94, 21);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Bem-vindo";
            // 
            // gbMenu
            // 
            gbMenu.BackColor = Color.White;
            gbMenu.Controls.Add(button4);
            gbMenu.Controls.Add(button3);
            gbMenu.Controls.Add(button2);
            gbMenu.Controls.Add(button1);
            gbMenu.Controls.Add(btnAluno);
            gbMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMenu.Location = new Point(10, 174);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(362, 325);
            gbMenu.TabIndex = 1;
            gbMenu.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 11);
            panel1.TabIndex = 2;
            // 
            // gbRisco
            // 
            gbRisco.Controls.Add(dgvAlunos);
            gbRisco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbRisco.Location = new Point(378, 174);
            gbRisco.Name = "gbRisco";
            gbRisco.Size = new Size(618, 325);
            gbRisco.TabIndex = 3;
            gbRisco.TabStop = false;
            gbRisco.Text = "Risco";
            // 
            // dgvAlunos
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlunos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.BackgroundColor = Color.White;
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(6, 23);
            dgvAlunos.MultiSelect = false;
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.ReadOnly = true;
            dgvAlunos.Size = new Size(618, 296);
            dgvAlunos.TabIndex = 7;
            // 
            // btnAluno
            // 
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAluno.Location = new Point(6, 23);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(350, 49);
            btnAluno.TabIndex = 0;
            btnAluno.Text = "ALUNOS";
            btnAluno.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 78);
            button1.Name = "button1";
            button1.Size = new Size(350, 49);
            button1.TabIndex = 1;
            button1.Text = "ALUNOS";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(6, 133);
            button2.Name = "button2";
            button2.Size = new Size(350, 49);
            button2.TabIndex = 2;
            button2.Text = "ALUNOS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 188);
            button3.Name = "button3";
            button3.Size = new Size(350, 49);
            button3.TabIndex = 3;
            button3.Text = "ALUNOS";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(6, 243);
            button4.Name = "button4";
            button4.Size = new Size(350, 49);
            button4.TabIndex = 4;
            button4.Text = "ALUNOS";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(gbRisco);
            Controls.Add(panel1);
            Controls.Add(gbMenu);
            Controls.Add(pnPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard - EduSmart";
            pnPrincipal.ResumeLayout(false);
            pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrincipal).EndInit();
            gbMenu.ResumeLayout(false);
            gbRisco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnPrincipal;
        private PictureBox pbPrincipal;
        private Label lblPainelPrincipal;
        private Label lblUsuario;
        private GroupBox gbMenu;
        private Panel panel1;
        private GroupBox gbRisco;
        private DataGridView dgvAlunos;
        private Button btnAluno;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}