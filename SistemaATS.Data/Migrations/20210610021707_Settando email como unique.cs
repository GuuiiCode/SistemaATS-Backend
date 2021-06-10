using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaATS.Data.Migrations
{
    public partial class Settandoemailcomounique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_email",
                table: "Candidatos",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Candidatos_email",
                table: "Candidatos");
        }
    }
}
