using Observer.Contracts;
using System;

namespace Observer.DomainModel
{
    public class AssinanteC : IAssinante
    {
        public void ReceberEmail()
        {
            Console.WriteLine("UsuarioC recebeu o email");
        }
    }
}
