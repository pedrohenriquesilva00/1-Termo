using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class Golfinho : Animal, IAquatico
    {
        public string ViverAgua()
        {
            return this.GetType().Name + "Vive no mar.";
        }
    }
}