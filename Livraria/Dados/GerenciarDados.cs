using MySql.Data.MySqlClient;

namespace Livraria.Dados
{
    class GerenciarDados
    {
        private readonly Conexao conexao = new Conexao();

        public void Cadastrar(string nome, string login, string senha, bool status)
        {
            string sql = "INSERT INTO tbl_funcionario (nm_funcionario, ds_login, ds_senha, ds_status) VALUES (@nome, @login, @senha, @status)";
            ExecutarComando(sql, nome, login, senha, status);
        }

        public void Editar(int codigo, string nome, string login, string senha, bool status)
        {
            string sql = @"UPDATE tbl_funcionario 
                           SET nm_funcionario = @nome, ds_login = @login, ds_senha = @senha, ds_status = @status 
                           WHERE cd_funcionario = @cod";
            ExecutarComando(sql, nome, login, senha, status, codigo);
        }

        public void DesativarUsuario(int codigo)
        {
            string sql = "UPDATE tbl_funcionario SET ds_status = 0 WHERE cd_funcionario = @cod";
            ExecutarComando(sql, codigo: codigo);
        }

        private void ExecutarComando(string sql, string nome = null, string login = null, string senha = null, bool? status = null, int? codigo = null)
        {
            var cmd = conexao.Comando();
            cmd.CommandText = sql;
            cmd.Parameters.Clear();

            if (sql.Contains("@nome") && nome != null)
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            if (sql.Contains("@login") && login != null)
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            if (sql.Contains("@senha") && senha != null)
                cmd.Parameters.Add("@senha", MySqlDbType.String).Value = senha;

            if (sql.Contains("@status") && status.HasValue)
                cmd.Parameters.Add("@status", MySqlDbType.Bit).Value = status.Value;

            if (sql.Contains("@cod") && codigo.HasValue)
                cmd.Parameters.Add("@cod", MySqlDbType.Int32).Value = codigo.Value;

            try
            {
                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharConexao();
            }
        }
    }
}