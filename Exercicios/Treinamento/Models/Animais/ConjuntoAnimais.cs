using System.Collections.Generic;

namespace Treinamento.Models.Animais
{
    public class ConjuntoAnimais
    {
        public static Dictionary<int, Animal> Animais = new Dictionary<int, Animal>()
        {
            {1, new TubaraoMartelo()},
            {2, new Tucano()},
            {3, new Arara()},
            {4, new Leao()},
            {5, new Orongotango()},
            {6, new Chimpanze()},
            {7, new Pinguim()},
            {8, new Tartaruga()},
            {9, new Golfinho()}
        };
    }
}