﻿// <auto-generated />
using System;
using MVC_cours_isitech.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_cours_isitech.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MVC_cours_isitech.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 10, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2371),
                            Description = "Découvrez les fondamentaux de l'IA et ses applications dans le monde moderne",
                            EventDate = new DateTime(2024, 12, 22, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2353),
                            Location = "Amphithéâtre A",
                            MaxParticipants = 100,
                            Title = "Introduction à l'Intelligence Artificielle"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 12, 12, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2377),
                            Description = "Pratiques et outils essentiels pour le DevOps moderne",
                            EventDate = new DateTime(2024, 12, 29, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2376),
                            Location = "Salle Informatique 2",
                            MaxParticipants = 50,
                            Title = "Workshop DevOps"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 12, 8, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2382),
                            Description = "Les dernières tendances en matière de sécurité informatique",
                            EventDate = new DateTime(2025, 1, 5, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2381),
                            Location = "Amphithéâtre B",
                            MaxParticipants = 150,
                            Title = "Conférence Cybersécurité"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 12, 5, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2387),
                            Description = "48h pour développer des solutions innovantes",
                            EventDate = new DateTime(2025, 1, 14, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2385),
                            Location = "Campus Innovation Hub",
                            MaxParticipants = 80,
                            Title = "Hackathon Innovation"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 11, 30, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2408),
                            Description = "Explorer l'avenir du web décentralisé",
                            EventDate = new DateTime(2024, 12, 13, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2406),
                            Location = "Salle de Conférence C",
                            MaxParticipants = 120,
                            Title = "Web 3.0 et Blockchain"
                        });
                });

            modelBuilder.Entity("MVC_cours_isitech.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "11111111-1111-1111-1111-111111111111",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "22222222-2222-2222-2222-222222222222",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "33333333-3333-3333-3333-333333333333",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "44444444-4444-4444-4444-444444444444",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "55555555-5555-5555-5555-555555555555",
                            RoleId = "3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MVC_cours_isitech.Models.Student", b =>
                {
                    b.HasBaseType("MVC_cours_isitech.Models.User");

                    b.Property<string>("Major")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = "44444444-4444-4444-4444-444444444444",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4967e441-8a87-4a26-b11a-7d1772e2d5b8",
                            DateOfBirth = new DateOnly(2004, 12, 15),
                            Email = "lucas.petit@student.com",
                            EmailConfirmed = true,
                            Firstname = "Lucas",
                            Lastname = "Petit",
                            LockoutEnabled = false,
                            NormalizedEmail = "LUCAS.PETIT@STUDENT.COM",
                            NormalizedUserName = "LUCAS.PETIT@STUDENT.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOZyUXLQKQ2MFzzmNVICKvccKPgqvSqRv0/5Bpbq0756S3CRb2vtMITHky2HQBWZRg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "lucas.petit@student.com",
                            Major = "Computer Science"
                        },
                        new
                        {
                            Id = "55555555-5555-5555-5555-555555555555",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "75476612-9adf-4f77-926b-4df84823741e",
                            DateOfBirth = new DateOnly(2002, 12, 15),
                            Email = "emma.moreau@student.com",
                            EmailConfirmed = true,
                            Firstname = "Emma",
                            Lastname = "Moreau",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMMA.MOREAU@STUDENT.COM",
                            NormalizedUserName = "EMMA.MOREAU@STUDENT.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPCrZtH5D0xjAgi+erMukJI0WTDKfxZrZ+icWkyJmuvPytCxqxFHIXuUNj7SlR8pLg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "emma.moreau@student.com",
                            Major = "Mathematics"
                        });
                });

            modelBuilder.Entity("MVC_cours_isitech.Models.Teacher", b =>
                {
                    b.HasBaseType("MVC_cours_isitech.Models.User");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Teacher");

                    b.HasData(
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc4a75bf-122b-4275-8f8c-fac1095c7641",
                            DateOfBirth = new DateOnly(1989, 12, 15),
                            Email = "martin.dupont@teacher.com",
                            EmailConfirmed = true,
                            Firstname = "Martin",
                            Lastname = "Dupont",
                            LockoutEnabled = false,
                            NormalizedEmail = "MARTIN.DUPONT@TEACHER.COM",
                            NormalizedUserName = "MARTIN.DUPONT@TEACHER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIV610t0GLUxywskb/7fEMn9Gk+HguwnZoIxRoNxNAuyNxsGHOavGW4Qj8bW8uu1KA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "martin.dupont@teacher.com",
                            Subject = "Mathematics"
                        },
                        new
                        {
                            Id = "22222222-2222-2222-2222-222222222222",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "34727a67-a336-4cdb-b113-7cc87d55b284",
                            DateOfBirth = new DateOnly(1994, 12, 15),
                            Email = "sophie.martin@teacher.com",
                            EmailConfirmed = true,
                            Firstname = "Sophie",
                            Lastname = "Martin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SOPHIE.MARTIN@TEACHER.COM",
                            NormalizedUserName = "SOPHIE.MARTIN@TEACHER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEVUXG6nHKszmr1kOcSVJEV8ZK4r7JliC6Ma9pkyTn5Xmq5/M9dqiVe/AbJwAizhMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "sophie.martin@teacher.com",
                            Subject = "Computer Science"
                        },
                        new
                        {
                            Id = "33333333-3333-3333-3333-333333333333",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ca2689e-4b26-405b-a5d4-f389e2825548",
                            DateOfBirth = new DateOnly(1984, 12, 15),
                            Email = "pierre.durand@teacher.com",
                            EmailConfirmed = true,
                            Firstname = "Pierre",
                            Lastname = "Durand",
                            LockoutEnabled = false,
                            NormalizedEmail = "PIERRE.DURAND@TEACHER.COM",
                            NormalizedUserName = "PIERRE.DURAND@TEACHER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEF86GJ+DdWWN9e/hyTgxhJlFObCa+jtuV7hTpX66QXHTyspTdnRGyssR+GGEXAeDRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "pierre.durand@teacher.com",
                            Subject = "Physics"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MVC_cours_isitech.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVC_cours_isitech.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_cours_isitech.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVC_cours_isitech.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
