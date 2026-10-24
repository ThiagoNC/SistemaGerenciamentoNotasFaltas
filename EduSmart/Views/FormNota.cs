using EduSmart.Models;
using EduSmart.Models;
using EduSmart.Services;
using EduSmart.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EduSmart.Views
{
    public partial class FormNota : Form
    {
        private bool _selecionandoPeloGrid = false;

        public FormNota()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FormNota_Load(object sender, EventArgs e)
        {
            CarregarComboBoxAlunos();
            CarregarComboBoxTipos();

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

        private void CarregarComboBoxTipos()
        {
            cbTipo.Items.Clear();
            cbTipo.Items.AddRange(new string[] { "Prova", "Trabalho", "Atividade", "Seminário", "Participação", "Simulado", "Recuperação" });
            cbTipo.SelectedIndex = 0;
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

                    if (!_selecionandoPeloGrid)
                    {
                        AtualizarGrid(idAluno: idAluno);
                    }
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
            if (!_selecionandoPeloGrid)
            {
                AtualizarGridSelecionado();
            }
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
                var service = new NotaService();
                var listaNotas = service.ListarPorNomeAluno("");

                if (idMatricula.HasValue)
                {
                    listaNotas = listaNotas.Where(f => f.IdMatricula == idMatricula.Value).ToList();
                }
                else if (idAluno.HasValue)
                {
                    listaNotas = listaNotas.Where(f => f.IdAluno == idAluno.Value).ToList();
                }

                dgvNotas.DataSource = listaNotas.OrderBy(f => f.NomeDisciplina).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de notas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn coluna in dgvNotas.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvNotas.Columns["dataLancamento"].DataPropertyName = "dataLancamento";
            dgvNotas.Columns["dataLancamento"].DefaultCellStyle.Format = "dd/MM/yyyy";


            if (dgvNotas.Columns["idAluno"] != null) dgvNotas.Columns["idAluno"].Visible = false;
            if (dgvNotas.Columns["idMatricula"] != null) dgvNotas.Columns["idMatricula"].Visible = false;
        }

        private void Novo()
        {
            cbAluno.SelectedIndex = -1;
            cbMatricula.SelectedIndex = -1;
            cbTipo.SelectedIndex = 0;
            nudValor.Value = 0;
            this.Tag = null;
            cbAluno.Focus();
        }

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selecionandoPeloGrid = true;

                DataGridViewRow row = dgvNotas.Rows[e.RowIndex];

                string idSelecionado = row.Cells["id"].Value.ToString();

                cbAluno.SelectedValue = row.Cells["idAluno"].Value;
                cbMatricula.SelectedValue = row.Cells["idMatricula"].Value;
                cbTipo.SelectedItem = row.Cells["tipo"].Value.ToString();
                nudValor.Value = Convert.ToDecimal(row.Cells["valor"].Value);

                this.Tag = idSelecionado;

                _selecionandoPeloGrid = false;
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
                if (Convert.ToDecimal(nudValor.Value) < 0) { MessageBox.Show("Coloque um valor!"); return; }

                var service = new NotaService();

                var nota = new Nota
                {
                    IdMatricula = Convert.ToInt32(cbMatricula.SelectedValue),
                    DataLancamento = DateTime.Now.Date,
                    Tipo = cbTipo.SelectedItem?.ToString() ?? "Prova",
                    Valor = Convert.ToDecimal(nudValor.Value)
                };

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(nota);
                    MessageBox.Show("Nota cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    nota.Id = Convert.ToInt32(this.Tag);
                    service.Atualizar(nota);
                    MessageBox.Show("Nota atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Novo();
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
                MessageBox.Show("Por favor, selecione uma nota na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir esta nota?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    var service = new NotaService();
                    service.Excluir(id);

                    MessageBox.Show("Nota excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();
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
            var service = new NotaService();
            dgvNotas.DataSource = service.ListarPorNomeAluno(txtPesquisar.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            MessageBox.Show("Lista atualizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormNota_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //var form = new FormPrincipal();
            //form.ShowDialog();
        }

        private void FormNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
