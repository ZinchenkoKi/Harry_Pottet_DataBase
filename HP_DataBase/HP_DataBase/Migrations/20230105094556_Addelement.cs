using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPDataBase.Migrations
{
    /// <inheritdoc />
    public partial class Addelement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfFoundation",
                table: "Faculties");

            migrationBuilder.AddColumn<string>(
                name: "Element",
                table: "Faculties",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Element",
                table: "Faculties");

            migrationBuilder.AddColumn<int>(
                name: "DateOfFoundation",
                table: "Faculties",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
