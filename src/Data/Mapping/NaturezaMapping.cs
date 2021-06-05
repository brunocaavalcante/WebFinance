using Business.Financas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class NaturezaOperacaoMapping : IEntityTypeConfiguration<NaturezaOperacao>
    {
        public void Configure(EntityTypeBuilder<NaturezaOperacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("varchar(200)");
        }
    }
}
