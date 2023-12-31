using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddRolesAndSalaryForWorkers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetSalary = table.Column<double>(type: "float", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salary_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("2b37ccc1-0b8e-412e-9c23-617a75f35be6"), "E98C6623-AF8C-46E9-9509-C4E0B4809E7A", "Worker", "WORKER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e29ba72a-71a4-4b35-ac3e-3271e0269e96", "AQAAAAEAACcQAAAAEH/MC+YUd88m0YlBPMD1BzyJwlsxgD+4y4hLvY1Y23CtCdHPTU9GqstmHQp3an+v/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d1893c8-6dff-4915-bb71-638989e4df5a", "AQAAAAEAACcQAAAAEHIamBOoU4R7pobX4M5FwK6EabVZabuG/TkX+bFrNFi+6bbk3qHCdQTBg4VTIqg8cQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1cfddd1-a364-4765-8abf-8484ecd4c282", "AQAAAAEAACcQAAAAEAMmM9y63dLNGQswnNnbb+JH2V03W1p4y/U5seNL/cZLCozD6ynFW1E26WL9R/orwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f129df7f-1527-4d1a-b240-2f84fe96a521", "AQAAAAEAACcQAAAAEI0NuBTZrTCbXdRbvdvCmTjDdfpOSsdq0kAH6XA1vdoNfpJCJ6uZHOMdYpmEMTWP0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4d8401b-7320-4e5f-9332-964690ff66fa", "AQAAAAEAACcQAAAAEOMzrOlocfp+P5TJVwCF6FT1Xhir0uWA8NO0PeUca+4/NJ5I7UzjBnEwKsopCz1LDg==" });

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 12, 55, 30, 336, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 12, 55, 30, 336, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 12, 55, 30, 336, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 12, 55, 30, 336, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "ChangeDate", "NetSalary", "WorkerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(8140), 2500.0, new Guid("a13c085f-4d96-4244-8ea4-607c4b6989f6") },
                    { 2, new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(8145), 1000.0, new Guid("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a") },
                    { 3, new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(8148), 1500.0, new Guid("acda7da9-d7a0-4fd0-9aca-f6000da77582") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2b37ccc1-0b8e-412e-9c23-617a75f35be6"), new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2b37ccc1-0b8e-412e-9c23-617a75f35be6"), new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84") });

            migrationBuilder.CreateIndex(
                name: "IX_Salary_WorkerId",
                table: "Salary",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2b37ccc1-0b8e-412e-9c23-617a75f35be6"), new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2b37ccc1-0b8e-412e-9c23-617a75f35be6"), new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2b37ccc1-0b8e-412e-9c23-617a75f35be6"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df540f75-edcb-49ae-b780-429db6f2e2d7", "AQAAAAEAACcQAAAAEJhKa/DY5RfbBwi4cxtDO945p9eioTS2+Z9yH8tCUXo1I/SHAQMYXcrrElnOJ6m5sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da975352-ae47-47e5-9c54-1d02f8b6abd8", "AQAAAAEAACcQAAAAEGJtBw2y8DfTvgw9aXgyq5WZXp+LNEXsh95YbdPw8ostctVPoFcC21pMpQn+CsFvKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f798978c-0a68-4500-b58c-274afc35b3d8", "AQAAAAEAACcQAAAAEBlGwXo0cwBcaYM7cTocicOp+eIIO5aWTzbqtz7BNTreb+1bH83mKGJ9elHdmwlzUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d3b38a3-8665-4dc7-bde1-232538009dec", "AQAAAAEAACcQAAAAEN7spmvZEQDJxEJVTV2m8pJwjADiFIoendf6MdaJAiuPhPO1jGlkVFg1y6C79uTjSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87dfe06c-8e71-4afe-89f4-7be02a5040f2", "AQAAAAEAACcQAAAAEMq2GqE7N9ee1cChu2w7F60upQiVfMtJdx0xe2gk/d1q7c546MM0cQtmKrXjKR+F4Q==" });

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 14, 24, 59, 507, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 14, 24, 59, 507, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 14, 24, 59, 507, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 14, 24, 59, 507, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2204) });
        }
    }
}
