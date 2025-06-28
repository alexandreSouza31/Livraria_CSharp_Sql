namespace Livraria.Utils
{
    class Limpar
    {
        public void LimparCampos(params Control[] controles)
        {
            foreach (var ctrl in controles)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is Label)
                {
                    ctrl.Text = "";
                }
            }
        }
    }
}
