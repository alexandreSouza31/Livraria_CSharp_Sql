using Livraria.Utils;
using System;
using System.Collections.Generic;
namespace Livraria
{
    public partial class Funcionario : UserControl
    {
        AplicarCor aplicarCor = new AplicarCor();
        public Funcionario()
        {
            InitializeComponent();
            DesabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            inputNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }

        public void DesabilitaCampos()
        {
            inputNome.Enabled = false;
            inputLogin.Enabled = false;
            inputSenha.Enabled = false;

            labelNome.Enabled = false;
            labelLogin.Enabled = false;
            labelSenha.Enabled = false;

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            btnCancelar.Enabled = false;

            aplicarCor.AplicarCorDesabilitada(btnSalvar, btnAlterar, btnRemover, btnCancelar);
        }
        public void HabilitaCampos()
        {
            inputNome.Enabled = true;
            inputLogin.Enabled = true;
            inputSenha.Enabled = true;

            labelNome.Enabled = true;
            labelLogin.Enabled = true;
            labelSenha.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            aplicarCor.RestaurarEstiloPersonalizado(
                SystemColors.GradientActiveCaption, SystemColors.Highlight,
                btnSalvar, btnAlterar, btnRemover, btnCancelar
                );
        }
    }
}
