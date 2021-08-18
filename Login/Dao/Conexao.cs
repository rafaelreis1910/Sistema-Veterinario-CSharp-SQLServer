using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Dal
{
    public class Conexao
    {
        SqlConnection cone = new SqlConnection();
        public Conexao()
            {
            cone.ConnectionString = @"Data Source=DESKTOP-488OEO7;Initial Catalog=login;Integrated Security=True";
            }
    public SqlConnection Conectar()
    {
        if (cone.State == System.Data.ConnectionState.Closed)
        {
            cone.Open();
        }
        return cone;
    }
    public void Desconectar ()
    {
        if (cone.State == System.Data.ConnectionState.Open)
        {
            cone.Close();
        }
    }
    }
}
