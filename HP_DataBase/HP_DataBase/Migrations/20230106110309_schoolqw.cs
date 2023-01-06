using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPDataBase.Migrations
{
    /// <inheritdoc />
    public partial class schoolqw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Faculties_ShoolNames",
                table: "Faculties",
                column: "ShoolNames");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Schools_ShoolNames",
                table: "Faculties",
                column: "ShoolNames",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Schools_ShoolNames",
                table: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_ShoolNames",
                table: "Faculties");
        }
    }
}
