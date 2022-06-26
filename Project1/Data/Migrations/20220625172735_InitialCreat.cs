using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Data.Migrations
{
    public partial class InitialCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total1 = table.Column<int>(type: "int", nullable: false),
                    Oasys = table.Column<int>(type: "int", nullable: false),
                    AirOptix = table.Column<int>(type: "int", nullable: false),
                    BioTrue = table.Column<int>(type: "int", nullable: false),
                    BiofinityToric = table.Column<int>(type: "int", nullable: false),
                    ACVita = table.Column<int>(type: "int", nullable: false),
                    MyDay = table.Column<int>(type: "int", nullable: false),
                    proclear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProCodes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProCodes");
        }
    }
}
