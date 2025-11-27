using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "452e9e96-4539-411d-befd-fc1041328885", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENgx7YXSWD/ecxuZVxv+dqzhEMpv65R3r0jCm3KlbCItz5sG8KzduTEv2/j8EDcZMw==", null, false, "b4aa3b73-f86d-45fb-b2dd-48db3530bff2", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4711), new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4725), new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4726), new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4876), new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4878), new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4951), new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4952), new DateTime(2025, 11, 27, 14, 6, 48, 354, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3391), new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3408), new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3409), new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3584), new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3586), new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3664), new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3665), new DateTime(2025, 11, 27, 13, 45, 41, 512, DateTimeKind.Local).AddTicks(3666) });
        }
    }
}
