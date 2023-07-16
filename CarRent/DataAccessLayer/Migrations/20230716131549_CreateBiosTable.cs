using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CreateBiosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bios");
        }
    }
}
