using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class Tartaruga : Animal, IAquatico
    {
        public string ViverAgua()
        {
            return this.GetType().Name + "Vive na água.";
        }
    }
}