using TemplateMethod.DomanModel;

namespace TemplateMethod
{
    class Program
    {
        //O templateMethod pressupoe que vc tenha um template 
        //de base, seria como um espelho para a sua classe 
        static void Main(string[] args)
        {
            var vendaAmericanas = new VendaAmericanas();
            vendaAmericanas.Finalizar("cpf1");

            var vendaCasasBahia = new VendasCasasBahia();
            vendaCasasBahia.Finalizar("cpf2");
        }
    }
}
