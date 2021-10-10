using DataBaseFirst.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataBaseFirst.Dados
{
    class CidadeConfiguracao : IEntityTypeConfiguration<Cidades>
    {
        public void Configure(EntityTypeBuilder<Cidades> builder)
        {
            builder.ToTable("Cidades");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.Populacao)
                .HasColumnName("Populacao")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.TaxaCriminalidade)
                .HasColumnName("TaxaCriminalidade")
                .HasColumnType("float")
                .IsRequired();

            builder.Property(c => c.ImpostoSobreProduto)
                .HasColumnName("ImpostoSobreProduto")
                .HasColumnType("float")
                .IsRequired();

            builder.Property(c => c.EstadoCalamidade)
                .HasColumnName("EstadoCalamidade")
                .HasColumnType("bit")
                .IsRequired();

            builder
                .Property<DateTime?>("UltimaAtualizacao")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()");
        }
    }
}
