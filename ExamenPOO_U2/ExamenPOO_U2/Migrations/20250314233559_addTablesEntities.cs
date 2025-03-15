using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenPOO_U2.Migrations
{
    /// <inheritdoc />
    public partial class addTablesEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "detalle_planilla",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    salario_base = table.Column<decimal>(type: "TEXT", nullable: false),
                    horas_extra = table.Column<decimal>(type: "TEXT", nullable: false),
                    monto_horas_extra = table.Column<decimal>(type: "TEXT", nullable: false),
                    bonificaciones = table.Column<decimal>(type: "TEXT", nullable: false),
                    deducciones = table.Column<decimal>(type: "TEXT", nullable: false),
                    salario_neto = table.Column<decimal>(type: "TEXT", nullable: false),
                    comentarios = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_planilla", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    last_name = table.Column<string>(type: "TEXT", nullable: false),
                    document = table.Column<string>(type: "TEXT", nullable: false),
                    date_contratacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    department = table.Column<string>(type: "TEXT", nullable: true),
                    job_position = table.Column<int>(type: "INTEGER", nullable: false),
                    base_salary = table.Column<decimal>(type: "TEXT", nullable: false),
                    active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "planilla",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    period = table.Column<string>(type: "TEXT", nullable: false),
                    creation_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    payment_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    state = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planilla", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalle_planilla");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "planilla");
        }
    }
}
