using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB.Data
{
    public class DbFacturacionContext : DbContext
    {
        public DbFacturacionContext(DbContextOptions<DbFacturacionContext> options) : base(options)
        {

        }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Rol>() 
            .Property(b => b.CreadoPor)
            .HasDefaultValue("getdate()");
            
            modelBuilder.Entity<Usuario>() 
            .Property(b => b.CreadoPor) 
            .HasDefaultValue("getdate()"); 
        }
    }
}