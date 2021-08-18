using Login.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        

        public bool acessar(String login, String senha)
        {
            logindao LogindaoComandos = new logindao();
            tem = LogindaoComandos.verificarLogin(login, senha);
            if (!LogindaoComandos.mensagem.Equals(""))
            {
                this.mensagem = LogindaoComandos.mensagem;
            }
                return tem;
 }
  public String Cadastrar(String email,String senha,String ConfSenha)
    {
            logindao LogindaoComandos = new logindao();
            this.mensagem = LogindaoComandos.cadastrar(email, senha, ConfSenha);
            if(LogindaoComandos.tem)
            {
                this.tem = true;
            }
            return mensagem;
    }
  }
}
