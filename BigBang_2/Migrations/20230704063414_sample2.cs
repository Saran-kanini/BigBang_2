using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigBang_2.Migrations
{
    public partial class sample2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disease",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Disease_Description",
                table: "Patients",
                newName: "Gender");

            migrationBuilder.AddColumn<int>(
                name: "Patient_Age",
                table: "Patients",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Patient_Age",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Patients",
                newName: "Disease_Description");

            migrationBuilder.AddColumn<string>(
                name: "Disease",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
