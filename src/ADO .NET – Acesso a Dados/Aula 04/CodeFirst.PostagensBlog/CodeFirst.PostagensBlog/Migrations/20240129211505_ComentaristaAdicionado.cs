using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.PostagensBlog.Migrations
{
    /// <inheritdoc />
    public partial class ComentaristaAdicionado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailComentarista",
                table: "Comentarios");

            migrationBuilder.AddColumn<Guid>(
                name: "ComentaristaId",
                table: "Comentarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Comentaristas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    EmailComentarista = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentaristas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_ComentaristaId",
                table: "Comentarios",
                column: "ComentaristaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Comentaristas_ComentaristaId",
                table: "Comentarios",
                column: "ComentaristaId",
                principalTable: "Comentaristas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Comentaristas_ComentaristaId",
                table: "Comentarios");

            migrationBuilder.DropTable(
                name: "Comentaristas");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_ComentaristaId",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "ComentaristaId",
                table: "Comentarios");

            migrationBuilder.AddColumn<string>(
                name: "EmailComentarista",
                table: "Comentarios",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
