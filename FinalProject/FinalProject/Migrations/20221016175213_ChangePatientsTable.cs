using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class ChangePatientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientNumber",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "PatientNumberId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PatientNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientNumbers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientNumberId",
                table: "Patients",
                column: "PatientNumberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_PatientNumbers_PatientNumberId",
                table: "Patients",
                column: "PatientNumberId",
                principalTable: "PatientNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_PatientNumbers_PatientNumberId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "PatientNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientNumberId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientNumberId",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "PatientNumber",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
