using Observer.Contracts;
using System;

namespace Observer.DomainModel
{
    public class AssinanteB: IAssinante
    {
        public void ReceberEmail()
        {
            Console.WriteLine("UsuarioB recebeu o email");
        }
    }
}
