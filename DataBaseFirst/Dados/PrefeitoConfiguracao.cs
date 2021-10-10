using DataBaseFirst.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataBaseFirst.Dados
{
    class PrefeitoConfiguracao : IEntityTypeConfiguration<PrefeitosAtuais>
    {
        public void Configure(EntityTypeBuilder<PrefeitosAtuais> builder)
        {
            builder.ToTable("PrefeitosAtuais");

            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome");

            builder.Property(p => p.InicioMandato)
                .HasColumnName("InicioMandato")
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(p => p.FimMandato)
                .HasColumnName("FimMandato")
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property<Guid>("CidadeId").IsRequired();

            builder
               .HasOne(p => p.CidadeMandato)
               .WithOne(c => c.PrefeitoAtual)
               .HasForeignKey<PrefeitosAtuais>("CidadeId");

            builder
                .Property<DateTime?>("UltimaAtualizacao")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()");
        }
    }
}
