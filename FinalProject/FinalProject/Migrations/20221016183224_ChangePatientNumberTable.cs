using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class ChangePatientNumberTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "PatientNumbers");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "PatientNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "PatientNumbers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PatientNumbers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
