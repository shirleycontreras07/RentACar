using Microsoft.EntityFrameworkCore;
using RentCar.Models.RentCarModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class RentCarDbContext : DbContext
    {
        public RentCarDbContext(DbContextOptions<RentCarDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Inspeccion> Inspecciones { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<RentaDevolucion> RentasDevoluciones { get; set; }
        public DbSet<Tanda> Tandas { get; set; }
        public DbSet<TipoCombustible> TipoCombustibles { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        

    }
}
