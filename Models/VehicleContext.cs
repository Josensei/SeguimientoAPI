using Microsoft.EntityFrameworkCore;

namespace SeguimientoAPI.Models
{
    public class VehicleContext :DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options) 
        {
        }
    public DbSet<Pedido> Vehicles { get; set; }
    }
}
