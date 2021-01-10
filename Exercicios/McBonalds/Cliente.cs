using System;

namespace McBonalds
{
    public class Cliente
    {
        //Propriedades
       public string Nome; //Nome dp cliente
       public string Endereço;  //Endereço do cliente
       public string Telefone; //Telefone do cliente
       public string Senha; //Senha de acesso do cliente ao sistema
       public string Email; //Email do cliente e nome de usuário do sistema
       public DateTime DataNascimento; //Data de nascimento do cliente

       //Construtor
       public Cliente(string Nome, string Telefone, string Email){
           this.Nome = Nome;
           this.Telefone = Telefone;
           this.Email = Email;
       }
    }
}