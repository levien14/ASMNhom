using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManager.Migrations
{
    public partial class addUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GradeName",
                table: "Grade",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grade_GradeName",
                table: "Grade",
                column: "GradeName",
                unique: true,
                filter: "[GradeName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Grade_GradeName",
                table: "Grade");

            migrationBuilder.AlterColumn<string>(
                name: "GradeName",
                table: "Grade",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
