using EntityFrameworkClase2.Models;
using Microsoft.EntityFrameworkCore;


namespace EntityFrameworkClase2.Data
{
    public class UsuarioDBContext : DbContext
    {
        public UsuarioDBContext(DbContextOptions<UsuarioDBContext> options) : base(options)
        {
        }


        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Name = "Allam",
                    LastName = "Fernández Rivera",
                    Email = "alfernandez@neu.com",
                    isActive = false,
                }
            );
        }
    }
}