using System.Drawing;
using System.Windows.Forms;

namespace Livraria.Utils
{
    public class ConfigurarCor
    {
        public enum EstiloVisual
        {
            Ativo,
            Inativo
        }

        public static class PaletaCores
        {
            public static readonly Color CorBotaoAtivo = SystemColors.Highlight;
            public static readonly Color CorTextoAtivo = SystemColors.GradientActiveCaption;

            public static readonly Color CorBotaoInativo = Color.LightGray;
            public static readonly Color CorTextoInativo = Color.White;

            public static (Color corBotao, Color corTexto) ObterCores(EstiloVisual estilo)
            {
                return estilo switch
                {
                    EstiloVisual.Ativo => (CorBotaoAtivo, CorTextoAtivo),
                    EstiloVisual.Inativo => (CorBotaoInativo, CorTextoInativo),
                    _ => (SystemColors.Control, SystemColors.ControlText)
                };
            }
        }

        public void RestaurarEstiloPersonalizado(Color corBotao, Color corTexto, params Control[] controles)
        {
            if (corBotao.IsEmpty && corTexto.IsEmpty)
                (corBotao, corTexto) = PaletaCores.ObterCores(EstiloVisual.Ativo);

            foreach (var ctrl in controles)
                if (ctrl.Enabled)
                {
                    ctrl.BackColor = corBotao;
                    ctrl.ForeColor = corTexto;
                }
        }

        public void ForcarEstiloPorEnum(EstiloVisual estilo, params Control[] controles)
        {
            var (corBotao, corTexto) = PaletaCores.ObterCores(estilo);

            foreach (var ctrl in controles)
            {
                ctrl.BackColor = corBotao;
                ctrl.ForeColor = corTexto;
            }
        }
    }
}