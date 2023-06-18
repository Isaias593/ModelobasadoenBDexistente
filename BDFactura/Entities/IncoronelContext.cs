using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDFactura.Entities;

public partial class IncoronelContext : DbContext
{
    public IncoronelContext()
    {
    }

    public IncoronelContext(DbContextOptions<IncoronelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Salidatabla1> Salidatabla1s { get; set; }

    public virtual DbSet<Tabladestino2> Tabladestino2s { get; set; }

    public virtual DbSet<Vendedor> Vendedors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=KGB;Database=INCORONEL;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CorreoElectronico).HasColumnName("correo_electronico");
            entity.Property(e => e.Direccion).HasColumnName("direccion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");
            entity.Property(e => e.Generoid).HasColumnName("generoid");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.ToTable("DetalleFactura");

            entity.HasIndex(e => e.Facturaid, "IX_DetalleFactura_facturaid");

            entity.HasIndex(e => e.Productoid, "IX_DetalleFactura_productoid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Facturaid).HasColumnName("facturaid");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Productoid).HasColumnName("productoid");

            entity.HasOne(d => d.Factura).WithMany(p => p.DetalleFacturas).HasForeignKey(d => d.Facturaid);

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleFacturas).HasForeignKey(d => d.Productoid);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.ToTable("Factura");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalXproducto).HasColumnName("totalXproducto");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.ToTable("Genero");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");
            entity.Property(e => e.NombreGenero).HasColumnName("nombre_genero");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Categoriaid).HasColumnName("categoriaid");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.PrecioCompra).HasColumnName("precio_compra");
            entity.Property(e => e.PrecioVenta).HasColumnName("precio_venta");
        });

        modelBuilder.Entity<Salidatabla1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Salidatabla1");

            entity.Property(e => e.Dirección)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Establecimiento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Latitud).HasColumnName("latitud");
            entity.Property(e => e.Longitud).HasColumnName("longitud");
        });

        modelBuilder.Entity<Tabladestino2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabladestino2");

            entity.Property(e => e.Dirección)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Establecimiento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Latitud).HasColumnName("latitud");
            entity.Property(e => e.Longitud).HasColumnName("longitud");
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.ToTable("Vendedor");

            entity.HasIndex(e => e.Generoid, "IX_Vendedor_generoid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CorreoElectronico).HasColumnName("correo_electronico");
            entity.Property(e => e.Direccion).HasColumnName("direccion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");
            entity.Property(e => e.Generoid).HasColumnName("generoid");
            entity.Property(e => e.NombreComple).HasColumnName("nombre_comple");
            entity.Property(e => e.Telefono).HasColumnName("telefono");

            entity.HasOne(d => d.Genero).WithMany(p => p.Vendedors).HasForeignKey(d => d.Generoid);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
