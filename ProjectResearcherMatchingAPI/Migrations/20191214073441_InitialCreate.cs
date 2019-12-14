using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectResearcherMatchingAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Approved = table.Column<int>(nullable: false),
                    ApprovedDate = table.Column<DateTime>(nullable: false),
                    ApprovedBy = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsPublished = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
