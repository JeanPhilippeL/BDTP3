using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using app.persistence;

namespace app.persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170518210729_db")]
    partial class db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.2");

            modelBuilder.Entity("app.domain.artiste.Artiste", b =>
                {
                    b.Property<int>("ID_ARTISTE")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("NAS");

                    b.Property<string>("NOM_ARTISTE")
                        .IsRequired();

                    b.Property<string>("NOM_DE_SCENE");

                    b.Property<string>("PRENOM_ARTISTE")
                        .IsRequired();

                    b.Property<string>("TELEPHONE")
                        .IsRequired();

                    b.HasKey("ID_ARTISTE");

                    b.ToTable("Artiste");
                });

            modelBuilder.Entity("app.domain.client.Client", b =>
                {
                    b.Property<int>("ID_CLEINT")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NOM_CLIENT")
                        .IsRequired();

                    b.Property<string>("REFERENCE");

                    b.Property<string>("TELEPHONE_CLIENT")
                        .IsRequired();

                    b.HasKey("ID_CLEINT");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("app.domain.contrat.Contrat", b =>
                {
                    b.Property<int>("ID_CONTRAT")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CACHET_OFFERT");

                    b.Property<DateTime>("DATE_PRESTATION");

                    b.Property<string>("HEURE_DEBUT")
                        .IsRequired();

                    b.Property<string>("HEURE_FIN")
                        .IsRequired();

                    b.Property<int>("ID_CLEINT");

                    b.HasKey("ID_CONTRAT");

                    b.HasIndex("ID_CLEINT");

                    b.ToTable("Contrat");
                });

            modelBuilder.Entity("app.domain.facture.Facture", b =>
                {
                    b.Property<int>("ID_CLEINT")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DATE_DE_PRODUCTION");

                    b.HasKey("ID_CLEINT");

                    b.ToTable("Facture");
                });

            modelBuilder.Entity("app.domain.groupe.Groupe", b =>
                {
                    b.Property<string>("CACHET_SOUHAITER");

                    b.HasKey("CACHET_SOUHAITER");

                    b.ToTable("Groupe");
                });

            modelBuilder.Entity("app.domain.membre.Membre", b =>
                {
                    b.Property<string>("ROLE");

                    b.HasKey("ROLE");

                    b.ToTable("Membre");
                });

            modelBuilder.Entity("app.domain.contrat.Contrat", b =>
                {
                    b.HasOne("app.domain.client.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ID_CLEINT")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
