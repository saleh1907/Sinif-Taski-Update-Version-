using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Furni101.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4479), new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4494), new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4496), new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 12, 29, 2, 0, 51, 502, DateTimeKind.Local).AddTicks(4498) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7329), new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7343), new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7345), new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7347), new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7347) });
        }
    }
}
