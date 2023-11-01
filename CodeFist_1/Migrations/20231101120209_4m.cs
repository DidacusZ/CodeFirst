using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFist_1.Migrations
{
    /// <inheritdoc />
    public partial class _4m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colecciones",
                columns: table => new
                {
                    id_coleccion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_coleccion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colecciones", x => x.id_coleccion);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_id_coleccion",
                table: "Libros",
                column: "id_coleccion");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Colecciones_id_coleccion",
                table: "Libros",
                column: "id_coleccion",
                principalTable: "Colecciones",
                principalColumn: "id_coleccion",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Colecciones_id_coleccion",
                table: "Libros");

            migrationBuilder.DropTable(
                name: "Colecciones");

            migrationBuilder.DropIndex(
                name: "IX_Libros_id_coleccion",
                table: "Libros");
        }
    }
}
