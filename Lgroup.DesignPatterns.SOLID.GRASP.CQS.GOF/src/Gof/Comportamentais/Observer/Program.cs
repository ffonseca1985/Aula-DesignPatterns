using Observer.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var assinanteA = new AssinanteA();
            var assinanteB = new AssinanteB();
            var assinanteC = new AssinanteC();

            var newsLetters = new NewsLetters();
            newsLetters.Registrar(assinanteA);
            newsLetters.Registrar(assinanteB);
            newsLetters.EnviarEmail();

            Console.WriteLine(new string('<', 10));
            Console.WriteLine(new string('>', 10));

            newsLetters.Registrar(assinanteC);
            newsLetters.EnviarEmail();

            Console.WriteLine(new string('<', 10));
            Console.WriteLine(new string('>', 10));

            newsLetters.Remove(assinanteA);
            newsLetters.EnviarEmail();

        }
    }
}
