using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaVeterinaria.App.Persistencia.Migrations
{
    public partial class CambioStringTelef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Caballo",
                table: "Personas");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Personas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Id_Caballo",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
