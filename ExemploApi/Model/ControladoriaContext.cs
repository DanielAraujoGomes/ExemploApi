using Microsoft.EntityFrameworkCore;

namespace ExemploApi.Model
{
    public class ControladoriaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=10.235.1.61\\QA;Integrated Security=False;User ID=SistemasBD;Password=<>j97jy123; Initial Catalog=DBCONTROLADORIA");
        }
        
        public DbSet<Usuario> Usuarios { get; set; } 
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>()
                .HasIndex(u => u.Nome)
                .IsUnique();
        }
    }
}