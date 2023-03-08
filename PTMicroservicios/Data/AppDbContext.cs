using Microsoft.EntityFrameworkCore;
using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {

        }

        public DbSet<Persona> Personas => Set<Persona>();
        public DbSet<Cliente> Clientes => Set<Cliente>(); 
        public DbSet<Cuenta> Cuentas => Set<Cuenta>();
        public DbSet<Movimiento> Movimientos => Set<Movimiento>();
    }
}
