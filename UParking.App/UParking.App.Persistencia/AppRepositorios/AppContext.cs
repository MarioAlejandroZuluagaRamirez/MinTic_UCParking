using Microsoft.EntityFrameworkCore;
using UParking.App.Dominio;

namespace UParking.App.Persistencia
{
    public class AppContext:DbContext
    {
            public DbSet<Estudiante> Estudiantes {get;set;} 
            public DbSet<Parqueadero> Parqueaderos {get;set;}
            public DbSet<Persona> Personas {get;set;}
            public DbSet<Administrativo> Administrativos {get;set;}
            public DbSet<Profesor> Profesores {get;set;}
            public DbSet<Puesto> Puestos {get;set;}
            public DbSet<Transaccion> Transacciones {get;set;}
            public DbSet<Vehiculo> Vehiculos {get;set;}
            public DbSet<Visitante> Visitantes {get;set;}
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = UParkingData");
            }
        }
    }
}