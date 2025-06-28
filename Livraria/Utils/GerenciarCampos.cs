using System.Windows.Forms;
using Livraria.Utils;

namespace Livraria.Utils
{
    public class GerenciarCampos
    {
        private readonly ConfigurarCor aplicarCor = new ConfigurarCor();

        public void HabilitarCampos(params Control[] controles)
        {
            var (corBotao, corTexto) = ConfigurarCor.PaletaCores.ObterCores(ConfigurarCor.EstiloVisual.Ativo);

            foreach (var ctrl in controles)
            {
                ctrl.Enabled = true;

                if (ctrl is Button)
                    aplicarCor.RestaurarEstiloPersonalizado(corBotao, corTexto, ctrl);
            }
        }

        public void DesabilitarCampos(params Control[] controles)
        {
            var (corBotao, corTexto) = ConfigurarCor.PaletaCores.ObterCores(ConfigurarCor.EstiloVisual.Inativo);

            foreach (var ctrl in controles)
            {
                ctrl.Enabled = false;

                if (ctrl is Button)
                    aplicarCor.ForcarEstiloPorEnum(ConfigurarCor.EstiloVisual.Inativo, ctrl);
            }
        }
    }
}