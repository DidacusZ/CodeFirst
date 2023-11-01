using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFist_1.Migrations
{
    /// <inheritdoc />
    public partial class _3m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_usuario",
                table: "Prestamos");

            migrationBuilder.AlterColumn<int>(
                name: "id_prestamo",
                table: "Prestamos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    id_libro = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    isbn_libro = table.Column<string>(type: "text", nullable: false),
                    titulo_libro = table.Column<string>(type: "text", nullable: false),
                    edicion_libro = table.Column<string>(type: "text", nullable: false),
                    id_editorial = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_coleccion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.id_libro);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_id_libro",
                table: "Prestamos",
                column: "id_libro");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_prestamo",
                table: "Prestamos",
                column: "id_prestamo",
                principalTable: "Estados_Prestamos",
                principalColumn: "id_estado_prestamo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Libros_id_libro",
                table: "Prestamos",
                column: "id_libro",
                principalTable: "Libros",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_prestamo",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Libros_id_libro",
                table: "Prestamos");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Prestamos_id_libro",
                table: "Prestamos");

            migrationBuilder.AlterColumn<int>(
                name: "id_prestamo",
                table: "Prestamos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_usuario",
                table: "Prestamos",
                column: "id_usuario",
                principalTable: "Estados_Prestamos",
                principalColumn: "id_estado_prestamo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
