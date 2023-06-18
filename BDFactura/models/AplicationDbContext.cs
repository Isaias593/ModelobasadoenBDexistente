using Microsoft.EntityFrameworkCore;

namespace BDFactura.models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }
        public DbSet<cliente> Cliente { get; set; }
         public DbSet<factura> Factura { get; set; }

       

        public DbSet<producto> Productos { get; set; }

        public DbSet<vendedor> Vendedor { get; set; }

        public DbSet<DetalleFactura> DetalleFactura { get;set; }
    }
}
