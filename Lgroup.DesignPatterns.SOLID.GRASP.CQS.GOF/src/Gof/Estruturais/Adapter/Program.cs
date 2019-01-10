using Adapter.Constracts;
using Adapter.Factories;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogistica estoqueL = EstoqueFactory.Create(TipoEstoque.Lgroup);
            estoqueL.BaixarEstoque(1, 1);

            ILogistica estoqueM = EstoqueFactory.Create(TipoEstoque.Magento);
            estoqueM.BaixarEstoque(2, 2);
        }
    }
}
