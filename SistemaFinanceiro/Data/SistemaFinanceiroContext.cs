using System.Data.Entity;
using SistemaFinanceiro.Model;

namespace SistemaFinanceiro.Data
{
    public class SistemaFinanceiroContext : DbContext
    {
        public SistemaFinanceiroContext()
            : base("name=SistemaFinanceiroContext")
        {
            // Database.SetInitializer(new SistemaFinanceiroInitializer());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.TransacoesRealizadas)
                .WithRequired(t => t.Usuario)
                .HasForeignKey(t => t.UsuarioId);
            // Configura o nome da tabela Transacao
            modelBuilder.Entity<Transacao>().ToTable("Transacoes");

            modelBuilder.Entity<Relatorio>().ToTable("Relatorios");

            base.OnModelCreating(modelBuilder);
        }
    }
}
