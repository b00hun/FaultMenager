using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaultMenager_DataAccess.Migrations
{
    public partial class menageradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menagers",
                columns: table => new
                {
                    MenagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenagerName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MenagerSurname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MenagerPhoneNumber = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    MenagerMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menagers", x => x.MenagerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menagers");
        }
    }
}
