using System;

namespace Singleton
{
    public class Connection2
    {
        //A conection como é static só vai ser instanciada 1 vez
        //Como é readonly ninguém vai conseguir modar;
        public static readonly Connection2 Conection = new Connection2();
        
        private Connection2() {
            Console.Write("Construtor");
        }
        
    }
}
