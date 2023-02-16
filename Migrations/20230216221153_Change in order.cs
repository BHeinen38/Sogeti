using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baileys_Order_API.Migrations
{
    public partial class Changeinorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");
        }
    }
}
