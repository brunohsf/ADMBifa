using ADMBifa.Repositories;
using System;
using System.Windows.Forms;

namespace ADMBifa.View
{
    public partial class ListagemColaboradores : Form
    {
        ColaboradorRepository _repository = new ColaboradorRepository();

        public int CodigoColaborador { get; set; }

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

        private void dgvColaboradores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvColaboradores.Rows[e.RowIndex];

            CodigoColaborador = (int)row.Cells["CodigoColaborador"].Value;

            Close();
        }

        private void dgvColaboradores_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvColaboradores.Rows[e.RowIndex];

            CodigoColaborador = (int)row.Cells["CodigoColaborador"].Value;

            Close();
        }
    }
}
