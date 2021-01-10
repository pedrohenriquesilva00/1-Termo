using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IPercussao
    {
        public bool ManterRitmo ()
        {
            System.Console.WriteLine("Mantendo o ritmo do Violão.");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Violão.");
            return true;
        }


        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do Violão.");
            return true;
        }
    }
}