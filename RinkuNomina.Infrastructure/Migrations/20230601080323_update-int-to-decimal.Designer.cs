﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RinkuNomina.Application;

#nullable disable

namespace RinkuNomina.Infrastructure.Migrations
{
    [DbContext(typeof(RinkuContext))]
    [Migration("20230601080323_update-int-to-decimal")]
    partial class updateinttodecimal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RinkuNomina.Domain.Model.BitacoraSueldo", b =>
                {
                    b.Property<Guid>("IdBitacoraSueldo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdBitacoraSueldo")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("HorasTrabajadas")
                        .HasColumnType("int");

                    b.Property<Guid>("IdEmpleado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PagoTotalBonos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Retencion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SueldoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Vales")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdBitacoraSueldo");

                    b.ToTable("BitacoraSueldo", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.BonosPorRol", b =>
                {
                    b.Property<Guid>("IdBonoRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdBonoRol")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdFrecuenciaBono")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdRol")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoBono")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdBonoRol");

                    b.ToTable("BonosPorRol", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.Cliente", b =>
                {
                    b.Property<Guid>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdCliente")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.EntregasPorEmpleado", b =>
                {
                    b.Property<Guid>("IdEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdEntrega")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<int>("CantidadEntregas")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdClienteEntrega")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEmpleado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdEntrega");

                    b.ToTable("EntregasPorEmpleado", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.FrecuenciaBono", b =>
                {
                    b.Property<Guid>("IdFrecuenciaBono")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdFrecuenciaBono")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdFrecuenciaBono");

                    b.ToTable("FrecuenciaBono", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.RolEmpleado", b =>
                {
                    b.Property<Guid>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdRol")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdRol");

                    b.ToTable("RolEmpleado", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.SueldoBase", b =>
                {
                    b.Property<Guid>("IdSueldoBase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdSueldoBase")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<decimal>("CantidadPorHora")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdEmpleado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSueldoBase");

                    b.ToTable("SueldoBase", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.TipoBono", b =>
                {
                    b.Property<Guid>("IdTipoBono")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdTipoBono")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdTipoBono");

                    b.ToTable("TipoBono", (string)null);
                });

            modelBuilder.Entity("RinkuNomina.Domain.Model.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdUsuario")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("RinkuNominaDomain.Model.Empleado", b =>
                {
                    b.Property<Guid>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdEmpleado")
                        .HasDefaultValueSql("NEWSEQUENTIALID()")
                        .HasComment("Llave principal de la tabla");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdRol")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuarioCreacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuarioModificacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("NumeroEmpleado")
                        .HasColumnType("int");

                    b.HasKey("IdEmpleado");

                    b.ToTable("Empleado", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
