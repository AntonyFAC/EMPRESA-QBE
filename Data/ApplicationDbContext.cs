using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMPRESA_QBE.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<EMPRESA_QBE.Models.Contacto> DataContactos { get; set; }
    public DbSet<EMPRESA_QBE.Models.Producto> DataProductos { get; set; }
    public DbSet<EMPRESA_QBE.Models.Proforma> DataProforma { get; set; }
    public DbSet<EMPRESA_QBE.Models.Pago> DataPago { get; set; }
    public DbSet<EMPRESA_QBE.Models.Pedido> DataPedido { get; set; }
    public DbSet<EMPRESA_QBE.Models.DetallePedido> DataDetallePedido { get; set; }
}
