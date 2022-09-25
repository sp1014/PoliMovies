﻿// <auto-generated />
using System;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api_Movies.Migrations
{
    [DbContext(typeof(UsersContext))]
    partial class UsersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api_Movies.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<string>("NameCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdMovie");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Api_Movies.Models.Colections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colectionses");
                });

            modelBuilder.Entity("Api_Movies.Models.DetailRental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRental")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdRental");

                    b.HasIndex("IdUser");

                    b.ToTable("DetailRentales");
                });

            modelBuilder.Entity("Api_Movies.Models.DetailSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdSale")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdSale");

                    b.HasIndex("IdUser");

                    b.ToTable("DetailSales");
                });

            modelBuilder.Entity("Api_Movies.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Archivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Api_Movies.Models.Idiom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Doblaje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<string>("Lenguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdMovie");

                    b.ToTable("Idioms");
                });

            modelBuilder.Entity("Api_Movies.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Api_Movies.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateProduction")
                        .HasColumnType("datetime2");

                    b.Property<string>("Directors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdColections")
                        .HasColumnType("int");

                    b.Property<int>("IdFile")
                        .HasColumnType("int");

                    b.Property<int>("IdQualification")
                        .HasColumnType("int");

                    b.Property<int>("IdRental")
                        .HasColumnType("int");

                    b.Property<int>("IdSale")
                        .HasColumnType("int");

                    b.Property<int>("IdSerie")
                        .HasColumnType("int");

                    b.Property<string>("Producers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleMovie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdColections");

                    b.HasIndex("IdFile");

                    b.HasIndex("IdQualification");

                    b.HasIndex("IdRental");

                    b.HasIndex("IdSale");

                    b.HasIndex("IdSerie");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Api_Movies.Models.Pqr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Pqrs");
                });

            modelBuilder.Entity("Api_Movies.Models.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Commentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualifications")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("Api_Movies.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEndRental")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateInitRental")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceRental")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rentales");
                });

            modelBuilder.Entity("Api_Movies.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Api_Movies.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("totalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Api_Movies.Models.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("season")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("Api_Movies.Models.TypeDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameTypeDoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeDocs");
                });

            modelBuilder.Entity("Api_Movies.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Doc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdTypeDoc")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdTypeDoc");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Api_Movies.Models.Category", b =>
                {
                    b.HasOne("Api_Movies.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Movies.Models.DetailRental", b =>
                {
                    b.HasOne("Api_Movies.Models.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("IdRental")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Movies.Models.DetailSale", b =>
                {
                    b.HasOne("Api_Movies.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("IdSale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Movies.Models.Idiom", b =>
                {
                    b.HasOne("Api_Movies.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Movies.Models.Movie", b =>
                {
                    b.HasOne("Api_Movies.Models.Colections", "Colections")
                        .WithMany()
                        .HasForeignKey("IdColections")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.File", "File")
                        .WithMany()
                        .HasForeignKey("IdFile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("IdQualification")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("IdRental")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("IdSale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.Serie", "Serie")
                        .WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Movies.Models.Pqr", b =>
                {
                    b.HasOne("Api_Movies.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Movies.Models.User", b =>
                {
                    b.HasOne("Api_Movies.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Movies.Models.TypeDoc", "TypeDoc")
                        .WithMany()
                        .HasForeignKey("IdTypeDoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
