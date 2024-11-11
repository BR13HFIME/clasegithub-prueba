using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BRIAN_PRUEBA_CLASE_PWEB.Models.dbModels;

[PrimaryKey("IdUsuario", "IdProducto")]
[Table("Carrito")]
public partial class Carrito
{
    [Key]
    public int IdUsuario { get; set; }

    [Key]
    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaAñadido { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("Carritos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("Carritos")]
    public virtual AplicationUser IdUsuarioNavigation { get; set; } = null!;
}
