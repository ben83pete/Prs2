﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prs.Models;

namespace prs.Migrations
{
    [DbContext(typeof(PrsDbContext))]
    [Migration("20190225162729_added FK to single Get")]
    partial class addedFKtosingleGet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("prs.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12, 2)");

                    b.Property<int>("Unit")
                        .HasMaxLength(30);

                    b.Property<int>("VendorId");

                    b.Property<int?>("VendorsId");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("VendorsId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("prs.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsReviewer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Phone")
                        .HasMaxLength(12);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("prs.Models.Vendors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<bool>("IsPreferred");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .HasMaxLength(2);

                    b.Property<string>("Zipcode")
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("prs.Models.Products", b =>
                {
                    b.HasOne("prs.Models.Vendors", "Vendors")
                        .WithMany()
                        .HasForeignKey("VendorsId");
                });
#pragma warning restore 612, 618
        }
    }
}
