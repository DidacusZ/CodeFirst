using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFist_1.Migrations
{
    /// <inheritdoc />
    public partial class _9m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Libros_id_libro",
                table: "Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Prestamos_id_libro",
                table: "Prestamos");

            migrationBuilder.AddColumn<int>(
                name: "Libroid_libro",
                table: "Prestamos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cantidad_libro",
                table: "Prestamos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Rel_Libros_Prestamos",
                columns: table => new
                {
                    id_rel_libros_prestamos = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    id_libro = table.Column<int>(type: "integer", nullable: false),
                    id_prestamo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_Libros_Prestamos", x => x.id_rel_libros_prestamos);
                    table.ForeignKey(
                        name: "FK_Rel_Libros_Prestamos_Libros_id_libro",
                        column: x => x.id_libro,
                        principalTable: "Libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rel_Libros_Prestamos_Prestamos_id_prestamo",
                        column: x => x.id_prestamo,
                        principalTable: "Prestamos",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_Libroid_libro",
                table: "Prestamos",
                column: "Libroid_libro");

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Libros_Prestamos_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Libros_Prestamos_id_prestamo",
                table: "Rel_Libros_Prestamos",
                column: "id_prestamo");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Libros_Libroid_libro",
                table: "Prestamos",
                column: "Libroid_libro",
                principalTable: "Libros",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Libros_Libroid_libro",
                table: "Prestamos");

            migrationBuilder.DropTable(
                name: "Rel_Libros_Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Prestamos_Libroid_libro",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "Libroid_libro",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "cantidad_libro",
                table: "Prestamos");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_id_libro",
                table: "Prestamos",
                column: "id_libro");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Libros_id_libro",
                table: "Prestamos",
                column: "id_libro",
                principalTable: "Libros",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
