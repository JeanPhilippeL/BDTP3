using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using app.persistence;

namespace app.persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170518165715_db")]
    partial class db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.2");

            modelBuilder.Entity("app.domain.artiste.Artiste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("NAS");

                    b.Property<string>("NOM_ARTISTE");

                    b.Property<string>("NOM_DE_SCENE");

                    b.Property<string>("PRENOM_ARTISTE");

                    b.Property<string>("TELEPHONE");

                    b.HasKey("Id");

                    b.ToTable("Artiste");
                });

            modelBuilder.Entity("app.domain.client.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("app.domain.contrat.Contrat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Contrat");
                });

            modelBuilder.Entity("app.domain.facture.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Facture");
                });

            modelBuilder.Entity("app.domain.groupe.Groupe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Groupe");
                });

            modelBuilder.Entity("app.domain.membre.Membre", b =>
                {
                    b.Property<string>("ROLE");

                    b.HasKey("ROLE");

                    b.ToTable("Membre");
                });
        }
    }
}
