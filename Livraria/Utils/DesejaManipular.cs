using System;
using System.Windows.Forms;

namespace Livraria.Utils
{
    public static class DesejaManipular
    {
        public static DialogResult ConfirmarAcao(string contexto)
        {
            return MessageBox.Show(
                $"Tem certeza que deseja {contexto}?",
                "Atenção!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
            );
        }
    }
}