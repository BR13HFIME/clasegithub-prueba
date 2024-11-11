using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BRIAN_PRUEBA_CLASE_PWEB.Models.dbModels
{
    public class AplicationUser : IdentityUser<int>
    {
        public AplicationUser() 
        { 
        Carritos = new HashSet<Carrito>();
        Deseados = new HashSet<Deseado>();
        Resenas = new HashSet<Resena>();
        Venta = new HashSet<Ventum>();
        }
        [Key]
        public int IdUsuario { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; } = null!;
        public int Edad { get; set; }

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Deseado> Deseados { get; set; } = new List<Deseado>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Resena> Resenas { get; set; } = new List<Resena>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
    }
}
