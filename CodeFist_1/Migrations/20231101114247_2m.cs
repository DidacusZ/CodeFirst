using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFist_1.Migrations
{
    /// <inheritdoc />
    public partial class _2m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados_Prestamos",
                columns: table => new
                {
                    id_estado_prestamo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    codigo_estado_prestamo = table.Column<string>(type: "text", nullable: false),
                    descripcion_estado_prestamo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Prestamos", x => x.id_estado_prestamo);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_usuario",
                table: "Prestamos",
                column: "id_usuario",
                principalTable: "Estados_Prestamos",
                principalColumn: "id_estado_prestamo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_usuario",
                table: "Prestamos");

            migrationBuilder.DropTable(
                name: "Estados_Prestamos");
        }
    }
}
