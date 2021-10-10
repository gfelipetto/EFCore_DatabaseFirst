using DataBaseFirst.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst.Dados
{
    class FuncoesConfiguracoes : IEntityTypeConfiguration<Funcoes>
    {
        public void Configure(EntityTypeBuilder<Funcoes> builder)
        {
            builder.ToTable("Funcoes");

            builder.Property(f => f.Id)
                .HasColumnName("Id");

            builder.Property(f => f.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("nvarchar");

            builder.Property(f => f.NivelAcesso)
                .HasColumnName("NivelAcesso")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property<DateTime?>("UltimaAtualizacao")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()");
        }
    }
}
