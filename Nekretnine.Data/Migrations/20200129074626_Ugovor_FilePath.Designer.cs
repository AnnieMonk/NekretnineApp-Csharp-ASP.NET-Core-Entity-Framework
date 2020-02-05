﻿// <auto-generated />
using System;
using Agencija_za_promet_nekretninama.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Nekretnine.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200129074626_Ugovor_FilePath")]
    partial class Ugovor_FilePath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KorisnickiNalogID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlogaID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikID");

                    b.HasIndex("GradID");

                    b.HasIndex("KorisnickiNalogID");

                    b.HasIndex("UlogaID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Nekretnina", b =>
                {
                    b.Property<int>("NekretninaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojSoba")
                        .HasColumnType("int");

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<int>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<double>("Kvadratura")
                        .HasColumnType("float");

                    b.Property<int>("LokacijaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NekretninaID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("LokacijaID");

                    b.ToTable("Nekretnine");
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Oglas", b =>
                {
                    b.Property<int>("OglasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DatumVrijemeObjave")
                        .HasColumnType("datetime2");

                    b.Property<int>("NekretninaID")
                        .HasColumnType("int");

                    b.Property<int>("UposlenikID")
                        .HasColumnType("int");

                    b.Property<int>("vrstaOglasaID")
                        .HasColumnType("int");

                    b.HasKey("OglasID");

                    b.HasIndex("NekretninaID");

                    b.HasIndex("UposlenikID");

                    b.HasIndex("vrstaOglasaID");

                    b.ToTable("Oglas");
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Uposlenik", b =>
                {
                    b.Property<int>("UposlenikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RatingStars")
                        .HasColumnType("float");

                    b.Property<string>("Zvanje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UposlenikID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Uposlenici");
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.VrstaOglasa", b =>
                {
                    b.Property<int>("VrstaOglasaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VrstaOglasaID");

                    b.ToTable("VrsteOglasa");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.AutorizacijskiToken", b =>
                {
                    b.Property<int>("AutorizacijskiTokenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnickiNalogID")
                        .HasColumnType("int");

                    b.Property<string>("Vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("AutorizacijskiTokenID");

                    b.HasIndex("KorisnickiNalogID");

                    b.ToTable("Tokeni");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Karakteristike", b =>
                {
                    b.Property<int>("KarakteristikeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KarakteristikeID");

                    b.ToTable("Karakteristike");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Kategorija", b =>
                {
                    b.Property<int>("KategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategorijaNaziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaID");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("KorisnickiNalogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ZapamtiMe")
                        .HasColumnType("bit");

                    b.HasKey("KorisnickiNalogID");

                    b.ToTable("KorisnickiNalozi");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Lokacija", b =>
                {
                    b.Property<int>("LokacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LokacijaID");

                    b.HasIndex("GradID");

                    b.ToTable("Lokacije");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.NacinPlacanja", b =>
                {
                    b.Property<int>("NacinPlacanjaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NacinPlacanjaID");

                    b.ToTable("NaciniPlacanja");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.NekretninaKarakteristike", b =>
                {
                    b.Property<int>("NekretninaKarakteristikeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KarakteristikeID")
                        .HasColumnType("int");

                    b.Property<int>("NekretninaID")
                        .HasColumnType("int");

                    b.HasKey("NekretninaKarakteristikeID");

                    b.HasIndex("KarakteristikeID");

                    b.HasIndex("NekretninaID");

                    b.ToTable("NekretninaKarakteristike");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Notifikacija", b =>
                {
                    b.Property<int>("NotifikacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumNotifikacije")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("ObilazakID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextNotifikacije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UposlenikID")
                        .HasColumnType("int");

                    b.Property<bool>("Vidjeno")
                        .HasColumnType("bit");

                    b.HasKey("NotifikacijaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ObilazakID");

                    b.HasIndex("UposlenikID");

                    b.ToTable("Notifikacije");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Obilazak", b =>
                {
                    b.Property<int>("ObilazakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVrijemeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVrijemeStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("LokacijaID")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NekretninaID")
                        .HasColumnType("int");

                    b.Property<bool>("Otkazano")
                        .HasColumnType("bit");

                    b.Property<int>("UposlenikID")
                        .HasColumnType("int");

                    b.Property<bool>("Zavrseno")
                        .HasColumnType("bit");

                    b.HasKey("ObilazakID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("LokacijaID");

                    b.HasIndex("NekretninaID");

                    b.HasIndex("UposlenikID");

                    b.ToTable("Obilasci");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Slike", b =>
                {
                    b.Property<Guid>("SlikeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ekstenzija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NekretninaID")
                        .HasColumnType("int");

                    b.HasKey("SlikeID");

                    b.HasIndex("NekretninaID");

                    b.ToTable("Slike");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Ugovor", b =>
                {
                    b.Property<int>("UgovorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("NekretninaID")
                        .HasColumnType("int");

                    b.Property<string>("Oznaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UposlenikID")
                        .HasColumnType("int");

                    b.Property<int>("VrstaUgovoraID")
                        .HasColumnType("int");

                    b.HasKey("UgovorID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("NekretninaID");

                    b.HasIndex("UposlenikID");

                    b.HasIndex("VrstaUgovoraID");

                    b.ToTable("Ugovori");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Uloga", b =>
                {
                    b.Property<int>("UlogaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaID");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Uplata", b =>
                {
                    b.Property<int>("UplataID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DogDatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Kasnjenje")
                        .HasColumnType("bit");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<double?>("MjesecnaRata")
                        .HasColumnType("float");

                    b.Property<int>("NacinPlacanjaID")
                        .HasColumnType("int");

                    b.Property<int>("NekretninaID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RealDatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UgovorID")
                        .HasColumnType("int");

                    b.Property<double>("UkupanIznosBezPDV")
                        .HasColumnType("float");

                    b.Property<double>("UkupanIznosPDV")
                        .HasColumnType("float");

                    b.Property<int>("UposlenikID")
                        .HasColumnType("int");

                    b.HasKey("UplataID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("NacinPlacanjaID");

                    b.HasIndex("NekretninaID");

                    b.HasIndex("UgovorID");

                    b.HasIndex("UposlenikID");

                    b.ToTable("Uplate");
                });

            modelBuilder.Entity("Nekretnine.Data.Models.VrstaUgovora", b =>
                {
                    b.Property<int>("VrstaUgovoraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VrstaUgovoraID");

                    b.ToTable("VrsteUgovora");
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Korisnik", b =>
                {
                    b.HasOne("Nekretnine.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nekretnine.Data.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogID");

                    b.HasOne("Nekretnine.Data.Models.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Nekretnina", b =>
                {
                    b.HasOne("Nekretnine.Data.Models.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nekretnine.Data.Models.Lokacija", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Oglas", b =>
                {
                    b.HasOne("Agencija_za_promet_nekretninama.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.VrstaOglasa", "vrstaOglasa")
                        .WithMany()
                        .HasForeignKey("vrstaOglasaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Agencija_za_promet_nekretninama.Models.Uposlenik", b =>
                {
                    b.HasOne("Agencija_za_promet_nekretninama.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.AutorizacijskiToken", b =>
                {
                    b.HasOne("Nekretnine.Data.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Grad", b =>
                {
                    b.HasOne("Nekretnine.Data.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Lokacija", b =>
                {
                    b.HasOne("Nekretnine.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.NekretninaKarakteristike", b =>
                {
                    b.HasOne("Nekretnine.Data.Models.Karakteristike", "Karakteristike")
                        .WithMany()
                        .HasForeignKey("KarakteristikeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Notifikacija", b =>
                {
                    b.HasOne("Agencija_za_promet_nekretninama.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nekretnine.Data.Models.Obilazak", "Obilazak")
                        .WithMany()
                        .HasForeignKey("ObilazakID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Obilazak", b =>
                {
                    b.HasOne("Agencija_za_promet_nekretninama.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nekretnine.Data.Models.Lokacija", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Slike", b =>
                {
                    b.HasOne("Agencija_za_promet_nekretninama.Models.Nekretnina", "Nekretnina")
                        .WithMany("Slike")
                        .HasForeignKey("NekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Ugovor", b =>
                {
                    b.HasOne("Agencija_za_promet_nekretninama.Models.Korisnik", "Kupac")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nekretnine.Data.Models.VrstaUgovora", "VrstaUgovora")
                        .WithMany()
                        .HasForeignKey("VrstaUgovoraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nekretnine.Data.Models.Uplata", b =>
                {
                    b.HasOne("Agencija_za_promet_nekretninama.Models.Korisnik", "Kupac")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nekretnine.Data.Models.NacinPlacanja", "NacinPlacanja")
                        .WithMany()
                        .HasForeignKey("NacinPlacanjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nekretnine.Data.Models.Ugovor", "Ugovor")
                        .WithMany()
                        .HasForeignKey("UgovorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agencija_za_promet_nekretninama.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}