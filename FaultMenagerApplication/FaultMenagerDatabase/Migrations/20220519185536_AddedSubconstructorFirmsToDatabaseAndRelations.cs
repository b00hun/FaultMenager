using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaultMenager_DataAccess.Migrations
{
    public partial class AddedSubconstructorFirmsToDatabaseAndRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubcontractorId",
                table: "Faults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SubcontractorFirms",
                columns: table => new
                {
                    SubcontractorFirmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubcontractorName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubcontractorFirms", x => x.SubcontractorFirmId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faults_SubcontractorId",
                table: "Faults",
                column: "SubcontractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faults_SubcontractorFirms_SubcontractorId",
                table: "Faults",
                column: "SubcontractorId",
                principalTable: "SubcontractorFirms",
                principalColumn: "SubcontractorFirmId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faults_SubcontractorFirms_SubcontractorId",
                table: "Faults");

            migrationBuilder.DropTable(
                name: "SubcontractorFirms");

            migrationBuilder.DropIndex(
                name: "IX_Faults_SubcontractorId",
                table: "Faults");

            migrationBuilder.DropColumn(
                name: "SubcontractorId",
                table: "Faults");
        }
    }
}
