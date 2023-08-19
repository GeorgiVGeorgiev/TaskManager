using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddSeedToClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CustomerRepresentative", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("4add1981-c1eb-4666-bbc4-9c954e6925f5"), "Иван Петков", "IvanPetkov@work.bg", "Георги Петков", "0895555555" },
                    { new Guid("56f03003-c382-4428-997f-a975d7846608"), "Владимир Иванов", "GerganaPetrova@work.bg", "Няма", "0892222222" },
                    { new Guid("9153e1a7-1565-48ff-8edf-9edf26f5d26b"), "Сашо Иванов", "SashoIvanov@work.bg", "Михаела Иванова", "0894444444" },
                    { new Guid("c3f9f394-3b6e-4f8a-a08e-820ea06e4c60"), "Петър Георгиев", "GerganaPetrova@work.bg", "Гергана Петрова", "0893333333" }
                });

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
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 8, 19, 15, 4, 40, 786, DateTimeKind.Local).AddTicks(7886) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4add1981-c1eb-4666-bbc4-9c954e6925f5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("56f03003-c382-4428-997f-a975d7846608"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9153e1a7-1565-48ff-8edf-9edf26f5d26b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c3f9f394-3b6e-4f8a-a08e-820ea06e4c60"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f14cc1e-b7f9-4594-89ff-30e1b288f738", "AQAAAAEAACcQAAAAELf1RWJhjR4FZpJy2y8CKTvrdT8LKF4co2+MwAqW5yOEToZpXCzqqWFi1zLV0bMUhQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27ed572a-791b-4042-9dbf-706823d6443e", "AQAAAAEAACcQAAAAEJxpFqHBkqQO4XziRX2vzl3tocPshBLqnJJkcKyzstyCg39ehY8+7oXFzxO3SQKYHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8dce39b-0f84-4670-b0c1-a3efe08f93c1", "AQAAAAEAACcQAAAAEMS5V9Y2Rci8S9NJAxKjV4aV5nEmDo6RZsXH3ymNw+gy/EZdjW/78Yn1Opd9zkCEaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7d6c9f4-3a3c-4edd-8d26-4017dd8f59c3", "AQAAAAEAACcQAAAAEE1BuCiQ/b71szbAOuEesB0Tr3WKf9sKDy+Ggcjp8WsNkuE4aX078HJKpIvgEcKSVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bcdb314-fe6a-420c-a4b8-e0e163964397", "AQAAAAEAACcQAAAAEOV1QhfxR8xacMDD3JHMym3xqqQ7qbMgJlbm5Czmb2q8Eau/RqK9Mf33T82cTogiKQ==" });

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 21, 20, 59, 91, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 21, 20, 59, 91, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 21, 20, 59, 91, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 21, 20, 59, 91, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 20, 59, 91, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 8, 19, 0, 20, 59, 91, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 20, 59, 91, DateTimeKind.Local).AddTicks(7485), new DateTime(2023, 8, 19, 0, 20, 59, 91, DateTimeKind.Local).AddTicks(7513) });
        }
    }
}
