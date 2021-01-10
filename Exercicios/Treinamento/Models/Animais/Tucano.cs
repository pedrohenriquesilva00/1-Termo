
using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class Tucano : Animal, IAereo
    {
        public string Voar()
        {
            return this.GetType().Name + "Provido de asas.";
        }
    }
}