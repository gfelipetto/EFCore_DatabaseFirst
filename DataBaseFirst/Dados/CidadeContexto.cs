using DataBaseFirst.Negocio;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Dados
{
    class CidadeContexto : DbContext
    {
        public DbSet<Cidades> Cidade { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Funcoes> Funcoes { get; set; }
        public DbSet<FuncoesFuncionarios> FuncaoFuncionario { get; set; }
        public DbSet<PrefeitosAtuais> PrefeitoAtual { get; set; }
        public DbSet<EFMigrationsHistory> EFMigrationsHistory { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Cidades;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguracao());
            modelBuilder.ApplyConfiguration(new CidadeConfiguracao());
            modelBuilder.ApplyConfiguration(new FuncoesConfiguracoes());
            modelBuilder.ApplyConfiguration(new FuncoesFuncionariosConfiguracao());
            modelBuilder.ApplyConfiguration(new PrefeitoConfiguracao());
            modelBuilder.ApplyConfiguration(new EFMigrationsHistoryConfiguracao());
        }
    }
}
