using System;
using System.Windows.Forms;

namespace Livraria.Utils
{
    public static class DesejaSair
    {
        public static DialogResult Confirmar()
        {
            return MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Atenção!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
            );
        }
    }
}