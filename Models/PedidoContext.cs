using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace SeguimientoAPI.Models
{
    public class PedidoContext : DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options)
            : base(options) 
        {
        }
        public DbSet<Pedido> Pedidos { get; set; }  
    }
}
