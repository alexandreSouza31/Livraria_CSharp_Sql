using MySql.Data.MySqlClient;

public class Conexao
{
    private readonly MySqlConnection cn = new MySqlConnection(
        "Server=127.0.0.1;Database=db_livraria;Uid=root;Pwd=ac123;"
    );

    private readonly MySqlCommand cm = new MySqlCommand();

    public MySqlConnection AbrirConexao()
    {
        if (cn.State == System.Data.ConnectionState.Closed)
            cn.Open();

        return cn;
    }

    public void FecharConexao()
    {
        if (cn.State == System.Data.ConnectionState.Open)
            cn.Close();
    }

    public MySqlCommand Comando()
    {
        cm.Connection = cn;
        return cm;
    }
}