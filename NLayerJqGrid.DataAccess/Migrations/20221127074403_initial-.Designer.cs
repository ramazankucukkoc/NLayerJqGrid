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
    [Migration("20221127074403_initial-")]
    partial class initial
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

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NLayerJqGrid.DataAccess.Entities.Concrete.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Fetih Mah. Aşık Nigari Sok. NO:2AB",
                            City = "Konya",
                            County = "Karatay",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2110),
                            Email = "ramazankucukkoc43@gmail.com",
                            FirstName = "Ramazan",
                            IsDeleted = false,
                            LastName = "Küçükkoç",
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2125),
                            Note = "Not girilmedi",
                            PhoneNumber = "5436251369"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Sincan Mah. Aşık Nigari Sok. NO:2AB",
                            City = "Ankara",
                            County = "Sincan",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2134),
                            Email = "alistfn06@gmail.com",
                            FirstName = "Aliş",
                            IsDeleted = false,
                            LastName = "Tufan",
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2134),
                            Note = "Not girilmedi",
                            PhoneNumber = "5427123456"
                        });
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3633),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3637),
                            Note = "Not girilmedi"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Meat",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3639),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3639),
                            Note = "Not girilmedi"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Fish",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3640),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3641),
                            Note = "Not girilmedi"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Bread",
                            CreatedByName = "Ramazan KÜÇÜKKOÇ",
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3641),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3642),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6722),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6727),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6733),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6733),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6737),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6737),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6739),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6739),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6741),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6741),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6742),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6743),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6744),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6745),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6746),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6747),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6748),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6749),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6750),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6751),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6752),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6753),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6754),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6755),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6758),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6759),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6760),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6761),
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
                            CreatedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6762),
                            IsDeleted = false,
                            ModifiedByName = "Ramazan KÜÇÜKKOÇ",
                            ModifiedDate = new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6763),
                            Note = "Not girilmedi",
                            ProdcutName = "Prosciutto",
                            SalesPrice = 325m,
                            Stock = (short)400,
                            UnitPrice = 321m
                        });
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.RoleClaim", b =>
                {
                    b.HasOne("NLayerJqGrid.Core.Entities.Concrete.OperationClaim", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserClaim", b =>
                {
                    b.HasOne("NLayerJqGrid.Core.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserLogin", b =>
                {
                    b.HasOne("NLayerJqGrid.Core.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserRole", b =>
                {
                    b.HasOne("NLayerJqGrid.Core.Entities.Concrete.OperationClaim", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NLayerJqGrid.Core.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerJqGrid.Core.Entities.Concrete.UserToken", b =>
                {
                    b.HasOne("NLayerJqGrid.Core.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("NLayerJqGrid.DatatAccess.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}