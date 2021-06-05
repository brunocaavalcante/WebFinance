using System;
using Business.Financas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class OparecaoMapping : IEntityTypeConfiguration<Operacao>
    {
        public void Configure(EntityTypeBuilder<Operacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("varchar(1000)");
            builder.Property(x => x.Valor).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.DataVencimento);

            /*Uma Operação tem uma Natureza, e uma Natureza pode ter varias Operacoes*/
            builder.HasOne(x => x.NaturezaOperacao).WithMany(n => n.Operacao);
            builder.ToTable("Operacoes");
        }
    }      

}