using Microsoft.Data.SqlClient;
using System.Data;

namespace Livraria.Dados
{
    class GerenciarDados
    {
        private readonly SqlConnection cn = new SqlConnection(@"Data Source=ALIENWARE-17-R4\SQLEXPRESS;Initial Catalog=db_Livraria;Integrated Security=SSPI;Encrypt=False;TrustServerCertificate=True");
        private readonly SqlCommand cm = new SqlCommand();

        public void Cadastrar(string nome, string login, string senha)
        {
            string sql = "INSERT INTO tbl_funcionario (nm_funcionario, ds_login, ds_senha) VALUES (@nome, @login, @senha)";
            ExecutarComando(sql, nome, login, senha);
        }

        public void Editar(int codigo, string nome, string login, string senha)
        {
            string sql = "UPDATE tbl_funcionario SET nm_funcionario=@nome, ds_login=@login, ds_senha=@senha WHERE cd_funcionario=@cod";
            cm.Parameters.Add("@cod", SqlDbType.Int).Value = codigo;
            ExecutarComando(sql, nome, login, senha);
        }

        private void ExecutarComando(string sql, string nome, string login, string senha)
        {
            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;

            try
            {
                cm.CommandText = sql;
                cm.Connection = cn;
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
