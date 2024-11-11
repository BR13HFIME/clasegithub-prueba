
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BRIAN_PRUEBA_CLASE_PWEB.Models.dbModels;

public partial class TiendaPruebaContext : IdentityDbContext<AplicationUser, IdentityRole<int>, int>
{
    public TiendaPruebaContext()
    {
    }

    public TiendaPruebaContext(DbContextOptions<TiendaPruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carrito> Carritos { get; set; }

    public virtual DbSet<Deseado> Deseados { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Resena> Resenas { get; set; }

    public virtual DbSet<VentaDetalle> VentaDetalles { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Carrito>(entity =>
        {
            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Carritos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Carrito_Producto");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Carritos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Carrito_Usuario");
        });

        modelBuilder.Entity<Deseado>(entity =>
        {
            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Deseados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deseados_Producto");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Deseados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deseados_Usuario");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Marca");
        });

        modelBuilder.Entity<Resena>(entity =>
        {
            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Resenas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Resena_Producto");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Resenas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Resena_Usuario");
        });



        modelBuilder.Entity<VentaDetalle>(entity =>
        {
            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.VentaDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VentaDetalle_Producto");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.VentaDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VentaDetalle_Venta");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
