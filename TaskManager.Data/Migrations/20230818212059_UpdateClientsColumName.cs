using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class UpdateClientsColumName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7c503cc-7eca-4268-a77d-a77196d0d603", "AQAAAAEAACcQAAAAEHmeRAKYfci1mdvpm+/TERCXl/EFXzhRIW7Z3K8Oo8XWfB4Ve3HIEhBP72NNPjV09Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88ab34f7-9bf2-4e84-a12f-e32b09ee0461", "AQAAAAEAACcQAAAAEFBToKVMcz7FLmCFzJ2T4b38AIWX4mq0SjPVUyPdSuopaWylP9cY//4Pj75LhDB1aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8a5d831-ec3a-478e-aaf7-893a5c9ffd86", "AQAAAAEAACcQAAAAENIu4ePx3hZmZj4WTLkRBSVJtK7A8B+WvcrY39FlH6IVxj6yEpWoA8ssvC16no7VVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "857830ca-099f-4831-9677-9c55850d86a4", "AQAAAAEAACcQAAAAEDRSvxKpmhjXGCNy0gEoXR6bsAKRBxxsmRgg2yQ2tiukpiW86kKxhLWllmVOE/osfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51822ed6-851a-4014-ae65-c6b2b7dbd650", "AQAAAAEAACcQAAAAEJhxMUB6O+HeLDbGy6HPPRnWz1Ba6ILt2pyUJx9E88JdTtXSgno8TKerDWvUVQsmJw==" });

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 20, 6, 44, 540, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 20, 6, 44, 540, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 20, 6, 44, 540, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 20, 6, 44, 540, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 18, 23, 6, 44, 540, DateTimeKind.Local).AddTicks(8019), new DateTime(2023, 8, 18, 23, 6, 44, 540, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 18, 23, 6, 44, 540, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 8, 18, 23, 6, 44, 540, DateTimeKind.Local).AddTicks(8000) });
        }
    }
}
