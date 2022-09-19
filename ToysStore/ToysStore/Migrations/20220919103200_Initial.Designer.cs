﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using ToysStore;

#nullable disable

namespace ToysStore.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20220919103200_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ToysStore.Controllers.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("ToysStore.Controllers.Entities.Toy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("registerDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("toys");
                });

            modelBuilder.Entity("ToysStore.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Point>("Ubication")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.ToTable("branches");
                });

            modelBuilder.Entity("ToysStore.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("ToysStore.Entities.ToysBranches", b =>
                {
                    b.Property<int>("ToyId")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.HasKey("ToyId", "BranchId");

                    b.HasIndex("BranchId");

                    b.ToTable("toysbranches");
                });

            modelBuilder.Entity("ToysStore.Entities.ToysBrands", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ToyId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId", "ToyId");

                    b.HasIndex("ToyId");

                    b.ToTable("toysbrands");
                });

            modelBuilder.Entity("ToysStore.Entities.ToysCategories", b =>
                {
                    b.Property<int>("ToyId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ToyId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("toyscategories");
                });

            modelBuilder.Entity("ToysStore.Entities.ToysBranches", b =>
                {
                    b.HasOne("ToysStore.Entities.Branch", "Branch")
                        .WithMany("ToysBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToysStore.Controllers.Entities.Toy", "Toy")
                        .WithMany("ToysBranches")
                        .HasForeignKey("ToyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Toy");
                });

            modelBuilder.Entity("ToysStore.Entities.ToysBrands", b =>
                {
                    b.HasOne("ToysStore.Entities.Brand", "Brand")
                        .WithMany("ToysBrands")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToysStore.Controllers.Entities.Toy", "Toy")
                        .WithMany("ToysBrands")
                        .HasForeignKey("ToyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Toy");
                });

            modelBuilder.Entity("ToysStore.Entities.ToysCategories", b =>
                {
                    b.HasOne("ToysStore.Controllers.Entities.Category", "category")
                        .WithMany("ToysCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToysStore.Controllers.Entities.Toy", "Toy")
                        .WithMany("ToysCategories")
                        .HasForeignKey("ToyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Toy");

                    b.Navigation("category");
                });

            modelBuilder.Entity("ToysStore.Controllers.Entities.Category", b =>
                {
                    b.Navigation("ToysCategories");
                });

            modelBuilder.Entity("ToysStore.Controllers.Entities.Toy", b =>
                {
                    b.Navigation("ToysBranches");

                    b.Navigation("ToysBrands");

                    b.Navigation("ToysCategories");
                });

            modelBuilder.Entity("ToysStore.Entities.Branch", b =>
                {
                    b.Navigation("ToysBranches");
                });

            modelBuilder.Entity("ToysStore.Entities.Brand", b =>
                {
                    b.Navigation("ToysBrands");
                });
#pragma warning restore 612, 618
        }
    }
}
