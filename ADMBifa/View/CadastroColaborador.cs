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
            Carregar(_repository.CarregarPrimeiroColaborador());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex < 1)
            {
                MessageBox.Show("Informe qual o nível do colaborador!", "Atenção!");
                cmbNivel.Focus();
                return;
            }

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

        public void Carregar(Colaborador colaborador)
        {

            if (colaborador is null)
                return;

            txtCodigoColaborador.Text = colaborador.CodigoColaborador.ToString();
            txtNome.Text = colaborador.Nome;
            txtDataContratacao.Value = colaborador.DataContratacao;
            cmbNivel.SelectedIndex = (int)colaborador.CodigoNivel;
            txtLimite.Value = colaborador.LimiteBifas;
            ckAtivo.Checked = colaborador.Ativo;

        }

        private void LimparCampos()
        {
            txtCodigoColaborador.Text = "";
            txtNome.Text = "";
            txtDataContratacao.Value = DateTime.Now;
            cmbNivel.SelectedIndex = 0;
            txtLimite.Value = 0;
            ckAtivo.Checked = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoColaborador.Text == "")
            {
                MessageBox.Show("Informe um colaborador para mandá-lo de Clibas!", "Atenção!");
                return;
            }

            var colaborador = new Colaborador(int.Parse(txtCodigoColaborador.Text), txtNome.Text, txtDataContratacao.Value, (int)txtLimite.Value, (ENivel)cmbNivel.SelectedIndex, ckAtivo.Checked);

            if (MessageBox.Show("Deseja realmente mandar esse colaborador de Clibas?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(colaborador);
                LimparCampos();
                Carregar(_repository.CarregarPrimeiroColaborador());
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var listagemColaboradores = new ListagemColaboradores();
            listagemColaboradores.ShowDialog();
            Carregar(_repository.Get(listagemColaboradores.CodigoColaborador));
        }
    }
}
