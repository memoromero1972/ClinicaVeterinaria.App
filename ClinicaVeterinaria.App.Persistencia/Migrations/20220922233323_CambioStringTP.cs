using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaVeterinaria.App.Persistencia.Migrations
{
    public partial class CambioStringTP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Num_Tarjeta_Profesional",
                table: "Personas");

            migrationBuilder.AddColumn<string>(
                name: "TarjetaProf",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TarjetaProf",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "Num_Tarjeta_Profesional",
                table: "Personas",
                type: "int",
                nullable: true);
        }
    }
}
