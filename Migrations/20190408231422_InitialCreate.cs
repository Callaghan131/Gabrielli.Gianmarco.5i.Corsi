using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gabrielli.gianmarco._5i.Corsi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ambiti",
                columns: table => new
                {
                    AmbitoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeAmbito = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ambiti", x => x.AmbitoId);
                });

            migrationBuilder.CreateTable(
                name: "corsi",
                columns: table => new
                {
                    CorsoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descrizione = table.Column<string>(nullable: true),
                    GiornoSettimana = table.Column<string>(nullable: true),
                    OraInizio = table.Column<DateTime>(nullable: false),
                    OraFine = table.Column<DateTime>(nullable: false),
                    Prezzo = table.Column<float>(nullable: false),
                    NumeroMaxPartecipanti = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_corsi", x => x.CorsoId);
                });

            migrationBuilder.CreateTable(
                name: "docenti",
                columns: table => new
                {
                    DocenteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Cognome = table.Column<string>(nullable: true),
                    DatadiNascita = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_docenti", x => x.DocenteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ambiti");

            migrationBuilder.DropTable(
                name: "corsi");

            migrationBuilder.DropTable(
                name: "docenti");
        }
    }
}
