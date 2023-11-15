using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotels.Migrations
{
    /// <inheritdoc />
    public partial class FirMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_invoices",
                table: "invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hotle",
                table: "hotle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carts",
                table: "carts");

            migrationBuilder.RenameTable(
                name: "invoices",
                newName: "invoice");

            migrationBuilder.RenameTable(
                name: "hotle",
                newName: "hotles");

            migrationBuilder.RenameTable(
                name: "carts",
                newName: "cart");

            migrationBuilder.AlterColumn<string>(
                name: "Food",
                table: "roomDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "hotles",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "hotles",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invoice",
                table: "invoice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hotles",
                table: "hotles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cart",
                table: "cart",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_invoice",
                table: "invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hotles",
                table: "hotles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cart",
                table: "cart");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "hotles");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "hotles");

            migrationBuilder.RenameTable(
                name: "invoice",
                newName: "invoices");

            migrationBuilder.RenameTable(
                name: "hotles",
                newName: "hotle");

            migrationBuilder.RenameTable(
                name: "cart",
                newName: "carts");

            migrationBuilder.AlterColumn<string>(
                name: "Food",
                table: "roomDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_invoices",
                table: "invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hotle",
                table: "hotle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carts",
                table: "carts",
                column: "Id");
        }
    }
}
