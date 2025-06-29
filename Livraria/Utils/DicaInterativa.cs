namespace Livraria.Utils
{
    public class DicaInterativa
    {
        private static ToolTip _tooltip = new ToolTip()
        {
            AutoPopDelay = 5000,
            InitialDelay = 200,
            ReshowDelay = 100,
            IsBalloon = true,
            ToolTipTitle = "Atenção",
            ToolTipIcon = ToolTipIcon.Info
        };

        public static void Aplicar(Control controle, string texto)
        {
            _tooltip.SetToolTip(controle, texto);
        }

    }
}
