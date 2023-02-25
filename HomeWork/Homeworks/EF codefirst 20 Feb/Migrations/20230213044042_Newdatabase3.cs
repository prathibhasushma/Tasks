using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleEF.Migrations
{
    /// <inheritdoc />
    public partial class Newdatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Standard_studentrefid",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Standard",
                table: "Standard");

            migrationBuilder.RenameTable(
                name: "Standard",
                newName: "standards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_standards",
                table: "standards",
                column: "standardid");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_standards_studentrefid",
                table: "Students",
                column: "studentrefid",
                principalTable: "standards",
                principalColumn: "standardid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_standards_studentrefid",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_standards",
                table: "standards");

            migrationBuilder.RenameTable(
                name: "standards",
                newName: "Standard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standard",
                table: "Standard",
                column: "standardid");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Standard_studentrefid",
                table: "Students",
                column: "studentrefid",
                principalTable: "Standard",
                principalColumn: "standardid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
