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
    public partial class FormMatricula : Form
    {
        public FormMatricula()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FormMatriculas_Load(object sender, EventArgs e)
        {
            CarregarComboBoxes();

            AtualizarGrid();

            ConfigurarGrid();
        }

        private void CarregarComboBoxes()
        {
            try
            {
                cbAluno.DataSource = new AlunoService().ListarTodos().OrderBy(c => c.Nome).ToList();
                cbAluno.DisplayMember = "Nome";
                cbAluno.ValueMember = "Id";
                cbAluno.SelectedIndex = -1;

                cbDisciplina.DataSource = new DisciplinaService().ListarTodos().OrderBy(s => s.Nome).ToList();
                cbDisciplina.DisplayMember = "Nome";
                cbDisciplina.ValueMember = "Id";
                cbDisciplina.SelectedIndex = -1;

                cbProfessor.DataSource = new ProfessorService().ListarTodos().OrderBy(b => b.Nome).ToList();
                cbProfessor.DisplayMember = "Nome";
                cbProfessor.ValueMember = "Id";
                cbProfessor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados das listas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new MatriculaService();
                dgvMatriculas.DataSource = service.ListarTodos().OrderBy(a => a.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de matrículas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvMatriculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn coluna in dgvMatriculas.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvMatriculas.Columns["idAluno"] != null) dgvMatriculas.Columns["idAluno"].Visible = false;
            if (dgvMatriculas.Columns["idDisciplina"] != null) dgvMatriculas.Columns["idDisciplina"].Visible = false;
            if (dgvMatriculas.Columns["idProfessor"] != null) dgvMatriculas.Columns["idProfessor"].Visible = false;
        }

        private void Novo()
        {
            cbAluno.SelectedIndex = -1;
            cbDisciplina.SelectedIndex = -1;
            cbProfessor.SelectedIndex = -1;
            txtSemestre.Text = null;
            this.Tag = null;
            cbAluno.Focus();
        }

        private void dgvMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMatriculas.Rows[e.RowIndex];

                string idSelecionado = row.Cells["Id"].Value.ToString();

                cbAluno.SelectedValue = row.Cells["idAluno"].Value;
                cbDisciplina.SelectedValue = row.Cells["idDisciplina"].Value;
                cbProfessor.SelectedValue = row.Cells["idProfessor"].Value;
                txtSemestre.Text = row.Cells["semestre"].Value.ToString();

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
                if (cbDisciplina.SelectedValue == null) { MessageBox.Show("Selecione uma Disciplina!"); return; }
                if (cbProfessor.SelectedValue == null) { MessageBox.Show("Selecione um Professor!"); return; }
                if (string.IsNullOrWhiteSpace(txtSemestre.Text)) { MessageBox.Show("O semestre é obrigatório!"); return; }

                var service = new MatriculaService();

                var matricula = new Matricula
                {
                    IdAluno = Convert.ToInt32(cbAluno.SelectedValue),
                    IdDisciplina = Convert.ToInt32(cbDisciplina.SelectedValue),
                    IdProfessor = Convert.ToInt32(cbProfessor.SelectedValue),
                    Semestre = txtSemestre.Text
                };

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(matricula);
                    MessageBox.Show("Matrícula cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    matricula.Id = Convert.ToInt32(this.Tag);
                    service.Atualizar(matricula);
                    MessageBox.Show("Matrícula atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, selecione uma matrícula na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir esta matrícula?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    var service = new MatriculaService();
                    service.Excluir(id);

                    MessageBox.Show("Matricula excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new MatriculaService();
            dgvMatriculas.DataSource = service.ListarPorNomeAluno(txtPesquisar.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            MessageBox.Show("Lista atualizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMatriculas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //var form = new FormPrincipal();
            //form.ShowDialog();
        }

        private void FormMatriculas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
