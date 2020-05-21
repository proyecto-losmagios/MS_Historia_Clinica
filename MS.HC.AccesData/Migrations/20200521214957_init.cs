using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MS.HC.AccesData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    HistoriaClinicaId = table.Column<Guid>(nullable: false),
                    PacienteId = table.Column<Guid>(nullable: false),
                    MedicoId = table.Column<Guid>(nullable: false),
                    TurnoId = table.Column<Guid>(nullable: false),
                    DetalleDeConsulta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.HistoriaClinicaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriasClinicas");
        }
    }
}
