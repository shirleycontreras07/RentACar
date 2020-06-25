using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Migrations
{
    public partial class RentCarMig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentasDevoluciones_Vehiculos_VehiculoIdVehiculo",
                table: "RentasDevoluciones");

            migrationBuilder.DropIndex(
                name: "IX_RentasDevoluciones_VehiculoIdVehiculo",
                table: "RentasDevoluciones");

            migrationBuilder.DropColumn(
                name: "VehiculoIdVehiculo",
                table: "RentasDevoluciones");

            migrationBuilder.AlterColumn<int>(
                name: "IdVehiculo",
                table: "RentasDevoluciones",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_IdVehiculo",
                table: "RentasDevoluciones",
                column: "IdVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_RentasDevoluciones_Vehiculos_IdVehiculo",
                table: "RentasDevoluciones",
                column: "IdVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "IdVehiculo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentasDevoluciones_Vehiculos_IdVehiculo",
                table: "RentasDevoluciones");

            migrationBuilder.DropIndex(
                name: "IX_RentasDevoluciones_IdVehiculo",
                table: "RentasDevoluciones");

            migrationBuilder.AlterColumn<string>(
                name: "IdVehiculo",
                table: "RentasDevoluciones",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "VehiculoIdVehiculo",
                table: "RentasDevoluciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_VehiculoIdVehiculo",
                table: "RentasDevoluciones",
                column: "VehiculoIdVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_RentasDevoluciones_Vehiculos_VehiculoIdVehiculo",
                table: "RentasDevoluciones",
                column: "VehiculoIdVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "IdVehiculo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
