using Livraria.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace Livraria
{
    public partial class Funcionario : UserControl
    {
        Limpar limpar = new Limpar();
        ConfigurarCor aplicarCor = new ConfigurarCor();

        //conexão
        SqlConnection cn = new SqlConnection(@"Data Source=ALIENWARE-17-R4\SQLEXPRESS;Initial Catalog=db_Livraria;Integrated Security=SSPI;Encrypt=False;TrustServerCertificate=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        public Funcionario()
        {
            InitializeComponent();
            DesabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            inputNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            limpar.LimparCampos(inputNome, inputLogin, inputSenha);
        }

        public void DesabilitaCampos()
        {
            inputNome.Enabled = false;
            inputLogin.Enabled = false;
            inputSenha.Enabled = false;

            labelNome.Enabled = false;
            labelLogin.Enabled = false;
            labelSenha.Enabled = false;

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            btnCancelar.Enabled = false;

            var (corBotaoDesabilitado, corTextoDesabilitado) =
                ConfigurarCor.
                    PaletaCores.ObterCores(ConfigurarCor.EstiloVisual.Inativo);

            aplicarCor.ForcarEstiloPorEnum(
                ConfigurarCor.EstiloVisual.Inativo,
                    btnSalvar, btnAlterar, btnRemover, btnCancelar
            );

        }
        public void HabilitaCampos()
        {
            inputNome.Enabled = true;
            inputLogin.Enabled = true;
            inputSenha.Enabled = true;

            labelNome.Enabled = true;
            labelLogin.Enabled = true;
            labelSenha.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            var (corBotaoHabilitado, corTextoHabilitado) =
                ConfigurarCor.PaletaCores.
                    ObterCores(ConfigurarCor.EstiloVisual.Ativo);

            aplicarCor.RestaurarEstiloPersonalizado(
                corBotaoHabilitado, corTextoHabilitado,
                    btnSalvar, btnAlterar, btnRemover, btnCancelar
            );

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var validarInput = Validar.ValidarCampos(
                new TextBox[] { inputNome, inputLogin, inputSenha },
                new string[] { "Nome", "Login", "Senha" }
            );

            if (!validarInput) return;

            try
            {
                string nome = inputNome.Text;
                string login = inputLogin.Text;
                string senha = inputSenha.Text;


                string sqlInsert = $"INSERT INTO tbl_funcionario" +
                    $"(nm_funcionario,ds_login,ds_senha) " +
                    $"VALUES (@nome,@login,@senha)";

                cm.CommandText = sqlInsert;
                cm.Connection = cn;

                cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;

                cn.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show($"Funcionário(a) \"{nome}\" cadastrado(a) com sucesso!", "Cadastrado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar.LimparCampos(inputNome, inputLogin, inputSenha);
                inputNome.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cn.Close();
            }
            finally
            {
                cn.Close();
            }
        }                                           
                                                    
        private void labelSenha_Click(object sender, EventArgs e)
        {

        }
        private void labelSenha_MouseDown(object sender, MouseEventArgs e)
        {
            inputSenha.UseSystemPasswordChar = false;
        }

        private void labelSenha_MouseUp(object sender, MouseEventArgs e)
        {
            inputSenha.UseSystemPasswordChar = true;
        }
    }
}
