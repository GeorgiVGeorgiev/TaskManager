using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddDateToComentar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Comentars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Comentars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a835b3f-e58e-49f2-8075-e7ba0ea018d2", "AQAAAAEAACcQAAAAELbpF/qm5gp5x9txiLG4JBBaSGf9CWIH4VqkjC8NoK8IrybzrFXCRiW50ROC6aFNcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f1ee588-80f1-4d11-8ad2-773b9cb7706f", "AQAAAAEAACcQAAAAEM3ug67Lck1kd8bWRqx3veE6Iovet7g/iXFd3RJN/YlNMZ6YvOwezELmTT6vKLG5Tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "579413a2-5d96-4a9f-93f9-17b903c8f830", "AQAAAAEAACcQAAAAEA8kyv6yKmbCnRUeYX0x8tH/UTJOCzP93GdoNs5VuNDQYiyzRXCrc3hhfAemxNRo4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3193902b-36c2-447e-8b65-c86d68bc487c", "AQAAAAEAACcQAAAAEDvvcCdzOasZ7/Hl2zqjgh0pAQ635OGR0wePVjJTR8dGeFixjjMef/zyP0N/81/NnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd6fa78a-9a7d-401f-99f7-a0d14a578aac", "AQAAAAEAACcQAAAAEEcMrcXRVKiquKCi3a3cWEX8piOvHRgfdZ0FuPwpZyfTE6UwWKmO6JcBPSN7NJzfig==" });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"),
                columns: new[] { "CreateDate", "EndDate" },
                values: new object[] { new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6575), new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6600) });
        }
    }
}
