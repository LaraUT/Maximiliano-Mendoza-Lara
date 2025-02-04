using Maximiliano_Mendoza_Lara.Models.Domain;
using Microsoft.EntityFrameworkCore;


namespace Maximiliano_Mendoza_Lara.Content
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext (DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PkUsuario = 1,
                    Nombre = "Max",
                    UserName = "Usuario",
                    Password = "123",
                    FkRol = 1,
                }
                );
            modelBuilder.Entity<Rol>().HasData(
                new Rol { 
                    PkRol = 1,
                    Nombre = "sa"
                });
        }
    }
}
