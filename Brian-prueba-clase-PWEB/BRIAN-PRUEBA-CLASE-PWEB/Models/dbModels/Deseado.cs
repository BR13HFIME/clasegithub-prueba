using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BRIAN_PRUEBA_CLASE_PWEB.Models.dbModels;

[PrimaryKey("IdUsuario", "IdProducto")]
public partial class Deseado
{
    [Key]
    public int IdUsuario { get; set; }

    [Key]
    public int IdProducto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaAñadido { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("Deseados")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("Deseados")]
    public virtual AplicationUser IdUsuarioNavigation { get; set; } = null!;
}
