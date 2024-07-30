﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.DAL;

#nullable disable

namespace P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Migrations
{
    [DbContext(typeof(CA_RS11_P2_2_ClaudiaSouza_DBContext))]
    [Migration("20240730170301_01_initial")]
    partial class _01_initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NIF")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractId"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("date");

                    b.Property<int>("MembershipId")
                        .HasColumnType("int");

                    b.HasKey("ContractId");

                    b.HasIndex("ClientId");

                    b.HasIndex("MembershipId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.ContractModality", b =>
                {
                    b.Property<int>("ContractModalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractModalityId"), 1L, 1);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("ModalityId")
                        .HasColumnType("int");

                    b.HasKey("ContractModalityId");

                    b.HasIndex("ContractId");

                    b.HasIndex("ModalityId");

                    b.ToTable("ContractModality");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Membership", b =>
                {
                    b.Property<int>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipId"), 1L, 1);

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsLoyal")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("MembershipId");

                    b.ToTable("Membership");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Modality", b =>
                {
                    b.Property<int>("ModalityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModalityID"), 1L, 1);

                    b.Property<string>("ModalityName")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<string>("ModalityPackage")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.HasKey("ModalityID");

                    b.ToTable("Modality");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"), 1L, 1);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentBaseRate")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("PaymentBaseValue")
                        .HasColumnType("decimal(6,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<decimal>("PaymentTotalValue")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.HasKey("PaymentID");

                    b.HasIndex("ContractId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Contract", b =>
                {
                    b.HasOne("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Client", "Client")
                        .WithMany("Contracts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Membership", "Membership")
                        .WithMany("Contracts")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.ContractModality", b =>
                {
                    b.HasOne("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Contract", "Contract")
                        .WithMany("ContractModalities")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Modality", "Modality")
                        .WithMany("ContractModalities")
                        .HasForeignKey("ModalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Modality");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Payment", b =>
                {
                    b.HasOne("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Contract", "Contract")
                        .WithMany("Payments")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Client", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Contract", b =>
                {
                    b.Navigation("ContractModalities");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Membership", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models.Modality", b =>
                {
                    b.Navigation("ContractModalities");
                });
#pragma warning restore 612, 618
        }
    }
}
