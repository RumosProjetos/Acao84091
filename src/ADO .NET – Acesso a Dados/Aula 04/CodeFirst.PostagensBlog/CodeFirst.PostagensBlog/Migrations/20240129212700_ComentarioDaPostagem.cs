using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.PostagensBlog.Migrations
{
    /// <inheritdoc />
    public partial class ComentarioDaPostagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostagemId",
                table: "Comentarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PostagemId",
                table: "Comentarios",
                column: "PostagemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Postagens_PostagemId",
                table: "Comentarios",
                column: "PostagemId",
                principalTable: "Postagens",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Postagens_PostagemId",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_PostagemId",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "PostagemId",
                table: "Comentarios");
        }
    }
}
