using Microsoft.EntityFrameworkCore;
using ClinicaVeterinaria.App.Dominio;
namespace ClinicaVeterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Caballo> Caballos {get;set;}
        public DbSet<Historia_clinica> Historias_clinicas {get;set;}
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Propietario_Caballo> Propietarios_Caballo {get;set;}
        public DbSet<Tratamiento_Medico> Tratamientos_Medicos {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Visita_Domiciliaria> Visitas_Domiciliarias {get;set;}
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured) //configuracion de la base de datos
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=ClinicaVeterinariaData");
            }

        }
    }
}