using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : Lixo, IVidro
    {
        public string Reciclar()
        {
            return this.GetType().Name;
        }
    }
}
