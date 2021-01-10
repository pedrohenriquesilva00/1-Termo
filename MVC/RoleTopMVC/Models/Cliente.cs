using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public uint TiposUsuario {get; set;}
        public Cliente()
        {

        }

        public Cliente(string nome,string telefone, DateTime dataNascimento, string email, string senha)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.DataNascimento = dataNascimento;
            this.Email = email;
            this.Senha = senha;
        }
    }
}