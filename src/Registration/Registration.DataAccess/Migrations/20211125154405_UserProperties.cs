using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registration.DataAccess.Migrations
{
    public partial class UserProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                schema: "dbo",
                table: "User",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                schema: "dbo",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FatherName",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "dbo",
                table: "User");
        }
    }
}
