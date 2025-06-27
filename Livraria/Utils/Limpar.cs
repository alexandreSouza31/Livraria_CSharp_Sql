namespace Livraria.Utils
{
    class Limpar
    {
        public void LimparCampos(params TextBox[] campos)
        {
            foreach (var campo in campos)
            {
                campo.Clear();
            }
        }
    }
}
