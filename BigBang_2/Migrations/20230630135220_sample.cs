using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigBang_2.Migrations
{
    public partial class sample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin_Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Admin_Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Doctor_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Doctor_Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disease_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    DoctorsDoctor_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Patient_Id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorsDoctor_Id",
                        column: x => x.DoctorsDoctor_Id,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_Id");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Appointment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Appointment_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Id = table.Column<int>(type: "int", nullable: true),
                    Patient_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Appointment_Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_Doctor_Id",
                        column: x => x.Doctor_Id,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Doctor_Id",
                table: "Appointments",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Patient_Id",
                table: "Appointments",
                column: "Patient_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorsDoctor_Id",
                table: "Patients",
                column: "DoctorsDoctor_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
