using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class Update_Salary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salary_Workers_WorkerId",
                table: "Salary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salary",
                table: "Salary");

            migrationBuilder.RenameTable(
                name: "Salary",
                newName: "Salaries");

            migrationBuilder.RenameIndex(
                name: "IX_Salary_WorkerId",
                table: "Salaries",
                newName: "IX_Salaries_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b87d687b-9d99-47f7-8b75-8f2961ce4ee9", "AQAAAAEAACcQAAAAEFDlIS4RFbNYLDRiIwv1gvT6tgNSLmb3p8Xa2k6WmpkkeDSObBt9/zj/FjTKTChxtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6309854d-0f2c-4162-a560-d6ad23a07ae8", "AQAAAAEAACcQAAAAEDgTAf+bwBAJelZLsLw7kFlTBIjCzHtF7x+naYtmt+YLAeL5Ikl/iBuJpbkL56G6Yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "411d3a61-8ceb-48a3-a29e-50b47c2e962c", "AQAAAAEAACcQAAAAEIk+cRKQTgOXGp69hqulhRe3Q+JrCd+qRs0faKgAC5M9DFHw7PTxuggHU/1ob5UBRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b3bc8e5-cef1-4909-9ee3-5060ffd6de27", "AQAAAAEAACcQAAAAECK880AIcd1UPwJmGn4+ccjVBXDKgsPnkAu1vBoigXNBLwkSgZ6swcUtmruQtPsuhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0bff4f8f-c491-4fe3-9ea8-2b83ee75db2b", "AQAAAAEAACcQAAAAEB2lv7xUEcmUAB2ndPuyZwtYYL/EaxUThpqP7fWeh4zJP56yWI46HgnqaT+ghFqkYQ==" });

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 17, 57, 1, 599, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 17, 57, 1, 599, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 17, 57, 1, 599, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 14, 17, 57, 1, 599, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2024, 1, 14, 19, 57, 1, 599, DateTimeKind.Local).AddTicks(6181), new DateTime(2024, 1, 14, 19, 57, 1, 599, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2024, 1, 14, 19, 57, 1, 599, DateTimeKind.Local).AddTicks(6144), new DateTime(2024, 1, 14, 19, 57, 1, 599, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2024, 1, 14, 19, 57, 1, 599, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2024, 1, 14, 19, 57, 1, 599, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2024, 1, 14, 19, 57, 1, 599, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Workers_WorkerId",
                table: "Salaries",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Workers_WorkerId",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "Salary");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_WorkerId",
                table: "Salary",
                newName: "IX_Salary_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salary",
                table: "Salary",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2023, 12, 31, 14, 55, 30, 337, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.AddForeignKey(
                name: "FK_Salary_Workers_WorkerId",
                table: "Salary",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
