using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectResearcherMatchingAPI.Migrations
{
    public partial class EntityUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPublished",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ApprovedBy",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Approved",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsPublished",
                table: "Projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Approved",
                table: "Projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
