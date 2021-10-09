using Microsoft.EntityFrameworkCore;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ganadero> Ganaderos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Solicitudes> Solicitudes { get; set; }
        public DbSet<Vacunas> Vacunas { get; set; }
        public DbSet<HistoriaClinica> Historias { get; set; }
        public DbSet<Ejemplares> Ejemplares { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Grupo31");
            }
        }
    }
}