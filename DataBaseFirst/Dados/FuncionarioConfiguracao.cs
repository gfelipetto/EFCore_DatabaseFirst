using DataBaseFirst.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataBaseFirst.Dados
{
    class FuncionarioConfiguracao : IEntityTypeConfiguration<Funcionarios>
    {
        public void Configure(EntityTypeBuilder<Funcionarios> builder)
        {
            builder.ToTable("Funcionarios");

            builder.Property(f => f.Id)
                .HasColumnName("Id");

            builder.Property(f => f.Nome)
                .HasColumnName("Nome");

            builder.Property(f => f.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            builder.Property<Guid>("CidadeId").IsRequired();

            builder
                .HasOne(f => f.CidadeTrabalho)
                .WithMany(c => c.Funcionarios)
                .HasForeignKey("CidadeId");

            builder
                .Property<DateTime?>("UltimaAtualizacao")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()");
        }
    }
}
