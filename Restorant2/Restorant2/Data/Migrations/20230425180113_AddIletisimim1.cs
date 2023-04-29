using Microsoft.EntityFrameworkCore.Migrations;

namespace Restorant2.Data.Migrations
{
    public partial class AddIletisimim1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Teledon",
                table: "Iletisimims",
                newName: "Telefon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "Iletisimims",
                newName: "Teledon");
        }
    }
}
