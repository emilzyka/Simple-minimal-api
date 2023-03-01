using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangedItemsDbModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Borrower",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "BorrowerDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IsBorrowable",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Pages",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                type: "TEXT",
                maxLength: 10000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Developer",
                table: "Item",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Item",
                type: "INTEGER",
                maxLength: 1000,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Mode",
                table: "Item",
                type: "TEXT",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Item",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Item",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Release",
                table: "Item",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Developer",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Mode",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Release",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Item",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Borrower",
                table: "Item",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BorrowerDate",
                table: "Item",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBorrowable",
                table: "Item",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "Item",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
