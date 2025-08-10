using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Material : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Companies_CompanyId1",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_CompanyId1",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "CompanyId1",
                table: "Materials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId1",
                table: "Materials",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CompanyId1",
                table: "Materials",
                column: "CompanyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Companies_CompanyId1",
                table: "Materials",
                column: "CompanyId1",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
