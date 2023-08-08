using ADMBifa.Models;
using ADMBifa.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMBifa.View
{
    public partial class ListagemColaboradores : Form
    {
        ColaboradorRepository _repository = new ColaboradorRepository();

        public ListagemColaboradores()
        {
            InitializeComponent();
            ListarColaboradores(txtBusca.Text);
        }

        public void ListarColaboradores(string busca)
        {

            var colaboradores = _repository.ListarColaboradores(busca);

            dgvColaboradores.DataSource = colaboradores;

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ListarColaboradores(txtBusca.Text);
        }
    }
}
