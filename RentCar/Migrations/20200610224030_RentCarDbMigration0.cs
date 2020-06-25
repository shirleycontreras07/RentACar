using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RentCar.Migrations
{
    public partial class RentCarDbMigration0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "Tandas",
                columns: table => new
                {
                    IdTanda = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tandas", x => x.IdTanda);
                });

            migrationBuilder.CreateTable(
                name: "TipoCombustibles",
                columns: table => new
                {
                    IdTipoCombustible = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCombustibles", x => x.IdTipoCombustible);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersonas",
                columns: table => new
                {
                    IdTipoPersona = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonas", x => x.IdTipoPersona);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculos",
                columns: table => new
                {
                    IdTipoVehiculo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculos", x => x.IdTipoVehiculo);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    IdModelo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    IdMarca = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.IdModelo);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(11)", nullable: false),
                    IdTanda = table.Column<int>(nullable: false),
                    Comision = table.Column<int>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Tandas_IdTanda",
                        column: x => x.IdTanda,
                        principalTable: "Tandas",
                        principalColumn: "IdTanda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "varchar(11)", nullable: false),
                    TarjetaCr = table.Column<string>(type: "varchar(19)", maxLength: 19, nullable: false),
                    LimiteCr = table.Column<int>(nullable: false),
                    IdTipoPersona = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_TipoPersonas_IdTipoPersona",
                        column: x => x.IdTipoPersona,
                        principalTable: "TipoPersonas",
                        principalColumn: "IdTipoPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: false),
                    NumChasis = table.Column<string>(type: "varchar(8)", nullable: false),
                    NumPlaca = table.Column<string>(type: "varchar(7)", nullable: false),
                    IdTipoVehiculo = table.Column<int>(nullable: false),
                    IdMarca = table.Column<int>(nullable: false),
                    IdModelo = table.Column<int>(nullable: false),
                    IdTipoCombustible = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.IdVehiculo);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Modelos_IdModelo",
                        column: x => x.IdModelo,
                        principalTable: "Modelos",
                        principalColumn: "IdModelo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_TipoCombustibles_IdTipoCombustible",
                        column: x => x.IdTipoCombustible,
                        principalTable: "TipoCombustibles",
                        principalColumn: "IdTipoCombustible",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_TipoVehiculos_IdTipoVehiculo",
                        column: x => x.IdTipoVehiculo,
                        principalTable: "TipoVehiculos",
                        principalColumn: "IdTipoVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspecciones",
                columns: table => new
                {
                    IdTransaccion = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdVehiculo = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    IdEmpleado = table.Column<int>(nullable: false),
                    Ralladura = table.Column<bool>(nullable: false),
                    GomaRepuesta = table.Column<bool>(nullable: false),
                    Gato = table.Column<bool>(nullable: false),
                    RoturaCristal = table.Column<bool>(nullable: false),
                    PrimeraGoma = table.Column<bool>(nullable: false),
                    SegundaGoma = table.Column<bool>(nullable: false),
                    TerceraGoma = table.Column<bool>(nullable: false),
                    CuartaGoma = table.Column<bool>(nullable: false),
                    CantidadCombustible = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspecciones", x => x.IdTransaccion);
                    table.ForeignKey(
                        name: "FK_Inspecciones_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspecciones_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspecciones_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentasDevoluciones",
                columns: table => new
                {
                    IdRenta = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    IdEmpleado = table.Column<string>(nullable: false),
                    IdVehiculo = table.Column<string>(nullable: false),
                    FechaRenta = table.Column<DateTime>(nullable: false),
                    FechaDevolucion = table.Column<DateTime>(nullable: false),
                    MontoDiario = table.Column<int>(nullable: false),
                    CantidadDias = table.Column<int>(nullable: false),
                    Comentario = table.Column<string>(type: "varchar(200)", nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    EmpleadoIdEmpleado = table.Column<int>(nullable: true),
                    VehiculoIdVehiculo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentasDevoluciones", x => x.IdRenta);
                    table.ForeignKey(
                        name: "FK_RentasDevoluciones_Empleados_EmpleadoIdEmpleado",
                        column: x => x.EmpleadoIdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentasDevoluciones_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentasDevoluciones_Vehiculos_VehiculoIdVehiculo",
                        column: x => x.VehiculoIdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdTipoPersona",
                table: "Clientes",
                column: "IdTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdTanda",
                table: "Empleados",
                column: "IdTanda");

            migrationBuilder.CreateIndex(
                name: "IX_Inspecciones_IdCliente",
                table: "Inspecciones",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Inspecciones_IdEmpleado",
                table: "Inspecciones",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Inspecciones_IdVehiculo",
                table: "Inspecciones",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_IdMarca",
                table: "Modelos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_EmpleadoIdEmpleado",
                table: "RentasDevoluciones",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_IdCliente",
                table: "RentasDevoluciones",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_VehiculoIdVehiculo",
                table: "RentasDevoluciones",
                column: "VehiculoIdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdMarca",
                table: "Vehiculos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdModelo",
                table: "Vehiculos",
                column: "IdModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdTipoCombustible",
                table: "Vehiculos",
                column: "IdTipoCombustible");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdTipoVehiculo",
                table: "Vehiculos",
                column: "IdTipoVehiculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspecciones");

            migrationBuilder.DropTable(
                name: "RentasDevoluciones");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Tandas");

            migrationBuilder.DropTable(
                name: "TipoPersonas");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "TipoCombustibles");

            migrationBuilder.DropTable(
                name: "TipoVehiculos");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
