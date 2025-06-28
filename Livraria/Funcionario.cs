using Livraria.Dados;
using Livraria.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Funcionario : UserControl
    {
        private readonly Limpar limpar = new Limpar();
        private readonly ConfigurarCor aplicarCor = new ConfigurarCor();
        private readonly GerenciarCampos gerenciarCampos = new GerenciarCampos();
        private readonly GerenciarDados gerenciarDados = new GerenciarDados();

        private readonly SqlConnection cn = new SqlConnection(@"Data Source=ALIENWARE-17-R4\SQLEXPRESS;Initial Catalog=db_Livraria;Integrated Security=SSPI;Encrypt=False;TrustServerCertificate=True");
        private readonly SqlCommand cm = new SqlCommand();

        public Funcionario()
        {
            InitializeComponent();

            gerenciarCampos.DesabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnRemover, btnCancelar);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cancelar();

            gerenciarCampos.HabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnCancelar);

            gerenciarCampos.DesabilitarCampos(btnAlterar);

            inputNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gerenciarCampos.DesabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnRemover, btnCancelar);

            gerenciarCampos.HabilitarCampos(btnNovo);
            limpar.LimparCampos(inputNome, inputLogin, inputSenha);
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
                gerenciarDados.Cadastrar(inputNome.Text, inputLogin.Text, inputSenha.Text);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                limpar.LimparCampos(inputNome, inputLogin, inputSenha);
                inputNome.Focus();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gerenciarCampos.HabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnRemover, btnCancelar);

            gerenciarCampos.DesabilitarCampos(btnRemover,btnSalvar);

            var validarInput = Validar.ValidarCampos(
                new TextBox[] { inputNome, inputLogin, inputSenha },
                new string[] { "Nome", "Login", "Senha" }
            );

            if (!validarInput) return;

            try
            {
                int codigo = Convert.ToInt32(inputCodigoDB.Text);
                gerenciarDados.Editar(codigo, inputNome.Text, inputLogin.Text, inputSenha.Text);
                MessageBox.Show("Funcionário editado com sucesso!");
                limpar.LimparCampos(inputNome, inputLogin, inputSenha);
                inputCodigoDB.Text = "";
                inputPesquisarFuncionario.Text = "";
                gerenciarCampos.HabilitarCampos(btnNovo);
                gerenciarCampos.DesabilitarCampos(btnAlterar);
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

        private void inputPesquisarFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputPesquisarFuncionario.Text))
            {
                try
                {
                    cn.Open();

                    string sql = "SELECT * FROM tbl_funcionario WHERE nm_funcionario LIKE @nome";
                    cm.CommandText = sql;
                    cm.Parameters.Clear();
                    cm.Parameters.AddWithValue("@nome", $"%{inputPesquisarFuncionario.Text}%");
                    cm.Connection = cn;

                    SqlDataAdapter adapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRetornoPesquisa.DataSource = dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show($"Erro ao pesquisar funcionário:\n{erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                dgvRetornoPesquisa.DataSource = null;
            }
        }

        private void dgvRetornoPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarFuncionario();
        }

        private void CarregarFuncionario()
        {
            inputCodigoDB.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[0].Value.ToString();
            inputLogin.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[1].Value.ToString();
            inputSenha.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[2].Value.ToString();
            inputNome.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[3].Value.ToString();

            gerenciarCampos.DesabilitarCampos(btnSalvar);
            gerenciarCampos.HabilitarCampos(
                inputNome, inputLogin, inputSenha, inputCodigoDB,
                btnAlterar, btnRemover, btnCancelar,
                labelNome, labelLogin, labelSenha, labelCodigo);

            labelCodigo.Visible = true;
            inputCodigoDB.Visible = true;
        }

        private void Cancelar()
        {
            gerenciarCampos.DesabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnRemover, btnCancelar);

            gerenciarCampos.HabilitarCampos(btnNovo);
            limpar.LimparCampos(inputNome, inputLogin, inputSenha);
            inputCodigoDB.Text = "";
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