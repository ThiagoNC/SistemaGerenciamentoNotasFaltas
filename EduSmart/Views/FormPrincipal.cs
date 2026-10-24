using System;
using System.Linq;
using System.Windows.Forms;
using EduSmart.Services;
using EduSmart.Repositories;
using EduSmart.Models;

namespace EduSmart.Views
{
    public partial class FormPrincipal : Form
    {
        private readonly AlertaRiscoService _alertaService;
        private readonly AlunoService _alunoService;
        private readonly MatriculaService _matriculaService;
        private readonly AlertaRiscoRepository _alertaRepository;

        public FormPrincipal()
        {
            InitializeComponent();
            _alertaService = new AlertaRiscoService();
            _alunoService = new AlunoService();
            _matriculaService = new MatriculaService();
            _alertaRepository = new AlertaRiscoRepository();
            this.KeyPreview = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ConfigurarGrelha();
            AtualizarResumo();
            CarregarGrelhaAlertas();
        }

        private void ConfigurarGrelha()
        {
            dgvAlertas.AutoGenerateColumns = false;
            dgvAlertas.ReadOnly = true;
            dgvAlertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Assumindo que definiu as colunas no modo design com estes DataPropertyNames:
            // dgvAlertas.Columns["colAluno"].DataPropertyName = "NomeAluno";
            // dgvAlertas.Columns["colDisciplina"].DataPropertyName = "NomeDisciplina";
            // dgvAlertas.Columns["colRisco"].DataPropertyName = "NivelRisco";
            // dgvAlertas.Columns["colJustificativa"].DataPropertyName = "JustificativaIa";
            // dgvAlertas.Columns["colData"].DataPropertyName = "DataAnalise";
        }

        private void AtualizarResumo()
        {
            try
            {
                lblValorTotalAlunos.Text = _alunoService.ListarTodos().Count.ToString();
                lblValorMatriculasAtivas.Text = _matriculaService.ListarTodos().Count.ToString();

                var alertas = _alertaRepository.ListarTodos();
                lblValorAlertasCriticos.Text = alertas.Count(a => a.NivelRisco == Models.NivelRisco.Alto).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar resumo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrelhaAlertas()
        {
            try
            {
                var alertas = _alertaRepository.ListarTodos();
                dgvAlertas.DataSource = null;
                dgvAlertas.DataSource = alertas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar grelha de alertas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlertas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAlertas.Columns[e.ColumnIndex].DataPropertyName == "NivelRisco")
            {
                if (e.Value != null)
                {
                    string nivelRisco = e.Value.ToString();

                    switch (nivelRisco)
                    {
                        case "Alto":
                            e.CellStyle.BackColor = System.Drawing.Color.LightCoral;
                            break;
                        case "Medio":
                            e.CellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                            break;
                        case "Baixo":
                            e.CellStyle.BackColor = System.Drawing.Color.LightGreen;
                            break;
                    }
                }
            }
        }

        private async void btnExecutarIA_Click(object sender, EventArgs e)
        {
            try
            {
                btnExecutarIA.Enabled = false;
                btnExecutarIA.Text = "A processar análise...";
                Cursor = Cursors.WaitCursor;

                await _alertaService.ExecutarAnaliseGeralAsync();

                CarregarGrelhaAlertas();
                AtualizarResumo();

                MessageBox.Show("Análise de risco concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar análise: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExecutarIA.Enabled = true;
                btnExecutarIA.Text = "Executar Análise de Risco (IA)";
                Cursor = Cursors.Default;
            }
        }

        private void btnAtualizarAlertas_Click(object sender, EventArgs e)
        {
            CarregarGrelhaAlertas();
            AtualizarResumo();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormAluno();
            form.ShowDialog();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormProfessor();
            form.ShowDialog();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormDisciplina();
            form.ShowDialog();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormMatricula();
            form.ShowDialog();
        }

        private void btnFalta_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormFalta();
            form.ShowDialog();
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormNota();
            form.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            var form = new FormLogin();
            form.ShowDialog();
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}