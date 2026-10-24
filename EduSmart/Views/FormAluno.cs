using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EduSmart.Models;
using EduSmart.Services;

namespace EduSmart.Views
{
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new AlunoService();

                var listaAlunos = service.ListarTodos().OrderBy(b => b.Nome).ToList();

                dgvAlunos.DataSource = listaAlunos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            foreach (DataGridViewColumn coluna in dgvAlunos.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvAlunos.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAlunos.Rows[e.RowIndex];

                string idSelecionado = row.Cells["id"].Value.ToString();

                txtRa.Text = row.Cells["ra"].Value.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                //dtpDtNascimento.Value = Convert.ToDateTime(row.Cells["dataNascimento"].Value);

                this.Tag = idSelecionado;
            }
        }

        private void Novo()
        {
            txtRa.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            //dtpDtNascimento.Value = DateTime.Now;
            this.Tag = null;
            txtRa.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new AlunoService();

            dgvAlunos.DataSource = service.ListarPorNome(txtPesquisar.Text).OrderBy(b => b.Nome).ToList();
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
                if (string.IsNullOrWhiteSpace(txtRa.Text))
                {
                    MessageBox.Show("O ra é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("O e-mail é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var service = new AlunoService();

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(new Aluno { Ra = txtRa.Text, Nome = txtNome.Text, Email = txtEmail.Text });
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int id = Convert.ToInt32(this.Tag);
                    service.Atualizar(new Aluno { Id = id, Ra = txtRa.Text, Nome = txtNome.Text, Email = txtEmail.Text });
                    MessageBox.Show("Aluno atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, selecione um aluno na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este aluno?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    AlunoService service = new AlunoService();
                    service.Excluir(id);

                    MessageBox.Show("Aluno excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();

                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: Aluno!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            //var form = new FormPrincipal();
            //form.ShowDialog();
        }

        private void FormAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
