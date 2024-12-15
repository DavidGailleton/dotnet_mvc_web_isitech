using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_cours_isitech.Migrations
{
    /// <inheritdoc />
    public partial class moreinitialdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "22222222-2222-2222-2222-222222222222" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "Email", "Firstname", "Lastname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Subject", "UserName" },
                values: new object[] { "cc4a75bf-122b-4275-8f8c-fac1095c7641", new DateOnly(1989, 12, 15), "martin.dupont@teacher.com", "Martin", "Dupont", "MARTIN.DUPONT@TEACHER.COM", "MARTIN.DUPONT@TEACHER.COM", "AQAAAAIAAYagAAAAEIV610t0GLUxywskb/7fEMn9Gk+HguwnZoIxRoNxNAuyNxsGHOavGW4Qj8bW8uu1KA==", "Mathematics", "martin.dupont@teacher.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Subject", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22222222-2222-2222-2222-222222222222", 0, "34727a67-a336-4cdb-b113-7cc87d55b284", new DateOnly(1994, 12, 15), "Teacher", "sophie.martin@teacher.com", true, "Sophie", "Martin", false, null, "SOPHIE.MARTIN@TEACHER.COM", "SOPHIE.MARTIN@TEACHER.COM", "AQAAAAIAAYagAAAAEEVUXG6nHKszmr1kOcSVJEV8ZK4r7JliC6Ma9pkyTn5Xmq5/M9dqiVe/AbJwAizhMw==", null, false, "", "Computer Science", false, "sophie.martin@teacher.com" },
                    { "33333333-3333-3333-3333-333333333333", 0, "9ca2689e-4b26-405b-a5d4-f389e2825548", new DateOnly(1984, 12, 15), "Teacher", "pierre.durand@teacher.com", true, "Pierre", "Durand", false, null, "PIERRE.DURAND@TEACHER.COM", "PIERRE.DURAND@TEACHER.COM", "AQAAAAIAAYagAAAAEF86GJ+DdWWN9e/hyTgxhJlFObCa+jtuV7hTpX66QXHTyspTdnRGyssR+GGEXAeDRQ==", null, false, "", "Physics", false, "pierre.durand@teacher.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "44444444-4444-4444-4444-444444444444", 0, "4967e441-8a87-4a26-b11a-7d1772e2d5b8", new DateOnly(2004, 12, 15), "Student", "lucas.petit@student.com", true, "Lucas", "Petit", false, null, "Computer Science", "LUCAS.PETIT@STUDENT.COM", "LUCAS.PETIT@STUDENT.COM", "AQAAAAIAAYagAAAAEOZyUXLQKQ2MFzzmNVICKvccKPgqvSqRv0/5Bpbq0756S3CRb2vtMITHky2HQBWZRg==", null, false, "", false, "lucas.petit@student.com" },
                    { "55555555-5555-5555-5555-555555555555", 0, "75476612-9adf-4f77-926b-4df84823741e", new DateOnly(2002, 12, 15), "Student", "emma.moreau@student.com", true, "Emma", "Moreau", false, null, "Mathematics", "EMMA.MOREAU@STUDENT.COM", "EMMA.MOREAU@STUDENT.COM", "AQAAAAIAAYagAAAAEPCrZtH5D0xjAgi+erMukJI0WTDKfxZrZ+icWkyJmuvPytCxqxFHIXuUNj7SlR8pLg==", null, false, "", false, "emma.moreau@student.com" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedAt", "Description", "EventDate", "Location", "MaxParticipants", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 10, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2371), "Découvrez les fondamentaux de l'IA et ses applications dans le monde moderne", new DateTime(2024, 12, 22, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2353), "Amphithéâtre A", 100, "Introduction à l'Intelligence Artificielle" },
                    { 2, new DateTime(2024, 12, 12, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2377), "Pratiques et outils essentiels pour le DevOps moderne", new DateTime(2024, 12, 29, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2376), "Salle Informatique 2", 50, "Workshop DevOps" },
                    { 3, new DateTime(2024, 12, 8, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2382), "Les dernières tendances en matière de sécurité informatique", new DateTime(2025, 1, 5, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2381), "Amphithéâtre B", 150, "Conférence Cybersécurité" },
                    { 4, new DateTime(2024, 12, 5, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2387), "48h pour développer des solutions innovantes", new DateTime(2025, 1, 14, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2385), "Campus Innovation Hub", 80, "Hackathon Innovation" },
                    { 5, new DateTime(2024, 11, 30, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2408), "Explorer l'avenir du web décentralisé", new DateTime(2024, 12, 13, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2406), "Salle de Conférence C", 120, "Web 3.0 et Blockchain" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "22222222-2222-2222-2222-222222222222" },
                    { "2", "33333333-3333-3333-3333-333333333333" },
                    { "3", "44444444-4444-4444-4444-444444444444" },
                    { "3", "55555555-5555-5555-5555-555555555555" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "22222222-2222-2222-2222-222222222222" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "33333333-3333-3333-3333-333333333333" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "44444444-4444-4444-4444-444444444444" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "55555555-5555-5555-5555-555555555555" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "Email", "Firstname", "Lastname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Subject", "UserName" },
                values: new object[] { "6dce7eb8-1a57-4774-9ef3-2dcb1ee572e8", new DateOnly(1994, 12, 15), "teacher@example.com", "John", "Doe", "TEACHER@EXAMPLE.COM", "TEACHER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN4hPXwGu0udXkoQaoLPGRUuq9oLH6GA5fnrv7C0x5FCx+0dX/OoOf31WS6ur8VL3Q==", "Computer Science", "teacher@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "Major", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "22222222-2222-2222-2222-222222222222", 0, "5bf77ef9-739d-459e-9011-88b819e08e92", new DateOnly(2004, 12, 15), "Student", "student@example.com", true, "Jane", "Smith", false, null, "Computer Science", "STUDENT@EXAMPLE.COM", "STUDENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFcy1illQyHC6HtOQlHGzHDavIOK2rsHYXYh4VpSPS2xKoehfcWY44ZQrDdiQnui7Q==", null, false, "", false, "student@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "22222222-2222-2222-2222-222222222222" });
        }
    }
}
