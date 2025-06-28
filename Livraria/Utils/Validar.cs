using System.ComponentModel.Design;

namespace Livraria.Utils
{
    public class Validar
    {
        public static bool ValidarCampos(TextBox[] valorCampos, string[] nomesCampos)
        {
            for (int i = 0; i < valorCampos.Length; i++)
            {
                var campo = valorCampos[i];
                var nome = nomesCampos.Length > i ? nomesCampos[i].ToLower() : campo.Name;

                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    MessageBox.Show($"O campo \"{nome}\" é obrigatório!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    campo.Focus();
                    return false;
                }
                else if (nome == "senha" && campo.Text.Length < 6)
                {
                    MessageBox.Show($"O campo \"{nome}\" deve ter entre 6 e 8 caracteres!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    campo.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}