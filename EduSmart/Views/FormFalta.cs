using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EduSmart.Services;
using EduSmart.Models;

namespace EduSmart.Views
{
    public partial class FormFalta : Form
    {
        public FormFalta()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FormFalta_Load(object sender, EventArgs e)
        {
            CarregarComboBoxAlunos();

            AtualizarGrid();

            ConfigurarGrid();
        }

        private void CarregarComboBoxAlunos()
        {
            try
            {
                cbAluno.SelectedIndexChanged -= cbAluno_SelectedIndexChanged;

                cbAluno.DataSource = new AlunoService().ListarTodos().OrderBy(c => c.Nome).ToList();
                cbAluno.DisplayMember = "Nome";
                cbAluno.ValueMember = "Id";
                cbAluno.SelectedIndex = -1;

                cbAluno.SelectedIndexChanged += cbAluno_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAluno.SelectedValue != null && int.TryParse(cbAluno.SelectedValue.ToString(), out int idAluno))
            {
                try
                {
                    var matriculas = new MatriculaService().ListarPorIdAluno(idAluno);

                    var listaFormatada = matriculas.Select(m => new {
                        Id = m.Id,
                        TextoExibicao = $"{m.NomeDisciplina} - {m.Semestre}"
                    }).OrderBy(m => m.TextoExibicao).ToList();

                    cbMatricula.SelectedIndexChanged -= cbMatricula_SelectedIndexChanged;

                    cbMatricula.DataSource = listaFormatada;
                    cbMatricula.DisplayMember = "TextoExibicao";
                    cbMatricula.ValueMember = "Id";
                    cbMatricula.SelectedIndex = -1;

                    cbMatricula.SelectedIndexChanged += cbMatricula_SelectedIndexChanged;

                    AtualizarGrid(idAluno: idAluno);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar matrículas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cbMatricula.DataSource = null;
                AtualizarGrid();
            }
        }

        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGridSelecionado();
        }

        private void AtualizarGridSelecionado()
        {
            if (cbMatricula.SelectedValue != null && int.TryParse(cbMatricula.SelectedValue.ToString(), out int idMatricula))
            {
                AtualizarGrid(idMatricula: idMatricula);
            }
            else if (cbAluno.SelectedValue != null && int.TryParse(cbAluno.SelectedValue.ToString(), out int idAluno))
            {
                AtualizarGrid(idAluno: idAluno);
            }
        }

        private void AtualizarGrid(int? idAluno = null, int? idMatricula = null)
        {
            try
            {
                var service = new FaltaService();
                var listaFaltas = service.ListarPorNomeAluno("");

                if (idMatricula.HasValue)
                {
                    listaFaltas = listaFaltas.Where(f => f.IdMatricula == idMatricula.Value).ToList();
                }
                else if (idAluno.HasValue)
                {
                    listaFaltas = listaFaltas.Where(f => f.IdAluno == idAluno.Value).ToList();
                }

                dgvFaltas.DataSource = listaFaltas.OrderBy(f => f.DataFalta).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de faltas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvFaltas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn coluna in dgvFaltas.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvFaltas.Columns["dataFalta"].DataPropertyName = "dataFalta";
            dgvFaltas.Columns["dataFalta"].DefaultCellStyle.Format = "dd/MM/yyyy";


            if (dgvFaltas.Columns["idAluno"] != null) dgvFaltas.Columns["idAluno"].Visible = false;
            if (dgvFaltas.Columns["idMatricula"] != null) dgvFaltas.Columns["idMatricula"].Visible = false;
        }

        private void Novo()
        {
            cbAluno.SelectedIndex = -1;
            cbMatricula.SelectedIndex = -1;
            dtpDataFalta.Value = DateTime.Now;
            nudQuantidade.Value = 0;
            this.Tag = null;
            cbAluno.Focus();
        }

        private void dgvFaltas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFaltas.Rows[e.RowIndex];

                string idSelecionado = row.Cells["id"].Value.ToString();

                cbAluno.SelectedValue = row.Cells["idAluno"].Value;
                cbMatricula.SelectedValue = row.Cells["idMatricula"].Value;

                DateTime dataFalta = Convert.ToDateTime(row.Cells["dataFalta"].Value);
                dtpDataFalta.Value = dataFalta.Date;
                nudQuantidade.Value = Convert.ToInt32(row.Cells["quantidade"].Value);

                this.Tag = idSelecionado;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAluno.SelectedValue == null) { MessageBox.Show("Selecione um Aluno!"); return; }
                if (cbMatricula.SelectedValue == null) { MessageBox.Show("Selecione uma Disciplina!"); return; }
                if (Convert.ToInt32(nudQuantidade.Value) == 0) { MessageBox.Show("Coloque uma quantidade!"); return; }

                var service = new FaltaService();

                var falta = new Falta
                {
                    IdMatricula = Convert.ToInt32(cbMatricula.SelectedValue),
                    DataFalta = dtpDataFalta.Value.Date,
                    Quantidade = Convert.ToInt32(nudQuantidade.Value)
                };

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(falta);
                    MessageBox.Show("Falta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    falta.Id = Convert.ToInt32(this.Tag);
                    service.Atualizar(falta);
                    MessageBox.Show("Falta atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Tag = null;
                AtualizarGridSelecionado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
            {
                MessageBox.Show("Por favor, selecione uma falta na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir esta falta?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    var service = new FaltaService();
                    service.Excluir(id);

                    MessageBox.Show("Falta excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Tag = null;
                    AtualizarGridSelecionado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new FaltaService();
            dgvFaltas.DataSource = service.ListarPorNomeAluno(txtPesquisar.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            MessageBox.Show("Lista atualizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormFalta_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //var form = new FormPrincipal();
            //form.ShowDialog();
        }

        private void FormFalta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
