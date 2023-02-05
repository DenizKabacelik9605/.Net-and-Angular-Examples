using Microsoft.EntityFrameworkCore;

namespace CargoManagementSystemV1
{
    public class CargoContext:DbContext
    {
        
        public CargoContext(DbContextOptions options):base(options) { }


        public DbSet<Cargo> Cargos { get; set; }


        public DbSet<Port> Ports { get; set; }


        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<ShippedAt> ShippedAts { get; set; }

    }
}
