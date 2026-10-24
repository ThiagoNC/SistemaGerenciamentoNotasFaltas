using EduSmart.Models;
using EduSmart.Services;
using EduSmart.Views;

namespace EduSmart
{
    public partial class FormLogin : Form
    {
        private readonly ProfessorService _professorService;

        public FormLogin()
        {
            InitializeComponent();
            _professorService = new ProfessorService(); // Instancia o serviço
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professorLogado = _professorService.Autenticar(txtEmail.Text, txtSenha.Text);

                //var formPrincipal = new FormPrincipal(professorLogado);
                //formPrincipal.Show();

                var formPrincipal = new FormFalta();
                formPrincipal.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lklEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, entre em contato com o Administrador do Sistema para solicitar a redefinição da sua senha.",
                    "Recuperação de Acesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult confirmacao = MessageBox.Show("Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
