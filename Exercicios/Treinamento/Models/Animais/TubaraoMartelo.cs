using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class TubaraoMartelo : Animal, IAquatico
    {
        public string ViverAgua()
        {
            return this.GetType().Name + "Vive na água.";
        }
    }
}