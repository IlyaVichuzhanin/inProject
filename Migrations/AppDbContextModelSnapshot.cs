﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using inProject;

#nullable disable

namespace inProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("inProject.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("inProject.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeType")
                        .HasColumnType("integer");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ResourceID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ResourceID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("inProject.Models.PetexPrimaryLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsLog")
                        .HasColumnType("boolean");

                    b.Property<string>("LogInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LogIsStructurated")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("PetexPrimaryLogs");
                });

            modelBuilder.Entity("inProject.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProjectResourceId")
                        .HasColumnType("integer");

                    b.Property<int>("ResourceCategory")
                        .HasColumnType("integer");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ResourceType")
                        .HasColumnType("integer");

                    b.Property<int>("ResourceUsageState")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("inProject.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LogInDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LogOutDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("SessionIsFinished")
                        .HasColumnType("boolean");

                    b.Property<int>("SoftwareId")
                        .HasColumnType("integer");

                    b.Property<int>("SoftwareModuleId")
                        .HasColumnType("integer");

                    b.Property<int>("SoftwareUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("SoftwareId");

                    b.HasIndex("SoftwareModuleId");

                    b.HasIndex("SoftwareUserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("inProject.Models.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("SoftwareName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("inProject.Models.SoftwareModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ResourceID")
                        .HasColumnType("integer");

                    b.Property<int>("SoftwareId")
                        .HasColumnType("integer");

                    b.Property<string>("SoftwareModuleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResourceID");

                    b.HasIndex("SoftwareId");

                    b.ToTable("SoftwareModules");
                });

            modelBuilder.Entity("inProject.Models.SoftwareUser", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("ComputerUserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<string>("WindowsUserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SoftwareUsers");
                });

            modelBuilder.Entity("inProject.Models.StructuredLog", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<bool?>("ErrorLog")
                        .HasColumnType("boolean");

                    b.Property<bool?>("LogIsMatched")
                        .HasColumnType("boolean");

                    b.Property<int>("Operation")
                        .HasColumnType("integer");

                    b.Property<DateTime>("OperationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("SoftwareId")
                        .HasColumnType("integer");

                    b.Property<int?>("SoftwareModuleId")
                        .HasColumnType("integer");

                    b.Property<int?>("SoftwareUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("SoftwareId");

                    b.HasIndex("SoftwareModuleId");

                    b.HasIndex("SoftwareUserId");

                    b.ToTable("StructuredLogs");
                });

            modelBuilder.Entity("inProject.Models.tNavPrimaryLog", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long?>("Id"));

                    b.Property<string>("ComputerUserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Feature")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("IsLog")
                        .HasColumnType("boolean");

                    b.Property<bool?>("LogIsStructurated")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OperationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("OperationType")
                        .HasColumnType("integer");

                    b.Property<int?>("ReturnedId")
                        .HasColumnType("integer");

                    b.Property<long?>("TNavLogID")
                        .HasColumnType("bigint");

                    b.Property<string>("WindowsUserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tNavPrimaryLogs");
                });

            modelBuilder.Entity("inProject.Models.Employee", b =>
                {
                    b.HasOne("inProject.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inProject.Models.Resource", "Resource")
                        .WithMany("Employees")
                        .HasForeignKey("ResourceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("inProject.Models.Session", b =>
                {
                    b.HasOne("inProject.Models.Employee", "Employee")
                        .WithMany("Sessions")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inProject.Models.Software", "Software")
                        .WithMany("Sessions")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inProject.Models.SoftwareModule", "SoftwareModule")
                        .WithMany("Sessions")
                        .HasForeignKey("SoftwareModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inProject.Models.SoftwareUser", "SoftwareUser")
                        .WithMany("Sessions")
                        .HasForeignKey("SoftwareUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Software");

                    b.Navigation("SoftwareModule");

                    b.Navigation("SoftwareUser");
                });

            modelBuilder.Entity("inProject.Models.SoftwareModule", b =>
                {
                    b.HasOne("inProject.Models.Resource", "Resource")
                        .WithMany("SoftwareModules")
                        .HasForeignKey("ResourceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inProject.Models.Software", "Software")
                        .WithMany("SoftwareModules")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");

                    b.Navigation("Software");
                });

            modelBuilder.Entity("inProject.Models.SoftwareUser", b =>
                {
                    b.HasOne("inProject.Models.Employee", "Employee")
                        .WithMany("SoftwareUsers")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("inProject.Models.StructuredLog", b =>
                {
                    b.HasOne("inProject.Models.Employee", "Employee")
                        .WithMany("StructuredLogs")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("inProject.Models.Software", "Software")
                        .WithMany("StructuredLogs")
                        .HasForeignKey("SoftwareId");

                    b.HasOne("inProject.Models.SoftwareModule", "SoftwareModule")
                        .WithMany("StructuredLogs")
                        .HasForeignKey("SoftwareModuleId");

                    b.HasOne("inProject.Models.SoftwareUser", "SoftwareUser")
                        .WithMany("StructuredLogs")
                        .HasForeignKey("SoftwareUserId");

                    b.Navigation("Employee");

                    b.Navigation("Software");

                    b.Navigation("SoftwareModule");

                    b.Navigation("SoftwareUser");
                });

            modelBuilder.Entity("inProject.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("inProject.Models.Employee", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("SoftwareUsers");

                    b.Navigation("StructuredLogs");
                });

            modelBuilder.Entity("inProject.Models.Resource", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("SoftwareModules");
                });

            modelBuilder.Entity("inProject.Models.Software", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("SoftwareModules");

                    b.Navigation("StructuredLogs");
                });

            modelBuilder.Entity("inProject.Models.SoftwareModule", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("StructuredLogs");
                });

            modelBuilder.Entity("inProject.Models.SoftwareUser", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("StructuredLogs");
                });
#pragma warning restore 612, 618
        }
    }
}