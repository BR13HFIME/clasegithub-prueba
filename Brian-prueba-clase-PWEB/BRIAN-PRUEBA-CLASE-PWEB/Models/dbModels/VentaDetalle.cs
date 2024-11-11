using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BRIAN_PRUEBA_CLASE_PWEB.Models.dbModels;

[PrimaryKey("IdVenta", "IdProducto")]
[Table("VentaDetalle")]
public partial class VentaDetalle
{
    [Key]
    public int IdVenta { get; set; }

    [Key]
    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Total { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("VentaDetalles")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdVenta")]
    [InverseProperty("VentaDetalles")]
    public virtual Ventum IdVentaNavigation { get; set; } = null!;
}
