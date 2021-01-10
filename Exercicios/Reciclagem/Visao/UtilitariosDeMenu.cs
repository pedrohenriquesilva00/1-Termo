using System;

namespace Reciclagem.View
{
    public class MenuUtils<T>
    {
        public static int ExibirMenuPadrao()
        {
            string[] itensMenu = Enum.GetNames(typeof(T));
            string barraMenu = "===================================";

            #region HEADER
            System.Console.WriteLine(barraMenu);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("          VAMOS RECICLAR?          ");
            Console.ResetColor();
            System.Console.WriteLine("         Digite sua opção:         ");
            System.Console.WriteLine(barraMenu);
            #endregion

            #region BODY
            string bordaLinha = "||";
            string separadorOpcao = " - ";
            for (int i = 0; i < itensMenu.Length; i++)
            {
                string espacosFim = "";
                string paragrafoInicio = "   ";

                string titulo = TratarTituloMenu(itensMenu[i]);
                int espacoDezena = i / 10;

                string numeroOpcao = (i + 1).ToString();

                if (espacoDezena < 1)
                {
                    paragrafoInicio = paragrafoInicio + " ";
                }

                int qntdeEspacos = barraMenu.Length - (bordaLinha.Length * 2) - paragrafoInicio.Length - numeroOpcao.Length - separadorOpcao.Length - titulo.Length;

                for (int j = 0; j < qntdeEspacos; j++)
                {
                    espacosFim += " ";
                }
                System.Console.WriteLine($"{bordaLinha}{paragrafoInicio}{numeroOpcao}{separadorOpcao}{titulo}{espacosFim}{bordaLinha}");

            }

            #endregion
            #region FOOTER
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("        Digite 0 para sair         ");
            System.Console.WriteLine(barraMenu);
            #endregion

            #region CODIGO
            int codigo = -1;
            System.Console.Write("Digite o código desejado: ");
            int.TryParse(Console.ReadLine(), out codigo);

            return codigo;
            #endregion
        }
        private static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
    }
}