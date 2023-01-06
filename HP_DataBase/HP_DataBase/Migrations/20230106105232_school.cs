using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPDataBase.Migrations
{
    /// <inheritdoc />
    public partial class school : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShoolNames",
                table: "Faculties",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoolNames",
                table: "Faculties");
        }
    }
}
