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

        ColaboradorRepository _repository = new ColaboradorRepository();

        public CadastroColaborador()
        {
            InitializeComponent();
            Carregar();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigoColaborador.Text == "")
                txtCodigoColaborador.Text = "0";

            var colaborador = new Colaborador(int.Parse(txtCodigoColaborador.Text), txtNome.Text, txtDataContratacao.Value, (int)txtLimite.Value, (ENivel)cmbNivel.SelectedIndex, ckAtivo.Checked);


            if (colaborador.CodigoColaborador == 0)
                _repository.Create(colaborador);
            else
                _repository.Update(colaborador);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Carregar()
        {
            var colaborador = _repository.CarregarColaborador();

            txtCodigoColaborador.Text = colaborador.CodigoColaborador.ToString();
            txtNome.Text = colaborador.Nome;
            txtDataContratacao.Value = colaborador.DataContratacao;
            cmbNivel.SelectedIndex = (int)colaborador.CodigoNivel;
            txtLimite.Value = colaborador.LimiteBifas;
            ckAtivo.Checked = colaborador.Ativo;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigoColaborador.Text = "";
            txtNome.Text = "";
            txtDataContratacao.Value = DateTime.Now;
            cmbNivel.SelectedIndex = 0;
            txtLimite.Value = 0;
            ckAtivo.Checked = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoColaborador.Text == "")
            {
                MessageBox.Show("Informe um colaborador para mandá-lo de Clibas!", "Atenção!");
                return;
            }

            var colaborador = new Colaborador(int.Parse(txtCodigoColaborador.Text), txtNome.Text, txtDataContratacao.Value, (int)txtLimite.Value, (ENivel)cmbNivel.SelectedIndex, ckAtivo.Checked);

        }
    }
}
