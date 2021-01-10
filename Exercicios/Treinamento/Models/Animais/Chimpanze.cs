using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class Chimpanze : Animal, IArboricola
    {
        public string ViverArvores()
        {
            return this.GetType().Name + "Vive principalmente nas árvores.";
        }
    }
}