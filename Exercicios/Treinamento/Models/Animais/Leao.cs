using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class Leao : Animal, ITerrestre
    {
        public string ViverTerra()
        {
            return this.GetType().Name + "Vive na terra.";
        }
    }
}