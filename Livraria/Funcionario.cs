using Livraria.Dados;
using Livraria.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Livraria
{
    public partial class Funcionario : UserControl
    {
        private readonly Limpar limpar = new Limpar();
        private readonly ConfigurarCor aplicarCor = new ConfigurarCor();
        private readonly GerenciarCampos gerenciarCampos = new GerenciarCampos();
        private readonly GerenciarDados gerenciarDados = new GerenciarDados();
        private readonly Conexao conexao = new Conexao();

        public Funcionario()
        {
            InitializeComponent();

            gerenciarCampos.DesabilitarCampos(
                inputNome, inputLogin, inputSenha,
                labelNome, labelLogin, labelSenha,
                btnSalvar, btnAlterar, btnDesativar, btnCancelar);

            Interagir.AplicarAlerta(btnDesativar, "Clique aqui para desativar o funcionário (ação reversível)");
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

            if (radioBtnInativo.Checked)
            {
                MessageBox.Show($"Não é possível cadastrar funcionário com status 'inativo'!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                gerenciarDados.Cadastrar(inputNome.Text, inputLogin.Text, inputSenha.Text, status);
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
                conexao.FecharConexao();
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

            if (radioBtnInativo.Checked) gerenciarCampos.DesabilitarCampos(btnAlterar);

            try
            {
                int codigo = Convert.ToInt32(inputCodigoDB.Text);
                gerenciarDados.Editar(codigo, inputNome.Text, inputLogin.Text, inputSenha.Text, radioBtnAtivo.Checked);
                MessageBox.Show("Funcionário editado com sucesso!");
                limpar.LimparCampos(inputNome, inputLogin, inputSenha, inputCodigoDB, inputPesquisarFuncionario);
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
                conexao.FecharConexao();
            }
        }
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var validarInput = Validar.ValidarCampos(
                new TextBox[] { inputNome, inputLogin, inputSenha },
                new string[] { "Nome", "Login", "Senha" }
            );

            if (!validarInput) return;

            if (radioBtnAtivo.Checked) gerenciarCampos.DesabilitarCampos(btnDesativar);

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
                    limpar.LimparCampos(inputNome, inputLogin, inputSenha, inputCodigoDB);
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
                    conexao.AbrirConexao();

                    string sql = "SELECT cd_funcionario, ds_login, nm_funcionario, ds_status FROM tbl_funcionario WHERE nm_funcionario LIKE @nome";
                    var cmd = conexao.Comando();
                    cmd.CommandText = sql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nome", $"%{inputPesquisarFuncionario.Text}%");
                    cmd.Connection = conexao.AbrirConexao();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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
                    conexao.FecharConexao();
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
            if (dgvRetornoPesquisa.SelectedRows.Count == 0) return;

            try
            {
                inputCodigoDB.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[0].Value.ToString();
                inputLogin.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[1].Value.ToString();
                inputNome.Text = dgvRetornoPesquisa.SelectedRows[0].Cells[2].Value.ToString();
                conexao.AbrirConexao();

                int idFuncionario = int.Parse(inputCodigoDB.Text);

                var cmd = conexao.Comando();
                cmd.CommandText = "SELECT ds_senha FROM tbl_funcionario WHERE cd_funcionario = @cod";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", idFuncionario);

                var senha = cmd.ExecuteScalar()?.ToString();
                inputSenha.Text = senha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar senha: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }

            bool btnAtivo = Convert.ToBoolean(dgvRetornoPesquisa.SelectedRows[0].Cells[3].Value);
            radioBtnAtivo.Checked = btnAtivo;
            radioBtnInativo.Checked = !btnAtivo;

            gerenciarCampos.DesabilitarCampos(btnSalvar);
            gerenciarCampos.HabilitarCampos(
                inputNome, inputLogin, inputSenha, inputCodigoDB,
                btnAlterar, btnCancelar,
                labelNome, labelLogin, labelSenha, labelCodigo
            );

            if(btnAtivo) gerenciarCampos.DesabilitarCampos(btnDesativar);

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

        private void radioBtnAtivo_CheckedChanged(object sender, EventArgs e)
        {
            gerenciarCampos.HabilitarCampos(btnAlterar);
            gerenciarCampos.DesabilitarCampos(btnDesativar);
        }

        private void radioBtnInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (inputNome.Text != "")
            {
                gerenciarCampos.HabilitarCampos(btnDesativar);
                gerenciarCampos.DesabilitarCampos(btnAlterar);
            }
        }
    }
}