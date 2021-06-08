using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaATS.Data.Migrations
{
    public partial class Exclusãodaentidadeendereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatos_Enderecos_endereco_id",
                table: "Candidatos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Candidatos_endereco_id",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "endereco_id",
                table: "Candidatos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "endereco_id",
                table: "Candidatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bairro = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    rua = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_endereco_id",
                table: "Candidatos",
                column: "endereco_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatos_Enderecos_endereco_id",
                table: "Candidatos",
                column: "endereco_id",
                principalTable: "Enderecos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
