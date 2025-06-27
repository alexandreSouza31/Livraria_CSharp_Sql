using Livraria.Utils;
using System;
using System.Collections.Generic;
namespace Livraria
{
    public partial class Funcionario : UserControl
    {
        Limpar limpar=new Limpar();
        ConfigurarCor aplicarCor = new ConfigurarCor();
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
            limpar.LimparCampos(inputNome, inputLogin, inputSenha);
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

            var (corBotaoDesabilitado, corTextoDesabilitado) =
                ConfigurarCor.
                    PaletaCores.ObterCores(ConfigurarCor.EstiloVisual.Inativo);

            aplicarCor.ForcarEstiloPorEnum(
                ConfigurarCor.EstiloVisual.Inativo,
                    btnSalvar, btnAlterar, btnRemover, btnCancelar
            );

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

            var (corBotaoHabilitado, corTextoHabilitado) =
                ConfigurarCor.PaletaCores.
                    ObterCores(ConfigurarCor.EstiloVisual.Ativo);

            aplicarCor.RestaurarEstiloPersonalizado(
                corBotaoHabilitado, corTextoHabilitado,
                    btnSalvar, btnAlterar, btnRemover, btnCancelar
            );

        }
    }
}
