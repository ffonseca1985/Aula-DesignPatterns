using Adapter.Adapters;
using Adapter.Constracts;
using Adapter.DomainModel;
using Adapter.SistemasTerceiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Factories
{
    public class EstoqueFactory
    {
        //Abstract Method
        public static ILogistica Create(TipoEstoque tipo)
        {
            switch (tipo)
            {
                case TipoEstoque.Lgroup:
                    return new EstoqueLgroup();
                case TipoEstoque.Magento:
                    return new EstoqueMagentoAdpater();
                default:
                    throw new Exception();
            }
        } 
    }
    public enum TipoEstoque
    {
        Lgroup,
        Magento
    }
}
