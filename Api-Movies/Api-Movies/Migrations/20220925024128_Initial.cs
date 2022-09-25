using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Movies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colectionses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colectionses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Archivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualifications = table.Column<string>(nullable: true),
                    Commentary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rentales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PriceRental = table.Column<int>(nullable: false),
                    DateInitRental = table.Column<DateTime>(nullable: false),
                    DateEndRental = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(nullable: false),
                    totalPrice = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    season = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDocs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTypeDoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleMovie = table.Column<string>(nullable: true),
                    DateProduction = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    Actors = table.Column<string>(nullable: true),
                    Directors = table.Column<string>(nullable: true),
                    Producers = table.Column<string>(nullable: true),
                    IdRental = table.Column<int>(nullable: false),
                    IdSale = table.Column<int>(nullable: false),
                    IdQualification = table.Column<int>(nullable: false),
                    IdSerie = table.Column<int>(nullable: false),
                    IdFile = table.Column<int>(nullable: false),
                    IdColections = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Colectionses_IdColections",
                        column: x => x.IdColections,
                        principalTable: "Colectionses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Files_IdFile",
                        column: x => x.IdFile,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Qualifications_IdQualification",
                        column: x => x.IdQualification,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Rentales_IdRental",
                        column: x => x.IdRental,
                        principalTable: "Rentales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Sales_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Series_IdSerie",
                        column: x => x.IdSerie,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Doc = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IdRol = table.Column<int>(nullable: false),
                    IdTypeDoc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_TypeDocs_IdTypeDoc",
                        column: x => x.IdTypeDoc,
                        principalTable: "TypeDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(nullable: true),
                    IdMovie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Movies_IdMovie",
                        column: x => x.IdMovie,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idioms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lenguage = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Doblaje = table.Column<string>(nullable: true),
                    IdMovie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Idioms_Movies_IdMovie",
                        column: x => x.IdMovie,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailRentales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdRental = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailRentales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailRentales_Rentales_IdRental",
                        column: x => x.IdRental,
                        principalTable: "Rentales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailRentales_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailSales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdSale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailSales_Sales_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailSales_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pqrs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pqrs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pqrs_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IdMovie",
                table: "Categories",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_DetailRentales_IdRental",
                table: "DetailRentales",
                column: "IdRental");

            migrationBuilder.CreateIndex(
                name: "IX_DetailRentales_IdUser",
                table: "DetailRentales",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSales_IdSale",
                table: "DetailSales",
                column: "IdSale");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSales_IdUser",
                table: "DetailSales",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Idioms_IdMovie",
                table: "Idioms",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_IdColections",
                table: "Movies",
                column: "IdColections");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_IdFile",
                table: "Movies",
                column: "IdFile");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_IdQualification",
                table: "Movies",
                column: "IdQualification");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_IdRental",
                table: "Movies",
                column: "IdRental");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_IdSale",
                table: "Movies",
                column: "IdSale");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_IdSerie",
                table: "Movies",
                column: "IdSerie");

            migrationBuilder.CreateIndex(
                name: "IX_Pqrs_IdUser",
                table: "Pqrs",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdRol",
                table: "Users",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdTypeDoc",
                table: "Users",
                column: "IdTypeDoc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "DetailRentales");

            migrationBuilder.DropTable(
                name: "DetailSales");

            migrationBuilder.DropTable(
                name: "Idioms");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Pqrs");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Colectionses");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Rentales");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TypeDocs");
        }
    }
}
