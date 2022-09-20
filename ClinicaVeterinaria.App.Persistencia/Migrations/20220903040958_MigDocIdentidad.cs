using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaVeterinaria.App.Persistencia.Migrations
{
    public partial class MigDocIdentidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DocIdentidad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocIdentidad",
                table: "Personas");
        }
    }
}
