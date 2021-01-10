using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine("Nubank - Cadastro de Clientes");
            Console.ResetColor();
            System.Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocouSenha = false;
            do{
                System.Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if(trocouSenha){
                    System.Console.WriteLine("Senha alterada com sucesso!");
                } else{
                    System.Console.WriteLine("Senha inválida");
                }
            }while(!trocouSenha); 
            System.Console.WriteLine();
            Console.Clear();

            System.Console.WriteLine("ByteBank - Cadastro da Conta");
            System.Console.Write("Entre com a Agência: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com a Conta: ");
            int conta  = int.Parse(Console.ReadLine());

            ContaCorrente contaCorrente1 = new ContaCorrente(agencia, conta, cliente1);
            double saldo;
            bool depositou = true;

            do{
                Console.Write("Entre com o Saldo: ");
                saldo = double.Parse(Console.ReadLine());
                depositou = contaCorrente1.Deposito(saldo);
                if(!depositou) {
                    System.Console.WriteLine("Valor do saldo deve ser positivo.");
                }
            } while (!depositou);
            System.Console.WriteLine();

            Cliente cliente2 = new Cliente ("César", "123.123.123-12", "1@A.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123, 312, cliente2);

            Cliente usuario = contaCorrente1.Titular;
            System.Console.WriteLine("ByteBank = Depósito em conta");
            System.Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.Deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Saque: ");
            valor = double.Parse(Console.ReadLine());
            bool Saque = contaCorrente1.Saque(valor);
            if(Saque){
                System.Console.WriteLine("Valor sacado com sucesso!!");
            } else {
                System.Console.WriteLine("Valor inválido!");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor da Transferência: ");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente1.Transferencia(contaCorrente2,valor)){
                System.Console.WriteLine("Transferência Efetuada.");
            } else {
                System.Console.WriteLine("Não foi possível realizar a operação.");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo Origem: {contaCorrente1.Saldo}");
            System.Console.WriteLine($"Novo Saldo Destino: {contaCorrente2.Saldo}");
            System.Console.WriteLine();
        }
    }
}
