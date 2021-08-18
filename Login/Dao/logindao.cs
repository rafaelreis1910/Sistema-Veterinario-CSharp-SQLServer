using Login.Dal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Dao
{
    class logindao
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand comand = new SqlCommand();
        Conexao cone = new Conexao();
        SqlDataReader datareader;
         public bool verificarLogin(String login, String senha)
        { 
            // sql para verificação no banco
            comand.CommandText = "select * from testelogin where email = @login and senha = @senha";
            comand.Parameters.AddWithValue("@login",login);
             comand.Parameters.AddWithValue("@senha",senha);

            try
            {

                comand.Connection = cone.Conectar();
                datareader = comand.ExecuteReader();
                if (datareader.HasRows)
                {
                    tem = true;
                }
                cone.Desconectar();
                datareader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o DataBase!";
            }

            return tem;
    }
  
        
        
        public String cadastrar (String email, String Senha,String ConfSenha)
        {
            tem = false;
            // comandos para inserir
            if (Senha.Equals(ConfSenha))
            {
                comand.CommandText = "insert into testelogin values (@em,@se);";
                comand.Parameters.AddWithValue("@em", email);
                comand.Parameters.AddWithValue("@se", Senha);
                try
                {
                    comand.Connection = cone.Conectar();
                    comand.ExecuteNonQuery();
                    cone.Desconectar();
                    this.mensagem = "Cadastro efetuado!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o database";
                }
            }
            else
            {
                this.mensagem = "Senhas incorreta";

            }
            return mensagem;
        }
    

  }
}
