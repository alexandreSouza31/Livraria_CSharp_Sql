namespace Livraria.Utils
{
    class AplicarCor
    {
        public void AplicarCorDesabilitada(params Button[] botoes)
        {
            foreach (var botao in botoes)
            {
                if (!botao.Enabled)
                {
                    botao.BackColor = Color.LightGray;
                    botao.ForeColor = Color.White;
                }
            }
        }

        public void RestaurarEstiloPersonalizado(Color backColor, Color foreColor, params Button[] botoes)
        {
            if (backColor.IsEmpty)
            {
                backColor = SystemColors.GradientActiveCaption;
                foreColor = SystemColors.Highlight;
            }

            foreach (var botao in botoes)
            {
                if (botao.Enabled)
                {
                    botao.BackColor = backColor;
                    botao.ForeColor = foreColor;
                }
            }
        }
    }
}
