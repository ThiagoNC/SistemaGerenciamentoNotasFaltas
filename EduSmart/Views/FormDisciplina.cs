using EduSmart.Models;
using EduSmart.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EduSmart.Views
{
    public partial class FormDisciplina : Form
    {
        public FormDisciplina()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new DisciplinaService();

                var listaDisciplinas = service.ListarTodos().OrderBy(b => b.Nome).ToList();

                dgvDisciplinas.DataSource = listaDisciplinas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de disciplinas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDisciplina_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            foreach (DataGridViewColumn coluna in dgvDisciplinas.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvDisciplinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvDisciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDisciplinas.Rows[e.RowIndex];

                string idSelecionado = row.Cells["id"].Value.ToString();

                txtNome.Text = row.Cells["nome"].Value.ToString();
                nudCargaHoraria.Value = Convert.ToInt32(row.Cells["cargaHoraria"].Value);

                this.Tag = idSelecionado;
            }
        }

        private void Novo()
        {
            txtNome.Clear();
            nudCargaHoraria.Value = 0;
            this.Tag = null;
            txtNome.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new DisciplinaService();

            dgvDisciplinas.DataSource = service.ListarPorNome(txtPesquisar.Text).OrderBy(b => b.Nome).ToList();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            MessageBox.Show("Lista atualizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(nudCargaHoraria.Value) == 0)
                {
                    MessageBox.Show("O carga horária é obrigatória!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var service = new DisciplinaService();

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(new Disciplina { Nome = txtNome.Text, CargaHoraria = Convert.ToInt32(nudCargaHoraria.Value) });
                    MessageBox.Show("Disciplina cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int id = Convert.ToInt32(this.Tag);
                    service.Atualizar(new Disciplina { Id = id, Nome = txtNome.Text, CargaHoraria = Convert.ToInt32(nudCargaHoraria.Value) });
                    MessageBox.Show("Disciplina atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Novo();

                AtualizarGrid();
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
                MessageBox.Show("Por favor, selecione uma disciplina na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir esta disciplina?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    DisciplinaService service = new DisciplinaService();
                    service.Excluir(id);

                    MessageBox.Show("Disciplina excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();

                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: Disciplina!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormDisciplina_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            //var form = new FormPrincipal();
            //form.ShowDialog();
        }

        private void FormDisciplina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
