using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaultMenager_DataAccess.Migrations
{
    public partial class manyToManyRelationAddedToDbMenagerProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectMenagers",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    MenagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectMenagers", x => new { x.MenagerId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_ProjectMenagers_Menagers_MenagerId",
                        column: x => x.MenagerId,
                        principalTable: "Menagers",
                        principalColumn: "MenagerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectMenagers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMenagers_ProjectId",
                table: "ProjectMenagers",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectMenagers");
        }
    }
}
