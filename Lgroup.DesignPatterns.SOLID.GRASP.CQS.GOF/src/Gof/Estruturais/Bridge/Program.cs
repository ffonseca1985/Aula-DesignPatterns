using Bridge.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente A
            var estoqueLgroupTatuape = new EstoqueLGroupTatuape();
            estoqueLgroupTatuape.BaixarEstoque(1, 1);

            //Passou um tempo e o cliente A, quer o serviço do Tatuape, mas com
            //Alta disponibilidade.
            //O que ele Faz?????


            var estoqueLgroupTatuapeComAltaDisp = 
                new EstoqueLGroupAltaDisponibilidade(estoqueLgroupTatuape);

            for (int i = 0; i < 10; i++)
            {
                estoqueLgroupTatuapeComAltaDisp.BaixarEstoqueAltaDisponibilidade(1, i);
            }            

            Console.Read();
        }
    }
}
