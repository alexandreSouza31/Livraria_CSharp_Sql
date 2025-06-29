using Livraria.Dados;
using Livraria.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                btnSalvar, btnAlterar, btnDesativar, btnCancelar);

            DicaInterativa.Aplicar(btnDesativar, "Clique aqui para desativar o funcionário (ação reversível)");
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var validarInput = Validar.ValidarCampos(
                new TextBox[] { inputNome, inputLogin, inputSenha },
                new string[] { "Nome", "Login", "Senha" }
            );

            bool status = radioBtnAtivo.Checked;

            if (!validarInput) return;

            try
            {
                gerenciarDados.Cadastrar(inputNome.Text, inputLogin.Text, inputSenha.Text,status);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                limpar.LimparCampos(inputNome, inputLogin, inputSenha);
                radioBtnAtivo.Checked = true;
                inputNome.Focus();
                AtualizarPesquisa();
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
                btnSalvar, btnAlterar, btnDesativar, btnCancelar);

            gerenciarCampos.DesabilitarCampos(btnDesativar, btnSalvar);

            var validarInput = Validar.ValidarCampos(
                new TextBox[] { inputNome, inputLogin, inputSenha },
                new string[] { "Nome", "Login", "Senha" }
            );

            if (!validarInput) return;

            try
            {
                int codigo = Convert.ToInt32(inputCodigoDB.Text);
                gerenciarDados.Editar(codigo, inputNome.Text, inputLogin.Text, inputSenha.Text, radioBtnAtivo.Checked);
                MessageBox.Show("Funcionário editado com sucesso!");
                limpar.LimparCampos(inputNome, inputLogin, inputSenha,inputCodigoDB,inputPesquisarFuncionario);
                radioBtnAtivo.Checked = true;
                gerenciarCampos.HabilitarCampos(btnNovo);
                gerenciarCampos.DesabilitarCampos(btnAlterar);
                AtualizarPesquisa();
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
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var validarInput = Validar.ValidarCampos(
                new TextBox[] { inputNome, inputLogin, inputSenha },
                new string[] { "Nome", "Login", "Senha" }
            );

            if (!validarInput) return;
            if (radioBtnAtivo.Checked)
            {
                MessageBox.Show($"O botão Status deve estar Inativo para Desativar!", "Erro ao Desativar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var desejaDesativar = DesejaManipular.ConfirmarAcao("Desativar");

                if (desejaDesativar == DialogResult.No) return;

                try
                {
                    int codigo = Convert.ToInt32(inputCodigoDB.Text);
                    gerenciarDados.DesativarUsuario(codigo);
                    MessageBox.Show("Funcionário desativado com sucesso!");
                    gerenciarCampos.DesabilitarCampos(
                        inputNome, inputLogin, inputSenha,
                        labelNome, labelLogin, labelSenha, labelCodigo,
                        btnSalvar, btnAlterar, btnDesativar, btnCancelar);

                    gerenciarCampos.HabilitarCampos(btnNovo);
                    limpar.LimparCampos(inputNome, inputLogin, inputSenha,inputCodigoDB);
                    radioBtnAtivo.Checked = true;
                    radioBtnInativo.Checked = false;
                    AtualizarPesquisa();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro ao Desativar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gerenciarCampos.DesabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnDesativar, btnCancelar);

            gerenciarCampos.HabilitarCampos(btnNovo);
            limpar.LimparCampos(inputNome, inputLogin, inputSenha);
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

            if (radioBtnAtivo.Checked) gerenciarCampos.HabilitarCampos(btnDesativar);
            else gerenciarCampos.DesabilitarCampos(btnDesativar);
        }
        private void labelSenha_MouseDown(object sender, MouseEventArgs e)
        {
            inputSenha.UseSystemPasswordChar = false;
        }
        private void labelSenha_MouseUp(object sender, MouseEventArgs e)
        {
            inputSenha.UseSystemPasswordChar = true;
        }

        private void CarregarFuncionario()
        {
            inputCodigoDB.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[0].Value.ToString();
            inputLogin.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[1].Value.ToString();
            inputSenha.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[2].Value.ToString();
            inputNome.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[3].Value.ToString();

            bool btnAtivo = Convert.ToBoolean(dgvRetornoPesquisa.SelectedRows[0].Cells[4].Value);
            radioBtnAtivo.Checked = btnAtivo;
            radioBtnInativo.Checked = !btnAtivo;

            gerenciarCampos.DesabilitarCampos(btnSalvar);
            gerenciarCampos.HabilitarCampos(
                inputNome, inputLogin, inputSenha, inputCodigoDB,
                btnAlterar, btnDesativar, btnCancelar,
                labelNome, labelLogin, labelSenha, labelCodigo
            );

            labelCodigo.Visible = true;
            inputCodigoDB.Visible = true;
        }
        private void Cancelar()
        {
            gerenciarCampos.DesabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnDesativar, btnCancelar);

            gerenciarCampos.HabilitarCampos(btnNovo);
            limpar.LimparCampos(inputNome, inputLogin, inputSenha, inputCodigoDB);
            radioBtnAtivo.Checked = true;
        }
        private void AtualizarPesquisa()
        {
            inputPesquisarFuncionario_TextChanged(null!, null!);
        }
    }
}