using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            btnEntrar.Enabled = false;
            btnEntrar.BackColor = Color.Gray;

            btnSenhaVisivel.Visible = false;

            inputSenha.UseSystemPasswordChar = true;
        }

        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            inputSenha.UseSystemPasswordChar = false;
            btnSenha.Visible = false;
            btnSenhaVisivel.Visible = true;
        }

        private void btnSenhaVisivel_Click(object sender, EventArgs e)
        {
            inputSenha.UseSystemPasswordChar = true;
            btnSenha.Visible = true;
            btnSenhaVisivel.Visible = false;
        }

        private void inputLogin_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void inputSenha_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            bool habilitar =
                !string.IsNullOrWhiteSpace(inputLogin.Text) &&
                !string.IsNullOrWhiteSpace(inputSenha.Text);

            btnEntrar.Enabled = habilitar;

            if (!habilitar)
            {
                btnEntrar.BackColor = Color.LightGray;
                btnEntrar.ForeColor = Color.White;
            }
            else
            {
                btnEntrar.BackColor = SystemColors.GradientActiveCaption;
                btnEntrar.ForeColor = Color.Black;
            }
        }
    }
}
