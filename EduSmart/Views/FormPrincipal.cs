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
    public partial class FormPrincipal : Form
    {
        private readonly Professor _professorLogado;
        private readonly MatriculaService _matriculaService;

        public FormPrincipal(Professor professorLogado)
        {
            InitializeComponent();

            _professorLogado = professorLogado;

            _matriculaService = new MatriculaService();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //lblBoasVindas.Text = $"Bem-vindo(a), Prof. {_professorLogado.Nome}!";

            CarregarDashboard();
        }

        private void CarregarDashboard()
        {
            try
            {
                var matriculasDoProfessor = _matriculaService.ListarPorProfessor(_professorLogado.Id);

                //dgvDashboard.DataSource = matriculasDoProfessor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dashboard: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
