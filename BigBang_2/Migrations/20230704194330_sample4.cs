using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigBang_2.Migrations
{
    public partial class sample4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Appointments",
                newName: "Patient_Id");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Appointments",
                newName: "Doctor_Id");

            migrationBuilder.AddColumn<int>(
                name: "Doctor_Id1",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Patient_Id1",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Doctor_Id1",
                table: "Appointments",
                column: "Doctor_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Patient_Id1",
                table: "Appointments",
                column: "Patient_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_Doctor_Id1",
                table: "Appointments",
                column: "Doctor_Id1",
                principalTable: "Doctors",
                principalColumn: "Doctor_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_Patient_Id1",
                table: "Appointments",
                column: "Patient_Id1",
                principalTable: "Patients",
                principalColumn: "Patient_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_Doctor_Id1",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_Patient_Id1",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_Doctor_Id1",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_Patient_Id1",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Doctor_Id1",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Patient_Id1",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Patient_Id",
                table: "Appointments",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "Doctor_Id",
                table: "Appointments",
                newName: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Doctor_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Patient_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
