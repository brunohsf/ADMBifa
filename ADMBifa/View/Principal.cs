﻿using ADMBifa.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
