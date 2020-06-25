﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RentCar.Data;

namespace RentCar.Migrations
{
    [DbContext(typeof(RentCarDbContext))]
    [Migration("20200611030757_RentCarMig3")]
    partial class RentCarMig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RentCar.Models.RentCarModels.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<bool>("Estado");

                    b.Property<int>("IdTipoPersona");

                    b.Property<int>("LimiteCr");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TarjetaCr")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(19);

                    b.HasKey("IdCliente");

                    b.HasIndex("IdTipoPersona");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("Comision");

                    b.Property<bool>("Estado");

                    b.Property<DateTime>("FechaIngreso");

                    b.Property<int>("IdTanda");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdEmpleado");

                    b.HasIndex("IdTanda");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Inspeccion", b =>
                {
                    b.Property<int>("IdTransaccion")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantidadCombustible");

                    b.Property<bool>("CuartaGoma");

                    b.Property<bool>("Estado");

                    b.Property<DateTime>("Fecha");

                    b.Property<bool>("Gato");

                    b.Property<bool>("GomaRepuesta");

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdEmpleado");

                    b.Property<int>("IdVehiculo");

                    b.Property<bool>("PrimeraGoma");

                    b.Property<bool>("Ralladura");

                    b.Property<bool>("RoturaCristal");

                    b.Property<bool>("SegundaGoma");

                    b.Property<bool>("TerceraGoma");

                    b.HasKey("IdTransaccion");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEmpleado");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("Inspecciones");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Marca", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.HasKey("IdMarca");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Modelo", b =>
                {
                    b.Property<int>("IdModelo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.Property<int>("IdMarca");

                    b.HasKey("IdModelo");

                    b.HasIndex("IdMarca");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.RentaDevolucion", b =>
                {
                    b.Property<int>("IdRenta")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantidadDias");

                    b.Property<string>("Comentario")
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("EmpleadoIdEmpleado");

                    b.Property<bool>("Estado");

                    b.Property<DateTime>("FechaDevolucion");

                    b.Property<DateTime>("FechaRenta");

                    b.Property<int>("IdCliente");

                    b.Property<string>("IdEmpleado")
                        .IsRequired();

                    b.Property<string>("IdVehiculo")
                        .IsRequired();

                    b.Property<int>("MontoDiario");

                    b.Property<int?>("VehiculoIdVehiculo");

                    b.HasKey("IdRenta");

                    b.HasIndex("EmpleadoIdEmpleado");

                    b.HasIndex("IdCliente");

                    b.HasIndex("VehiculoIdVehiculo");

                    b.ToTable("RentasDevoluciones");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Tanda", b =>
                {
                    b.Property<int>("IdTanda")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.HasKey("IdTanda");

                    b.ToTable("Tandas");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.TipoCombustible", b =>
                {
                    b.Property<int>("IdTipoCombustible")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.HasKey("IdTipoCombustible");

                    b.ToTable("TipoCombustibles");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.TipoPersona", b =>
                {
                    b.Property<int>("IdTipoPersona")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.HasKey("IdTipoPersona");

                    b.ToTable("TipoPersonas");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.TipoVehiculo", b =>
                {
                    b.Property<int>("IdTipoVehiculo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.HasKey("IdTipoVehiculo");

                    b.ToTable("TipoVehiculos");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Vehiculo", b =>
                {
                    b.Property<int>("IdVehiculo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Estado");

                    b.Property<int>("IdMarca");

                    b.Property<int>("IdModelo");

                    b.Property<int>("IdTipoCombustible");

                    b.Property<int>("IdTipoVehiculo");

                    b.Property<string>("NumChasis")
                        .IsRequired()
                        .HasColumnType("varchar(9)");

                    b.Property<string>("NumPlaca")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("IdVehiculo");

                    b.HasIndex("IdMarca");

                    b.HasIndex("IdModelo");

                    b.HasIndex("IdTipoCombustible");

                    b.HasIndex("IdTipoVehiculo");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Cliente", b =>
                {
                    b.HasOne("RentCar.Models.RentCarModels.TipoPersona", "TipoPersona")
                        .WithMany("Cliente")
                        .HasForeignKey("IdTipoPersona")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Empleado", b =>
                {
                    b.HasOne("RentCar.Models.RentCarModels.Tanda", "Tanda")
                        .WithMany("Empleado")
                        .HasForeignKey("IdTanda")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Inspeccion", b =>
                {
                    b.HasOne("RentCar.Models.RentCarModels.Cliente", "Cliente")
                        .WithMany("Inspeccion")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentCar.Models.RentCarModels.Empleado", "Empleado")
                        .WithMany("Inspeccion")
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentCar.Models.RentCarModels.Vehiculo", "Vehiculo")
                        .WithMany("Inspeccion")
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Modelo", b =>
                {
                    b.HasOne("RentCar.Models.RentCarModels.Marca", "Marca")
                        .WithMany("Modelo")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.RentaDevolucion", b =>
                {
                    b.HasOne("RentCar.Models.RentCarModels.Empleado", "Empleado")
                        .WithMany("RentaDevolucion")
                        .HasForeignKey("EmpleadoIdEmpleado");

                    b.HasOne("RentCar.Models.RentCarModels.Cliente", "Cliente")
                        .WithMany("RentaDevolucion")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentCar.Models.RentCarModels.Vehiculo", "Vehiculo")
                        .WithMany("RentaDevolucion")
                        .HasForeignKey("VehiculoIdVehiculo");
                });

            modelBuilder.Entity("RentCar.Models.RentCarModels.Vehiculo", b =>
                {
                    b.HasOne("RentCar.Models.RentCarModels.Marca", "Marca")
                        .WithMany("Vehiculo")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentCar.Models.RentCarModels.Modelo", "Modelo")
                        .WithMany("Vehiculo")
                        .HasForeignKey("IdModelo")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentCar.Models.RentCarModels.TipoCombustible", "TipoCombustible")
                        .WithMany("Vehiculo")
                        .HasForeignKey("IdTipoCombustible")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentCar.Models.RentCarModels.TipoVehiculo", "TipoVehiculo")
                        .WithMany("Vehiculo")
                        .HasForeignKey("IdTipoVehiculo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
