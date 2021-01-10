using System;
using Treinamento.Interfaces;

namespace Treinamento.Models.Animais
{
    public class Orongotango : Animal, IArboricola
    {
        public string ViverArvores()
        {
            return this.GetType().Name + "Vive nas árvores.";
        }
    }
}