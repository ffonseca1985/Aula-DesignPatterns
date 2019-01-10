using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Curso.Infra.Data.maps
{
    using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;

    public class CursoMap : 
        EntityTypeConfiguration<Curso>
    {

        public CursoMap()
        {

            Property(x => x.Preco.Moeda)
                .HasColumnName("Moeda");

            Property(x => x.Preco.PrecoTotal)
                .HasColumnName("Total");

            Property(x => x.Preco.Valor)
                .HasColumnName("Valor");

            Property(x => x.Preco.Cotacao)
                .HasColumnName("Cotacao");
        }
    }
}
