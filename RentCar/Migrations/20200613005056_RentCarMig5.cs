using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Migrations
{
    public partial class RentCarMig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdInspeccion",
                table: "RentasDevoluciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InspeccionIdTransaccion",
                table: "RentasDevoluciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentasDevoluciones_InspeccionIdTransaccion",
                table: "RentasDevoluciones",
                column: "InspeccionIdTransaccion");

            migrationBuilder.AddForeignKey(
                name: "FK_RentasDevoluciones_Inspecciones_InspeccionIdTransaccion",
                table: "RentasDevoluciones",
                column: "InspeccionIdTransaccion",
                principalTable: "Inspecciones",
                principalColumn: "IdTransaccion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentasDevoluciones_Inspecciones_InspeccionIdTransaccion",
                table: "RentasDevoluciones");

            migrationBuilder.DropIndex(
                name: "IX_RentasDevoluciones_InspeccionIdTransaccion",
                table: "RentasDevoluciones");

            migrationBuilder.DropColumn(
                name: "IdInspeccion",
                table: "RentasDevoluciones");

            migrationBuilder.DropColumn(
                name: "InspeccionIdTransaccion",
                table: "RentasDevoluciones");
        }
    }
}
