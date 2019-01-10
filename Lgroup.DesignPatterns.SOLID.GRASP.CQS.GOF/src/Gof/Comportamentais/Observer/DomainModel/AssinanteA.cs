using Observer.Contracts;
using System;

namespace Observer.DomainModel
{
    public class AssinanteA : IAssinante
    {
        public void ReceberEmail()
        {
            Console.WriteLine("UsuarioA recebeu o email");
        }
    }
}
