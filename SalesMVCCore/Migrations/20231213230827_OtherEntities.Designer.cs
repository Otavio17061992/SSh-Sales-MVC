﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesMVCCore.Data;

namespace SalesMVCCore.Migrations
{
    [DbContext(typeof(SalesMVCCoreContext))]
    [Migration("20231213230827_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesMVCCore.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalesMVCCore.Models.ViewModels.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SallerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SallerId");

                    b.ToTable("SalesRecords");
                });

            modelBuilder.Entity("SalesMVCCore.Models.ViewModels.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartamentID");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesMVCCore.Models.ViewModels.SalesRecord", b =>
                {
                    b.HasOne("SalesMVCCore.Models.ViewModels.Seller", "Saller")
                        .WithMany("Sales")
                        .HasForeignKey("SallerId");
                });

            modelBuilder.Entity("SalesMVCCore.Models.ViewModels.Seller", b =>
                {
                    b.HasOne("SalesMVCCore.Models.Department", "Departament")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartamentID");
                });
#pragma warning restore 612, 618
        }
    }
}
