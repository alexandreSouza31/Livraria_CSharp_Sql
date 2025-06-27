using Livraria.Utils;
using Microsoft.Data.SqlClient;

namespace Livraria
{
    public partial class Login : Form
    {

        AplicarCor aplicarCor = new AplicarCor();
        public Login()
        {
            InitializeComponent();

            btnEntrar.Enabled = false;
            aplicarCor.AplicarCorDesabilitada(btnEntrar);
            btnSenhaVisivel.Visible = false;

            inputSenha.UseSystemPasswordChar = true;
        }

        //conexão
        SqlConnection cn = new SqlConnection(@"Data Source=ALIENWARE-17-R4\SQLEXPRESS;Initial Catalog=db_Livraria;Integrated Security=SSPI;Encrypt=False;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            inputLogin.Focus();
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

            if (!habilitar) aplicarCor.RestaurarEstiloPersonalizado(Color.Empty, Color.Empty, btnEntrar);
            else aplicarCor.RestaurarEstiloPersonalizado(Color.Empty, Color.Empty, btnEntrar);
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm.CommandText = "SELECT * FROM tbl_atendente WHERE ds_Login=@login AND ds_Senha=@senha";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@login", inputLogin.Text);
                cm.Parameters.AddWithValue("@senha", inputSenha.Text);
                cm.Connection = cn;
                dt = cm.ExecuteReader();

                if (dt.HasRows)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputLogin.Clear();
                    inputSenha.Clear();
                    inputLogin.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        private void btnSairApp_Click_1(object sender, EventArgs e)
        {
            var resultado = DesejaSair.Confirmar();

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
