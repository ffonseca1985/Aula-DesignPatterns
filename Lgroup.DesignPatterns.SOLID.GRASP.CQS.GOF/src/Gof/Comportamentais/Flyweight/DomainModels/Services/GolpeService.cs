using Flyweight.Contracts;
using System.Collections.Generic;

namespace Flyweight.DomainModels.Services
{
    public class GolpeService
    {
        //Meu container
        //Onde vou guardar minhas classes e serviços
        //Aqui iremos identificar uma classe por uma chave
        //logo, este item é um container de localização de classes já instanciadas..,
        //ou seja, é um service locator(serviço de localização)
        public static IDictionary<string, IGolpe> _golpes;
        static GolpeService()
        {
            _golpes = new Dictionary<string, IGolpe>();
            _golpes.Add("cabecada", new Cabecada());
            _golpes.Add("chutefraco", new ChuteFraco());
            _golpes.Add("voadora", new Voadora());
        }

        public static IGolpe Get(string nomeGolpe)
        {
            return _golpes[nomeGolpe];
        }
    }
}
