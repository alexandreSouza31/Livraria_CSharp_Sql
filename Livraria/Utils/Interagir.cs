using System.Windows.Forms;
using System.Drawing;

namespace Livraria.Utils
{
    public class Interagir
    {
        private static ToolTip _tooltipPadrao = new ToolTip()
        {
            AutoPopDelay = 5000,
            InitialDelay = 200,
            ReshowDelay = 100,
            IsBalloon = false
        };

        private static ToolTip _tooltipAlerta = new ToolTip()
        {
            AutoPopDelay = 5000,
            InitialDelay = 200,
            ReshowDelay = 100,
            IsBalloon = true,
            ToolTipTitle = "Atenção",
            ToolTipIcon = ToolTipIcon.Info
        };

        public static void AplicarAlerta(Control controle, string texto)
        {
            _tooltipAlerta.SetToolTip(controle, texto);
        }

        public static void AplicarInformativo(Control controle, string texto)
        {
            _tooltipPadrao.SetToolTip(controle, texto ?? string.Empty);
        }

        public static void AplicarTextoLimitado(Label lbl, string textoCompleto, int limiteCaracteres = 20)
        {
            if (string.IsNullOrEmpty(textoCompleto))
            {
                lbl.Text = string.Empty;
                _tooltipPadrao.SetToolTip(lbl, string.Empty);
                return;
            }

            lbl.AutoSize = false;
            lbl.AutoEllipsis = true;
            lbl.Width = 120;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Text = textoCompleto;
            _tooltipPadrao.SetToolTip(lbl, textoCompleto);
        }
    }
}
