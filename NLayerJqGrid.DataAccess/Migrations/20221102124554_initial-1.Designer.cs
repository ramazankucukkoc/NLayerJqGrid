﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;

#nullable disable

namespace NLayerJqGrid.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContextBase))]
    [Migration("20221102124554_initial-1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("OperationClaims", "NLayer");
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users", "NLayer");
                });

            modelBuilder.Entity("NLayerJqGrid.DatatAccess.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", "NLayer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Cheese",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8383),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8391),
                            Note = "Not girilmedi"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Meat",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8394),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8394),
                            Note = "Not girilmedi"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Fish",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8395),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8395),
                            Note = "Not girilmedi"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Bread",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8396),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8397),
                            Note = "Not girilmedi"
                        });
                });

            modelBuilder.Entity("NLayerJqGrid.DatatAccess.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProdcutName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("Stock")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", "NLayer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Bosch",
                            CategoryId = 1,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(209),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(211),
                            Note = "Not girilmedi",
                            ProdcutName = "Cheddar",
                            SalesPrice = 25m,
                            Stock = (short)22,
                            UnitPrice = 22m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Bosch",
                            CategoryId = 1,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(215),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(215),
                            Note = "Not girilmedi",
                            ProdcutName = "Brie",
                            SalesPrice = 25m,
                            Stock = (short)12,
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Bosch",
                            CategoryId = 1,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(217),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(217),
                            Note = "Not girilmedi",
                            ProdcutName = "Stilton",
                            SalesPrice = 25m,
                            Stock = (short)13,
                            UnitPrice = 12m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Bosch",
                            CategoryId = 2,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(219),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(219),
                            Note = "Not girilmedi",
                            ProdcutName = "Cheshire",
                            SalesPrice = 35m,
                            Stock = (short)21,
                            UnitPrice = 32m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Bosch",
                            CategoryId = 2,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(220),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(221),
                            Note = "Not girilmedi",
                            ProdcutName = "Swiss",
                            SalesPrice = 120m,
                            Stock = (short)31,
                            UnitPrice = 100m
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Bosch",
                            CategoryId = 2,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(222),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(222),
                            Note = "Not girilmedi",
                            ProdcutName = "Gruyere",
                            SalesPrice = 65m,
                            Stock = (short)10,
                            UnitPrice = 45m
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Bosch",
                            CategoryId = 3,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(223),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(224),
                            Note = "Not girilmedi",
                            ProdcutName = "Colby",
                            SalesPrice = 25m,
                            Stock = (short)100,
                            UnitPrice = 24m
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Bosch",
                            CategoryId = 3,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(225),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(225),
                            Note = "Not girilmedi",
                            ProdcutName = "Mozzela",
                            SalesPrice = 43m,
                            Stock = (short)34,
                            UnitPrice = 35m
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Bosch",
                            CategoryId = 3,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(226),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(227),
                            Note = "Not girilmedi",
                            ProdcutName = "Ricotta",
                            SalesPrice = 25m,
                            Stock = (short)200,
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Bosch",
                            CategoryId = 4,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(228),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(228),
                            Note = "Not girilmedi",
                            ProdcutName = "Parmesan",
                            SalesPrice = 25m,
                            Stock = (short)321,
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = 11,
                            Brand = "Bosch",
                            CategoryId = 4,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(229),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(230),
                            Note = "Not girilmedi",
                            ProdcutName = "Ham",
                            SalesPrice = 25m,
                            Stock = (short)34,
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = 12,
                            Brand = "Bosch",
                            CategoryId = 4,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(231),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(231),
                            Note = "Not girilmedi",
                            ProdcutName = "Beef",
                            SalesPrice = 55m,
                            Stock = (short)56,
                            UnitPrice = 46m
                        },
                        new
                        {
                            Id = 13,
                            Brand = "Bosch",
                            CategoryId = 4,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(232),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(232),
                            Note = "Not girilmedi",
                            ProdcutName = "Chicken",
                            SalesPrice = 95m,
                            Stock = (short)60,
                            UnitPrice = 90m
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Bosch",
                            CategoryId = 4,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(233),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(234),
                            Note = "Not girilmedi",
                            ProdcutName = "Turkey",
                            SalesPrice = 250m,
                            Stock = (short)37,
                            UnitPrice = 200m
                        },
                        new
                        {
                            Id = 15,
                            Brand = "Bosch",
                            CategoryId = 4,
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(235),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(235),
                            Note = "Not girilmedi",
                            ProdcutName = "Prosciutto",
                            SalesPrice = 325m,
                            Stock = (short)400,
                            UnitPrice = 321m
                        });
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.HasOne("NLayerJqGrid.Core.Entities.Concrete.User", "User")
                        .WithMany("OperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NLayerJqGrid.DatatAccess.Entities.Concrete.Product", b =>
                {
                    b.HasOne("NLayerJqGrid.DatatAccess.Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.User", b =>
                {
                    b.Navigation("OperationClaims");
                });

            modelBuilder.Entity("NLayerJqGrid.DatatAccess.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
