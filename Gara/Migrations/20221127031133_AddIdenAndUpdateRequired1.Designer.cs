﻿// <auto-generated />
using System;
using Gara.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gara.Migrations
{
    [DbContext(typeof(GaraDbContext))]
    [Migration("20221127031133_AddIdenAndUpdateRequired1")]
    partial class AddIdenAndUpdateRequired1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gara.Models.Accessary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessaryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AccessaryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Accessaries");
                });

            modelBuilder.Entity("Gara.Models.AccessaryPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("DateTime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("AccessaryPayments");
                });

            modelBuilder.Entity("Gara.Models.AccessaryPaymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessaryId")
                        .HasColumnType("int");

                    b.Property<int>("AccessaryPaymentId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessaryId");

                    b.HasIndex("AccessaryPaymentId");

                    b.HasIndex("ProducerId");

                    b.ToTable("AccessaryPaymentDetails");
                });

            modelBuilder.Entity("Gara.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DateTime");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Gara.Models.CustomerRepair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int?>("RepairTimes")
                        .HasColumnType("int");

                    b.Property<int?>("WarrantyTimes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("CustomerRepairs");
                });

            modelBuilder.Entity("Gara.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Certificate")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DateTime");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("IdentificationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("SalaryUnit")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartWorkAt")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Gara.Models.Error", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("Gara.Models.Identifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IdentificationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Identifications");
                });

            modelBuilder.Entity("Gara.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PaymentTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("Gara.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("Gara.Models.VehiclePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DateTime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EmployeeFix")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("PaymentTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<double>("TotalPayment")
                        .HasColumnType("float");

                    b.Property<string>("VehicleBrand")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VehicleStatus")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VehicleType")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("WarantyPeriod")
                        .HasColumnType("int");

                    b.Property<string>("WarantyPeriodType")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("VehiclePayments");
                });

            modelBuilder.Entity("Gara.Models.VehiclePaymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessaryId")
                        .HasColumnType("int");

                    b.Property<int>("AccessaryNumber")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("VehiclePaymentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessaryId");

                    b.HasIndex("VehiclePaymentId");

                    b.ToTable("VehiclePaymentDetails");
                });

            modelBuilder.Entity("Gara.Models.AccessaryPaymentDetail", b =>
                {
                    b.HasOne("Gara.Models.Accessary", "Accessary")
                        .WithMany("AccessaryPaymentDetail")
                        .HasForeignKey("AccessaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gara.Models.AccessaryPayment", "AccessaryPayment")
                        .WithMany("AccessaryPaymentDetails")
                        .HasForeignKey("AccessaryPaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gara.Models.Producer", "Producer")
                        .WithMany("AccessaryPaymentDetails")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accessary");

                    b.Navigation("AccessaryPayment");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Gara.Models.CustomerRepair", b =>
                {
                    b.HasOne("Gara.Models.Customer", "Customer")
                        .WithOne("CustomerRepair")
                        .HasForeignKey("Gara.Models.CustomerRepair", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Gara.Models.Identifications", b =>
                {
                    b.HasOne("Gara.Models.Employee", "Employee")
                        .WithMany("Identifications")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Gara.Models.VehiclePayment", b =>
                {
                    b.HasOne("Gara.Models.Customer", "Customer")
                        .WithMany("VehiclePayments")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Gara.Models.PaymentType", "PaymentType")
                        .WithMany("VehiclePayments")
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("Gara.Models.VehiclePaymentDetail", b =>
                {
                    b.HasOne("Gara.Models.Accessary", "Accessary")
                        .WithMany()
                        .HasForeignKey("AccessaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gara.Models.VehiclePayment", "VehiclePayment")
                        .WithMany("VehiclePaymentDetails")
                        .HasForeignKey("VehiclePaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accessary");

                    b.Navigation("VehiclePayment");
                });

            modelBuilder.Entity("Gara.Models.Accessary", b =>
                {
                    b.Navigation("AccessaryPaymentDetail");
                });

            modelBuilder.Entity("Gara.Models.AccessaryPayment", b =>
                {
                    b.Navigation("AccessaryPaymentDetails");
                });

            modelBuilder.Entity("Gara.Models.Customer", b =>
                {
                    b.Navigation("CustomerRepair")
                        .IsRequired();

                    b.Navigation("VehiclePayments");
                });

            modelBuilder.Entity("Gara.Models.Employee", b =>
                {
                    b.Navigation("Identifications");
                });

            modelBuilder.Entity("Gara.Models.PaymentType", b =>
                {
                    b.Navigation("VehiclePayments");
                });

            modelBuilder.Entity("Gara.Models.Producer", b =>
                {
                    b.Navigation("AccessaryPaymentDetails");
                });

            modelBuilder.Entity("Gara.Models.VehiclePayment", b =>
                {
                    b.Navigation("VehiclePaymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
