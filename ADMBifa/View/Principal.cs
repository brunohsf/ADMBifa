using ADMBifa.View;
using System;
using System.Windows.Forms;

namespace ADMBifa
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastarColaborador_Click(object sender, EventArgs e)
        {
            var cadastroColaborador = new CadastroColaborador();
            cadastroColaborador.ShowDialog();
        }
    }
}
