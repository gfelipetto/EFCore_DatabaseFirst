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
    public class FuncoesFuncionariosConfiguracao : IEntityTypeConfiguration<FuncoesFuncionarios>
    {
        public void Configure(EntityTypeBuilder<FuncoesFuncionarios> builder)
        {
            builder.ToTable("FuncoesFuncionarios");

            builder.Property<Guid>("FuncionarioId").IsRequired();
            builder.Property<Guid>("FuncaoId").IsRequired();

            builder.HasKey("FuncionarioId", "FuncaoId");

            builder
                .HasOne(ff => ff.Funcao)
                .WithMany(f => f.MembrosFuncao)
                .HasForeignKey("FuncaoId");

            builder
                .HasOne(ff => ff.Funcionario)
                .WithMany(f => f.FuncoesMembro)
                .HasForeignKey("FuncionarioId");
        }
    }
}
