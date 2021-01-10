using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            Console.WriteLine("Calcula Àrea");
            Console.WriteLine("1 - Triangulo");
            Console.WriteLine("2 - Quadrado ");
            Console.WriteLine("3 - Losango");
            Console.WriteLine("4 - Trapezio");
            Console.WriteLine("5 - Retangulo");
            Console.WriteLine("6 - Circulo");
            Console.Write("Escolha uma opção: ");
            opcao = (Console.ReadLine());

            switch(opcao) {
                case "1":
                Console.WriteLine("Área do Triângulo");
                Console.WriteLine("Digite a Base: ");
                double baseTri = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a Altura: ");
                double altTri = double.Parse(Console.ReadLine());
                double areaTri = (baseTri * altTri) / 2;
                Console.WriteLine("A área do Triângulo é: " + areaTri);
                break;

                case "2":
                Console.WriteLine("Área do Quadrado");
                Console.WriteLine("Digite o lado: ");
                double ladoQuad = double.Parse(Console.ReadLine());
                double areaQuad = ladoQuad * ladoQuad;
                Console.WriteLine("A área do quadrado é: " + areaQuad);
                break;

                case "3":
                Console.WriteLine("Área do Losango");
                Console.WriteLine("Diagonal menor: ");
                double diamLos = double.Parse(Console.ReadLine());
                Console.WriteLine("Diagonal maior: ");
                double diaMLos = double.Parse(Console.ReadLine());
                double areaLos = (diamLos * diaMLos) /2;
                Console.WriteLine("A área do Losango é: " + areaLos);
                break;

                case "4":
                Console.WriteLine("Área do Trapézio");
                Console.WriteLine("Base menor: ");
                double basmTra = double.Parse(Console.ReadLine());
                Console.WriteLine("Base maior: ");
                double basMTra = double.Parse(Console.ReadLine());
                Console.WriteLine("Altura: ");
                double altTra = double.Parse(Console.ReadLine());
                double areaTra = (basmTra + basMTra) /2 * altTra;
                Console.WriteLine("A área do Trapézio é: " + areaTra);
                break;

                case "5":
                Console.WriteLine("Área do Retângulo");
                Console.WriteLine("Digite a base: ");
                double basRet = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura: ");
                double altRet = double.Parse(Console.ReadLine());
                double areaRet = (basRet * altRet);
                Console.WriteLine("A área do Retângulo é: " + areaRet);
                break;

                case "6":
                Console.WriteLine("Área do Círculo");
                Console.WriteLine("Digite o Raio: ");
                double raioC = double.Parse(Console.ReadLine());
                double areaC = (3.1415 * raioC ) * raioC;
                Console.WriteLine("a área do Círculo é: " + areaC );
                break; 
            }
        }
    }
}
