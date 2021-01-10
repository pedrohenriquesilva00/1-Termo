using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class Pinguim : Animal, IFrio
    {
        public string ResistirFrio()
        {
            return this.GetType().Name + "Vive em temperaturas extremas.";
        }
    }
}