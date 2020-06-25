using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Migrations
{
    public partial class RentCarMig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentasDevoluciones_Empleados_EmpleadoIdEmpleado",
                table: "RentasDevoluciones");

            migrationBuilder.DropIndex(
                name: "IX_RentasDevoluciones_EmpleadoIdEmpleado",
                table: "RentasDevoluciones");

            migrationBuilder.DropColumn(
                name: "EmpleadoIdEmpleado",
                table: "RentasDevoluciones");

            migrationBuilder.AlterColumn<int>(
                name: "IdEmpleado",
                table: "RentasDevoluciones",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_IdEmpleado",
                table: "RentasDevoluciones",
                column: "IdEmpleado");

            migrationBuilder.AddForeignKey(
                name: "FK_RentasDevoluciones_Empleados_IdEmpleado",
                table: "RentasDevoluciones",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentasDevoluciones_Empleados_IdEmpleado",
                table: "RentasDevoluciones");

            migrationBuilder.DropIndex(
                name: "IX_RentasDevoluciones_IdEmpleado",
                table: "RentasDevoluciones");

            migrationBuilder.AlterColumn<string>(
                name: "IdEmpleado",
                table: "RentasDevoluciones",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoIdEmpleado",
                table: "RentasDevoluciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_EmpleadoIdEmpleado",
                table: "RentasDevoluciones",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.AddForeignKey(
                name: "FK_RentasDevoluciones_Empleados_EmpleadoIdEmpleado",
                table: "RentasDevoluciones",
                column: "EmpleadoIdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
