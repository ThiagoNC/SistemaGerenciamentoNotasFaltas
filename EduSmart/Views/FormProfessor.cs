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
    public partial class FormProfessor : Form
    {
        public FormProfessor()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new ProfessorService();

                var listaProfessores = service.ListarTodos().OrderBy(b => b.Nome).ToList();

                dgvProfessores.DataSource = listaProfessores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de professores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            foreach (DataGridViewColumn coluna in dgvProfessores.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvProfessores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvProfessors.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void pcOlho_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void dgvProfessors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProfessores.Rows[e.RowIndex];

                string idSelecionado = row.Cells["id"].Value.ToString();

                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtSenha.Text = row.Cells["senhaHash"].Value.ToString();
                //dtpDtNascimento.Value = Convert.ToDateTime(row.Cells["dataNascimento"].Value);

                this.Tag = idSelecionado;
            }
        }

        private void Novo()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            //dtpDtNascimento.Value = DateTime.Now;
            this.Tag = null;
            txtNome.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new ProfessorService();

            dgvProfessores.DataSource = service.ListarPorNome(txtPesquisar.Text).OrderBy(b => b.Nome).ToList();
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

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("O e-mail é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("O senha é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var service = new ProfessorService();

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(new Professor { Nome = txtNome.Text, Email = txtEmail.Text, SenhaHash = txtSenha.Text, });
                    MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int id = Convert.ToInt32(this.Tag);
                    service.Atualizar(new Professor { Id = id, Nome = txtNome.Text, Email = txtEmail.Text, SenhaHash = txtSenha.Text, });
                    MessageBox.Show("Professor atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, selecione um professor na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este professor?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    ProfessorService service = new ProfessorService();
                    service.Excluir(id);

                    MessageBox.Show("Professor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();

                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: Professor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormProfessor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            //var form = new FormPrincipal();
            //form.ShowDialog();
        }

        private void FormProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
