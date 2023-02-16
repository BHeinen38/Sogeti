using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baileys_Order_API.Migrations
{
    public partial class addinginvoicenumberforgottosave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceNumber",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "Orders");
        }
    }
}
