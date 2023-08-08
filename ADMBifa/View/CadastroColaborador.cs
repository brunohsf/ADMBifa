using ADMBifa.Enums;
using ADMBifa.Models;
using ADMBifa.Repositories;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADMBifa.View
{
    public partial class CadastroColaborador : Form
    {
        public CadastroColaborador()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var colaborador = new Colaborador(txtCodigoColaborador.Text, txtNome.Text, txtDataContratacao.Value, (int)txtLimite.Value, (ENivel)cmbNivel.SelectedIndex, ckAtivo.Checked);

            var repository = new Repository<Colaborador>();

            if (colaborador.CodigoColaborador == 0)
                repository.Create(colaborador);
            else
                repository.Update(colaborador);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
