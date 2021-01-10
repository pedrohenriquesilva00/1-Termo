using System;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {PrepararResgistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);
            return true;
        }

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = ExtrairValorDoCampo("nome", item);
                    cliente.TiposUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", item));
                    cliente.Email = ExtrairValorDoCampo("email", item);
                    cliente.Senha = ExtrairValorDoCampo("senha", item);

                    return cliente;
                }
            }
            return null;
        }
        private string PrepararResgistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TiposUsuario};nome={cliente.Nome};data_nascimento={cliente.DataNascimento};email={cliente.Email};senha={cliente.Senha};";
        }
    }
}