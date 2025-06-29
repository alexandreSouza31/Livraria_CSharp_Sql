using Livraria.Utils;

namespace Livraria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resultado = DesejaManipular.ConfirmarAcao("Sair");

            if (resultado == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Interagir.AplicarTextoLimitado(labelNomeFuncionario, Login.funcionarioLogado);
        }
    }
}
