using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CreateTransportsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.CreateTable(
                name: "Advantages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advantages", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "TransportBans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportBans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportCountryMarkets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportCountryMarkets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportEngines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportEngines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportMarkas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMarkas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportMarkas_TransportMarkas_ParentId",
                        column: x => x.ParentId,
                        principalTable: "TransportMarkas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportMotors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motor = table.Column<double>(type: "float", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMotors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportNumberSeats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportNumberSeats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportMarkaId = table.Column<int>(type: "int", nullable: false),
                    TransportBanId = table.Column<int>(type: "int", nullable: false),
                    TransportMotorId = table.Column<int>(type: "int", nullable: false),
                    TransportYearId = table.Column<int>(type: "int", nullable: false),
                    TransportColorId = table.Column<int>(type: "int", nullable: false),
                    CountryMarketId = table.Column<int>(type: "int", nullable: false),
                    TransportEngineId = table.Column<int>(type: "int", nullable: false),
                    CarNumberSeatId = table.Column<int>(type: "int", nullable: false),
                    DailyPrice = table.Column<double>(type: "float", nullable: false),
                    KM = table.Column<double>(type: "float", nullable: false),
                    Automathic = table.Column<bool>(type: "bit", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Featured = table.Column<bool>(type: "bit", nullable: false),
                    IsAccident = table.Column<bool>(type: "bit", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    TransportDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transports_TransportBans_TransportBanId",
                        column: x => x.TransportBanId,
                        principalTable: "TransportBans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_TransportColors_TransportColorId",
                        column: x => x.TransportColorId,
                        principalTable: "TransportColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_TransportCountryMarkets_CountryMarketId",
                        column: x => x.CountryMarketId,
                        principalTable: "TransportCountryMarkets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_TransportEngines_TransportEngineId",
                        column: x => x.TransportEngineId,
                        principalTable: "TransportEngines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_TransportMarkas_TransportMarkaId",
                        column: x => x.TransportMarkaId,
                        principalTable: "TransportMarkas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_TransportMotors_TransportMotorId",
                        column: x => x.TransportMotorId,
                        principalTable: "TransportMotors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_TransportNumberSeats_CarNumberSeatId",
                        column: x => x.CarNumberSeatId,
                        principalTable: "TransportNumberSeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_Transports_TransportDetailId",
                        column: x => x.TransportDetailId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_TransportYears_TransportYearId",
                        column: x => x.TransportYearId,
                        principalTable: "TransportYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportAdvantages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportId = table.Column<int>(type: "int", nullable: false),
                    AdvantageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportAdvantages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportAdvantages_Advantages_AdvantageId",
                        column: x => x.AdvantageId,
                        principalTable: "Advantages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportAdvantages_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportDetails_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportImages_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransportAdvantages_AdvantageId",
                table: "TransportAdvantages",
                column: "AdvantageId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportAdvantages_TransportId",
                table: "TransportAdvantages",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportDetails_TransportId",
                table: "TransportDetails",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportImages_TransportId",
                table: "TransportImages",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMarkas_ParentId",
                table: "TransportMarkas",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_CarNumberSeatId",
                table: "Transports",
                column: "CarNumberSeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_CountryMarketId",
                table: "Transports",
                column: "CountryMarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TransportBanId",
                table: "Transports",
                column: "TransportBanId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TransportColorId",
                table: "Transports",
                column: "TransportColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TransportDetailId",
                table: "Transports",
                column: "TransportDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TransportEngineId",
                table: "Transports",
                column: "TransportEngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TransportMarkaId",
                table: "Transports",
                column: "TransportMarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TransportMotorId",
                table: "Transports",
                column: "TransportMotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TransportYearId",
                table: "Transports",
                column: "TransportYearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "TransportAdvantages");

            migrationBuilder.DropTable(
                name: "TransportDetails");

            migrationBuilder.DropTable(
                name: "TransportImages");

            migrationBuilder.DropTable(
                name: "Advantages");

            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "TransportBans");

            migrationBuilder.DropTable(
                name: "TransportColors");

            migrationBuilder.DropTable(
                name: "TransportCountryMarkets");

            migrationBuilder.DropTable(
                name: "TransportEngines");

            migrationBuilder.DropTable(
                name: "TransportMarkas");

            migrationBuilder.DropTable(
                name: "TransportMotors");

            migrationBuilder.DropTable(
                name: "TransportNumberSeats");

            migrationBuilder.DropTable(
                name: "TransportYears");

            migrationBuilder.CreateTable(
                name: "Bans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Markas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    MarkaName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Automathic = table.Column<bool>(type: "bit", nullable: false),
                    BanId = table.Column<int>(type: "int", nullable: false),
                    Benzin = table.Column<bool>(type: "bit", nullable: false),
                    Featured = table.Column<bool>(type: "bit", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    KM = table.Column<double>(type: "float", nullable: false),
                    MarkaId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Bans_BanId",
                        column: x => x.BanId,
                        principalTable: "Bans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Markas_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarCustomers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetails_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarImages_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarImages_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCustomers_CarId",
                table: "CarCustomers",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarCustomers_CustomerId",
                table: "CarCustomers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarId",
                table: "CarDetails",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_ImageId",
                table: "CarImages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BanId",
                table: "Cars",
                column: "BanId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MarkaId",
                table: "Cars",
                column: "MarkaId");
        }
    }
}
