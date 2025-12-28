using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Furni101.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bLogs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreateDate", "Description", "FirstName", "ImageUrl", "LastName", "Position", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7329), "Backend developer", "Ahmet", "person_1.jpg", "Yılmaz", "Software Developer", new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7341) },
                    { 2, new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7343), "Frontend designer", "Ayşe", "person_2.jpg", "Kaya", "UI/UX Designer", new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7343) },
                    { 3, new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7345), "Team lead", "Mehmet", "person_3.jpg", "Demir", "Project Manager", new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7345) },
                    { 4, new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7347), "Testing specialist", "Elif", "person_4.jpg", "Çelik", "QA Engineer", new DateTime(2025, 12, 25, 15, 7, 13, 670, DateTimeKind.Local).AddTicks(7347) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "ImageName", "ImageUrl", "IsDeleted", "Name", "Price", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-1", "product-1.png", false, "Product 1", 50.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-2", "product-2.png", false, "Product 2", 75.0, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-3", "product-3.png", false, "Product 3", 120.0, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-1", "product-1.png", false, "Product 4", 60.0, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-2", "product-2.png", false, "Product 5", 90.0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-3", "product-3.png", false, "Product 6", 150.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-1", "product-1.png", false, "Product 7", 110.0, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "product-2", "product-2.png", false, "Product 8", 200.0, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "bLogs",
                columns: new[] { "Id", "EmployeeId", "ImageUrl", "Text", "Title" },
                values: new object[,]
                {
                    { 1, 2, "post-1.jpg", "ASP.NET Core ", "ASP.NET Core " },
                    { 2, 3, "post-2.jpg", "Entity Framework Core", "Entity Framework Core " },
                    { 3, 1, "post-3.jpg", "Temiz kod, okunabilirliği artırır ve bakım maliyetlerini düşürür.", "Clean Code Yazmanın Önemi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bLogs_EmployeeId",
                table: "bLogs",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bLogs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
