using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFist_1.Migrations
{
    /// <inheritdoc />
    public partial class _10m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Autores12521523_id_autor",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autores12521523",
                table: "Autores12521523");

            migrationBuilder.RenameTable(
                name: "Autores12521523",
                newName: "Autores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autores",
                table: "Autores",
                column: "id_autor");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Autores_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor",
                principalTable: "Autores",
                principalColumn: "id_autor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Autores_id_autor",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autores",
                table: "Autores");

            migrationBuilder.RenameTable(
                name: "Autores",
                newName: "Autores12521523");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autores12521523",
                table: "Autores12521523",
                column: "id_autor");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Autores12521523_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor",
                principalTable: "Autores12521523",
                principalColumn: "id_autor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
