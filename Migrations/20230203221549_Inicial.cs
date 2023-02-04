using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registro.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: false),
                    direccion = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    nacimiento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    telefono = table.Column<string>(type: "TEXT", nullable: true),
                    balance = table.Column<long>(type: "INTEGER", nullable: true),
                    ocupaciones = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    vence = table.Column<DateTime>(type: "TEXT", nullable: true),
                    concepto = table.Column<string>(type: "TEXT", nullable: true),
                    monto = table.Column<long>(type: "INTEGER", nullable: true),
                    personaid = table.Column<int>(type: "INTEGER", nullable: true),
                    balance = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamosId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Prestamos");
        }
    }
}
