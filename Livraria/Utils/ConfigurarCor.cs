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

        public void AplicarCorDesabilitada(params Button[] botoes)
        {
            var (corBotaoDesabilitado, corTextoDesabilitado) = PaletaCores.ObterCores(EstiloVisual.Inativo);

            foreach (var botao in botoes)
            {
                if (!botao.Enabled)
                {
                    botao.BackColor = corBotaoDesabilitado;
                    botao.ForeColor = corTextoDesabilitado;
                }
            }
        }

        public void RestaurarEstiloPersonalizado(Color corBotaoHabilitado, Color corTextoHabilitado, params Button[] botoes)
        {
            if (corBotaoHabilitado.IsEmpty && corTextoHabilitado.IsEmpty)
            {
                (corBotaoHabilitado, corTextoHabilitado) = PaletaCores.ObterCores(EstiloVisual.Ativo);
            }

            foreach (var botao in botoes)
            {
                if (botao.Enabled)
                {
                    botao.BackColor = corBotaoHabilitado;
                    botao.ForeColor = corTextoHabilitado;
                }
            }
        }

        public void ForcarEstiloPorEnum(EstiloVisual estilo, params Button[] botoes)
        {
            var (corBotao, corTexto) = PaletaCores.ObterCores(estilo);

            foreach (var botao in botoes)
            {
                botao.BackColor = corBotao;
                botao.ForeColor = corTexto;
            }
        }
    }
}