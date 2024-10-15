using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Izzet.Migrations
{
    public partial class WinForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Todo",
                table: "Todo");

            migrationBuilder.RenameTable(
                name: "Todo",
                newName: "WinForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WinForm",
                table: "WinForm",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WinForm",
                table: "WinForm");

            migrationBuilder.RenameTable(
                name: "WinForm",
                newName: "Todo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todo",
                table: "Todo",
                column: "Id");
        }
    }
}
