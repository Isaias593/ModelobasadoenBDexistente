﻿// <auto-generated />
using System;
using BDFactura.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BDFactura.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BDFactura.models.DetalleFactura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("facturaid")
                        .HasColumnType("int");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("productoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("facturaid");

                    b.HasIndex("productoid");

                    b.ToTable("DetalleFactura");
                });

            modelBuilder.Entity("BDFactura.models.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre_genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("BDFactura.models.cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("correo_electronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<int>("generoid")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BDFactura.models.factura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.Property<double>("totalXproducto")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("BDFactura.models.producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("categoriaid")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio_compra")
                        .HasColumnType("float");

                    b.Property<double>("precio_venta")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("BDFactura.models.vendedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("correo_electronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha_registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("generoid")
                        .HasColumnType("int");

                    b.Property<string>("nombre_comple")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("generoid");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("BDFactura.models.DetalleFactura", b =>
                {
                    b.HasOne("BDFactura.models.factura", "Factura")
                        .WithMany()
                        .HasForeignKey("facturaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDFactura.models.producto", "Producto")
                        .WithMany()
                        .HasForeignKey("productoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("BDFactura.models.vendedor", b =>
                {
                    b.HasOne("BDFactura.models.Genero", "genero")
                        .WithMany()
                        .HasForeignKey("generoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genero");
                });
#pragma warning restore 612, 618
        }
    }
}
