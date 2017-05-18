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
                name: "Groupe",
                columns: table => new
                {
                    NOM_DU_GROUPE = table.Column<string>(nullable: false),
                    CACHET_SOUHAITER = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupe", x => x.NOM_DU_GROUPE);
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
                    ID_CLEINT = table.Column<int>(nullable: false),
                    NOM_DU_GROUPE = table.Column<string>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Contrat_Groupe_NOM_DU_GROUPE",
                        column: x => x.NOM_DU_GROUPE,
                        principalTable: "Groupe",
                        principalColumn: "NOM_DU_GROUPE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Membre",
                columns: table => new
                {
                    ROLE = table.Column<string>(nullable: false),
                    ID_ARTISTE = table.Column<int>(nullable: false),
                    NOM_DU_GROUPE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membre", x => x.ROLE);
                    table.ForeignKey(
                        name: "FK_Membre_Artiste_ID_ARTISTE",
                        column: x => x.ID_ARTISTE,
                        principalTable: "Artiste",
                        principalColumn: "ID_ARTISTE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Membre_Groupe_NOM_DU_GROUPE",
                        column: x => x.NOM_DU_GROUPE,
                        principalTable: "Groupe",
                        principalColumn: "NOM_DU_GROUPE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    ID_CLEINT = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    DATE_DE_PRODUCTION = table.Column<DateTime>(nullable: false),
                    ID_CONTRAT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.ID_CLEINT);
                    table.ForeignKey(
                        name: "FK_Facture_Contrat_ID_CONTRAT",
                        column: x => x.ID_CONTRAT,
                        principalTable: "Contrat",
                        principalColumn: "ID_CONTRAT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrat_ID_CLEINT",
                table: "Contrat",
                column: "ID_CLEINT");

            migrationBuilder.CreateIndex(
                name: "IX_Contrat_NOM_DU_GROUPE",
                table: "Contrat",
                column: "NOM_DU_GROUPE");

            migrationBuilder.CreateIndex(
                name: "IX_Facture_ID_CONTRAT",
                table: "Facture",
                column: "ID_CONTRAT");

            migrationBuilder.CreateIndex(
                name: "IX_Membre_ID_ARTISTE",
                table: "Membre",
                column: "ID_ARTISTE");

            migrationBuilder.CreateIndex(
                name: "IX_Membre_NOM_DU_GROUPE",
                table: "Membre",
                column: "NOM_DU_GROUPE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "Membre");

            migrationBuilder.DropTable(
                name: "Contrat");

            migrationBuilder.DropTable(
                name: "Artiste");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Groupe");
        }
    }
}
