using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bootcamp_MVC_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddUuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uuid",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Uuid",
                table: "Departments",
                column: "Uuid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_Uuid",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Uuid",
                table: "Departments");
        }
    }
}
