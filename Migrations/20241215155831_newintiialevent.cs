using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_cours_isitech.Migrations
{
    /// <inheritdoc />
    public partial class newintiialevent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27c1fb3e-551b-4d28-9b92-c6ec6de8375c", "AQAAAAIAAYagAAAAEFr1vDTAysH7DrX1FPfbv9+K9npX+yyMd6l1bUpC/u6H10rIWRsfSBBQiwU8HzZFKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df3f375a-b787-4e98-965b-37e78ddc5fa4", "AQAAAAIAAYagAAAAENGSnaIYELYglsolCCjG91WIMgjIwLoloavH7BltTKwAKhSpbhQVICFjuN2TjahHOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6ae3335-55e2-47a2-b4fa-7834f7ae2340", "AQAAAAIAAYagAAAAEGUOwOq3YD/o531VbVWLyPa4Vk35PIkT0vJB3i1fi44vBVKlh0vCRymK9xW4evs/JA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96a93880-4548-4768-9b9a-d397dd91d319", "AQAAAAIAAYagAAAAEMg+4XwZTYHBZ2qcPslqlKECew2r1yJ0W3b6IZZxFcyJQD7LCJObXnX08oTemzlhRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e79031f-62b6-4311-af81-c9118dffe332", "AQAAAAIAAYagAAAAEIXuuKaoWyHLdUTHr8DVTLhXeuHATWwZS+6oiF0F2w48GsSXD0SAFTi8lVQ7QQIsNw==" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 12, 22, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6915), new DateTime(2024, 12, 29, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6920), new DateTime(2025, 1, 5, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6924), new DateTime(2025, 1, 14, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 12, 13, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedAt", "Description", "EventDate", "Location", "MaxParticipants", "Title" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 12, 13, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6946), "Un weekend complet dédié à la création de jeux vidéo. Venez avec vos idées et repartez avec un prototype jouable !", new DateTime(2025, 1, 29, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6945), "Espace Gaming", 60, "Game Jam - Création de Jeux Vidéo" },
                    { 7, new DateTime(2024, 12, 7, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6951), "Initiation pratique à Python et aux bibliothèques de data science (Pandas, NumPy, Scikit-learn)", new DateTime(2024, 12, 25, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6949), "Laboratoire Data", 30, "Workshop Data Science" },
                    { 8, new DateTime(2024, 12, 11, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6955), "Découvrez les services fondamentaux d'Amazon Web Services et déployez votre première application", new DateTime(2024, 12, 30, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6953), "Salle Cloud", 40, "Cloud Computing - AWS Basics" },
                    { 9, new DateTime(2024, 12, 9, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6967), "Apprenez à résoudre des problèmes complexes avec la méthodologie du Design Thinking", new DateTime(2024, 12, 20, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(6957), "Studio Design", 25, "Design Thinking Workshop" },
                    { 10, new DateTime(2024, 12, 14, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7006), "Formation intensive sur le développement d'applications mobiles avec Flutter", new DateTime(2025, 2, 13, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7005), "Lab Mobile", 35, "Mobile App Development" },
                    { 11, new DateTime(2024, 12, 12, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7010), "Une journée dédiée à la sécurité des réseaux et aux bonnes pratiques", new DateTime(2025, 1, 9, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7009), "Salle Sécurité", 45, "Network Security Masterclass" },
                    { 12, new DateTime(2024, 12, 10, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7014), "Les principes essentiels du design d'interface et de l'expérience utilisateur", new DateTime(2024, 12, 27, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7013), "Design Lab", 30, "UX/UI Design Fundamentals" },
                    { 13, new DateTime(2024, 12, 8, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7018), "Formation aux méthodologies agiles et à la gestion de projet moderne", new DateTime(2025, 1, 2, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7017), "Salle Agile", 50, "Agile Project Management" },
                    { 14, new DateTime(2024, 12, 6, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7022), "Explorez les outils et techniques d'analyse de données massives", new DateTime(2025, 1, 19, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7021), "Data Center", 40, "Big Data Analytics" },
                    { 15, new DateTime(2024, 12, 11, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7026), "Création de projets connectés avec Arduino et Raspberry Pi", new DateTime(2025, 1, 12, 16, 58, 31, 24, DateTimeKind.Local).AddTicks(7025), "Lab IoT", 20, "IoT Workshop" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc4a75bf-122b-4275-8f8c-fac1095c7641", "AQAAAAIAAYagAAAAEIV610t0GLUxywskb/7fEMn9Gk+HguwnZoIxRoNxNAuyNxsGHOavGW4Qj8bW8uu1KA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34727a67-a336-4cdb-b113-7cc87d55b284", "AQAAAAIAAYagAAAAEEVUXG6nHKszmr1kOcSVJEV8ZK4r7JliC6Ma9pkyTn5Xmq5/M9dqiVe/AbJwAizhMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ca2689e-4b26-405b-a5d4-f389e2825548", "AQAAAAIAAYagAAAAEF86GJ+DdWWN9e/hyTgxhJlFObCa+jtuV7hTpX66QXHTyspTdnRGyssR+GGEXAeDRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4967e441-8a87-4a26-b11a-7d1772e2d5b8", "AQAAAAIAAYagAAAAEOZyUXLQKQ2MFzzmNVICKvccKPgqvSqRv0/5Bpbq0756S3CRb2vtMITHky2HQBWZRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75476612-9adf-4f77-926b-4df84823741e", "AQAAAAIAAYagAAAAEPCrZtH5D0xjAgi+erMukJI0WTDKfxZrZ+icWkyJmuvPytCxqxFHIXuUNj7SlR8pLg==" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2371), new DateTime(2024, 12, 22, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 12, 29, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2382), new DateTime(2025, 1, 5, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2387), new DateTime(2025, 1, 14, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EventDate" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 12, 13, 16, 44, 45, 363, DateTimeKind.Local).AddTicks(2406) });
        }
    }
}
