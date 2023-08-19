using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddSeedForRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CustomerRepresentative", "Email", "Name", "PhoneNumber" },
                values: new object[] { new Guid("3e05c605-d947-4c9e-ac82-e4746822ba7d"), "---------", "nqma@nqma.bg", "---------", "0000000000" });

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
                columns: new[] { "ClientId", "CreateDate", "EndDate", "Note" },
                values: new object[] { new Guid("4add1981-c1eb-4666-bbc4-9c954e6925f5"), new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2217), "Някаква забележка." });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "ClientId", "CreateDate", "EndDate" },
                values: new object[] { new Guid("9153e1a7-1565-48ff-8edf-9edf26f5d26b"), new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 8, 19, 17, 24, 59, 508, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Description", "IsApproved", "Name", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("3a9acc4a-688c-46bb-9a02-054953bfc726"), "Искам да бъде извършено геодезическо заснемане на площ на Мазе и Таван.", false, "Ивка Иванова", "0896666666", new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801") },
                    { new Guid("6bdfe00a-5aa3-4dd4-b8a5-c75569188ea7"), "Искам да бъде извършено геодезическо заснемане за дървестна растителност.", false, "Пенка Пенкова", "0896666666", new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de") },
                    { new Guid("9be32474-42d4-40a3-a1ee-54fc07aaebab"), "Искам да бъде извършено геодезическо заснемане по чл.19 от ЗУЗСО.", false, "Пенка Пенкова", "0896666666", new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de") },
                    { new Guid("e9eef419-f1c8-4880-841d-318d6c09cbf7"), "Искам да бъде извършено геодезическо заснемане на площ на Апартамент.", false, "Ивка Иванова", "0896666666", new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3e05c605-d947-4c9e-ac82-e4746822ba7d"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("3a9acc4a-688c-46bb-9a02-054953bfc726"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("6bdfe00a-5aa3-4dd4-b8a5-c75569188ea7"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("9be32474-42d4-40a3-a1ee-54fc07aaebab"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("e9eef419-f1c8-4880-841d-318d6c09cbf7"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bab0b676-4368-4e3a-8b31-df0c68fbcb37", "AQAAAAEAACcQAAAAEL6u6I1RFxhKnqmIR1c+YoDTIRCp2XJBqh2jmIFhyE87OctiyI1CdCehDkRkWD+0OQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30a6d183-0d5b-4e99-9de0-d256a97331d1", "AQAAAAEAACcQAAAAEEp2MJt44esOq6RtBkvrIasVjntxvKuQmYL/P0ZaapmlklWY6HNJlkwR8YDJr3bHXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4277487-260a-48c9-ba00-9dabc255ccd6", "AQAAAAEAACcQAAAAEC82LbmgWI5EzrIV5gU0fXY8+j/eZ6Wv2t70GVEqnsCKN2DPL3eniOsj+p7s1sCpLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "062cd531-9cdb-4bb5-972c-30aa9e063b79", "AQAAAAEAACcQAAAAEHSVUpqtjVIksfu7AwXhk537O1FA5JmsbWcmXMni+aaVOf1IfJCsSMtmwG+EFKkM1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14aaca9b-04be-4e79-8457-fd98bb66b0e8", "AQAAAAEAACcQAAAAEOkbDjbIi+MiHXHT0aZQjkZzNBokDJ6Ux06lzOGpGgZaFj0wCurt/mNMBMzPxaaGJQ==" });

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 12, 4, 40, 786, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 12, 4, 40, 786, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 12, 4, 40, 786, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 19, 12, 4, 40, 786, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"),
                columns: new[] { "ClientId", "CreateDate", "EndDate", "Note" },
                values: new object[] { new Guid("2016aa91-7b89-4524-92e1-3606cbda65c8"), new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7925), "Няма" });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "ClientId", "CreateDate", "EndDate" },
                values: new object[] { new Guid("890c29d4-841a-490c-8b85-07af2ba826fd"), new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7886) });
        }
    }
}
