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
    class EFMigrationsHistoryConfiguracao : IEntityTypeConfiguration<EFMigrationsHistory>
    {
        public void Configure(EntityTypeBuilder<EFMigrationsHistory> builder)
        {
            builder.ToTable("__EFMigrationsHistory");

            builder.Property(e => e.ProductVersion)
                .HasColumnName("MigrationId");

            builder.Property(e => e.ProductVersion)
                .HasColumnName("ProductVersion");
        }
    }
}
