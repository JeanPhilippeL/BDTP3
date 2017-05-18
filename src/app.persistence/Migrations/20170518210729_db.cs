using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.persistence.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artiste",
                columns: table => new
                {
                    ID_ARTISTE = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    NAS = table.Column<long>(nullable: false),
                    NOM_ARTISTE = table.Column<string>(nullable: false),
                    NOM_DE_SCENE = table.Column<string>(nullable: true),
                    PRENOM_ARTISTE = table.Column<string>(nullable: false),
                    TELEPHONE = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artiste", x => x.ID_ARTISTE);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID_CLEINT = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    NOM_CLIENT = table.Column<string>(nullable: false),
                    REFERENCE = table.Column<string>(nullable: true),
                    TELEPHONE_CLIENT = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID_CLEINT);
                });

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    ID_CLEINT = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    DATE_DE_PRODUCTION = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.ID_CLEINT);
                });

            migrationBuilder.CreateTable(
                name: "Groupe",
                columns: table => new
                {
                    CACHET_SOUHAITER = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupe", x => x.CACHET_SOUHAITER);
                });

            migrationBuilder.CreateTable(
                name: "Membre",
                columns: table => new
                {
                    ROLE = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membre", x => x.ROLE);
                });

            migrationBuilder.CreateTable(
                name: "Contrat",
                columns: table => new
                {
                    ID_CONTRAT = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    CACHET_OFFERT = table.Column<int>(nullable: false),
                    DATE_PRESTATION = table.Column<DateTime>(nullable: false),
                    HEURE_DEBUT = table.Column<string>(nullable: false),
                    HEURE_FIN = table.Column<string>(nullable: false),
                    ID_CLEINT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrat", x => x.ID_CONTRAT);
                    table.ForeignKey(
                        name: "FK_Contrat_Client_ID_CLEINT",
                        column: x => x.ID_CLEINT,
                        principalTable: "Client",
                        principalColumn: "ID_CLEINT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrat_ID_CLEINT",
                table: "Contrat",
                column: "ID_CLEINT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artiste");

            migrationBuilder.DropTable(
                name: "Contrat");

            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "Groupe");

            migrationBuilder.DropTable(
                name: "Membre");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
