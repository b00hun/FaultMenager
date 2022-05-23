using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaultMenager_DataAccess.Migrations
{
    public partial class AddedSumcontractorWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubcontractorWorker",
                columns: table => new
                {
                    SubcontractorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WorkerPhone = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubcotractorFirmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubcontractorWorker", x => x.SubcontractorId);
                    table.ForeignKey(
                        name: "FK_SubcontractorWorker_SubcontractorFirms_SubcotractorFirmId",
                        column: x => x.SubcotractorFirmId,
                        principalTable: "SubcontractorFirms",
                        principalColumn: "SubcontractorFirmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubcontractorWorker_SubcotractorFirmId",
                table: "SubcontractorWorker",
                column: "SubcotractorFirmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubcontractorWorker");
        }
    }
}
