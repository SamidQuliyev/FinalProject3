using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class ChangeDoctorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doctors",
                table: "Branches");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "Doctors",
                newName: "BranchesId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_BranchesId",
                table: "Doctors",
                column: "BranchesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Branches_BranchesId",
                table: "Doctors",
                column: "BranchesId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Branches_BranchesId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_BranchesId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "BranchesId",
                table: "Doctors",
                newName: "PositionId");

            migrationBuilder.AddColumn<string>(
                name: "Doctors",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
