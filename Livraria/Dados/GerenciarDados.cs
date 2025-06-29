using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Livraria.Dados
{
    class GerenciarDados
    {
        private readonly SqlConnection cn = new SqlConnection(@"Data Source=ALIENWARE-17-R4\SQLEXPRESS;Initial Catalog=db_Livraria;Integrated Security=SSPI;Encrypt=False;TrustServerCertificate=True");
        private readonly SqlCommand cm = new SqlCommand();

        public void Cadastrar(string nome, string login, string senha, bool status)
        {
            string sql = "INSERT INTO tbl_funcionario (nm_funcionario, ds_login, ds_senha, ds_status) VALUES (@nome, @login, @senha, @status)";
            cm.Parameters.Clear();
            ExecutarComando(sql, nome, login, senha, status);
        }

        public void Editar(int codigo, string nome, string login, string senha, bool status)
        {
            string sql = "UPDATE tbl_funcionario SET nm_funcionario=@nome, ds_login=@login, ds_senha=@senha, ds_status=@status WHERE cd_funcionario=@cod";
            cm.Parameters.Clear();
            cm.Parameters.Add("@cod", SqlDbType.Int).Value = codigo;

            ExecutarComando(sql, nome, login, senha, status, codigo);
        }
        public void RemoverUsuarioAtivo(int codigo)
        {
            string sql = "UPDATE tbl_funcionario SET ds_status=0 WHERE cd_funcionario=@cod";

            cm.Parameters.Clear();
            cm.Parameters.Add("@cod", SqlDbType.Int).Value = codigo;
            ExecutarComando(sql, codigo: codigo);
        }

        private void ExecutarComando(string sql, string nome = null, string login = null, string senha = null, bool? status = null, int? codigo = null)
        {
            cm.Parameters.Clear();

            if (sql.Contains("@nome") && nome != null)
                cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;

            if (sql.Contains("@login") && login != null)
                cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;

            if (sql.Contains("@senha") && senha != null)
                cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;

            if (sql.Contains("@status") && status.HasValue)
                cm.Parameters.Add("@status", SqlDbType.Bit).Value = status.Value;

            if (sql.Contains("@cod") && codigo.HasValue)
                cm.Parameters.Add("@cod", SqlDbType.Int).Value = codigo.Value;

            cm.CommandText = sql;
            cm.Connection = cn;

            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            finally
            {
                cm.Parameters.Clear();
                cn.Close();
            }
        }
    }
}
