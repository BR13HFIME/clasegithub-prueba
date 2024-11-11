using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BRIAN_PRUEBA_CLASE_PWEB.Models.dbModels;

[Table("Marca")]
public partial class Marca
{
    [Key]
    public int IdMarca { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    public string Descripcion { get; set; } = null!;

    public string? Imagen { get; set; }

    [InverseProperty("IdMarcaNavigation")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
