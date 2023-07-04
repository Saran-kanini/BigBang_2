﻿// <auto-generated />
using System;
using BigBang_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BigBang_2.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20230704193443_sample3")]
    partial class sample3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BigBang_2.Models.Admin", b =>
                {
                    b.Property<int>("Admin_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Admin_Id"), 1L, 1);

                    b.Property<string>("Admin_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Admin_Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("BigBang_2.Models.Appointment", b =>
                {
                    b.Property<int>("Appointment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Appointment_Id"), 1L, 1);

                    b.Property<DateTime?>("Appointment_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("PatientEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Appointment_Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BigBang_2.Models.Doctor", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Doctor_Id"), 1L, 1);

                    b.Property<string>("Contact_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Doctor_Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("BigBang_2.Models.Patient", b =>
                {
                    b.Property<int>("Patient_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Patient_Id"), 1L, 1);

                    b.Property<int?>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorsDoctor_Id")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Patient_Age")
                        .HasColumnType("int");

                    b.Property<string>("Patient_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_No")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Patient_Id");

                    b.HasIndex("DoctorsDoctor_Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("BigBang_2.Models.Appointment", b =>
                {
                    b.HasOne("BigBang_2.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BigBang_2.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("BigBang_2.Models.Patient", b =>
                {
                    b.HasOne("BigBang_2.Models.Doctor", "Doctors")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorsDoctor_Id");

                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("BigBang_2.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("BigBang_2.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
