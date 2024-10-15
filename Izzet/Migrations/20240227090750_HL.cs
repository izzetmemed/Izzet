using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Izzet.Migrations
{
    public partial class HL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Todo",
                table: "Todo",
                newName: "OwnNumber");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddTime",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Todo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerNumber",
                table: "Todo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerPrice",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedId",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HomeLandKod",
                table: "Todo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HomePrice",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kod",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OwnName",
                table: "Todo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OwnPrice",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddTime",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "CustomerNumber",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "CustomerPrice",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "DeletedId",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "HomeLandKod",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "HomePrice",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "Kod",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "OwnName",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "OwnPrice",
                table: "Todo");

            migrationBuilder.RenameColumn(
                name: "OwnNumber",
                table: "Todo",
                newName: "Todo");
        }
    }
}
