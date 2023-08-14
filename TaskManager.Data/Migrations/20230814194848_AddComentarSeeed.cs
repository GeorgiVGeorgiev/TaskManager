using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddComentarSeeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Нова" },
                    { 2, "В процес на изпълнение" },
                    { 3, "Приключена" }
                });

            migrationBuilder.InsertData(
                table: "GeoTasks",
                columns: new[] { "Id", "Adrress", "CheckerId", "ClientId", "CreateDate", "EndDate", "IdKKKR", "Note", "Price", "ProjectNumber", "StatusId", "TypeId", "WorkerId", "quantity" },
                values: new object[] { new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"), "Надежда 1", new Guid("a13c085f-4d96-4244-8ea4-607c4b6989f6"), new Guid("2016aa91-7b89-4524-92e1-3606cbda65c8"), new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6611), "68134.905.11", "Няма", 250m, 2, 1, 5, new Guid("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a"), 1 });

            migrationBuilder.InsertData(
                table: "GeoTasks",
                columns: new[] { "Id", "Adrress", "CheckerId", "ClientId", "CreateDate", "EndDate", "IdKKKR", "Note", "Price", "ProjectNumber", "StatusId", "TypeId", "WorkerId", "quantity" },
                values: new object[] { new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"), "Надежда 1", new Guid("a13c085f-4d96-4244-8ea4-607c4b6989f6"), new Guid("890c29d4-841a-490c-8b85-07af2ba826fd"), new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6575), new DateTime(2023, 8, 14, 22, 48, 47, 700, DateTimeKind.Local).AddTicks(6600), "68134.905.11", "Няма", 500m, 1, 1, 3, new Guid("acda7da9-d7a0-4fd0-9aca-f6000da77582"), 2 });

            migrationBuilder.InsertData(
                table: "Comentars",
                columns: new[] { "Id", "Description", "TaskId", "WorkerId" },
                values: new object[,]
                {
                    { 1, "Това е тестов коментар за първата задача. От проектант 1.", new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"), new Guid("acda7da9-d7a0-4fd0-9aca-f6000da77582") },
                    { 2, "Това е втори тестов коментар за първата задача. От проектант 2.", new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"), new Guid("1702e507-b3fc-48a0-808d-d989bd8a4697") },
                    { 3, "Това е трети тестов коментар за първата задача. От Админ.", new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"), new Guid("a13c085f-4d96-4244-8ea4-607c4b6989f6") },
                    { 4, "Това е четвърти тестов коментар за първата задача. От Мерач.", new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"), new Guid("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comentars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("6e6de662-426f-4ff2-9886-984fa1c46a81"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GeoTasks",
                keyColumn: "Id",
                keyValue: new Guid("88439927-1864-4962-9c31-d32e86f6ec0c"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a01a8a1c-0251-4fbc-85c1-7b8ece4c5ef4", "AQAAAAEAACcQAAAAECKcBHrZGO1V/ZITBB+R5PZB82sNURbXfC3yevpwVk6zZMNOXUs1bI19Famlhiachg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac469146-cc87-4030-bff8-0bf8c2b6618b", "AQAAAAEAACcQAAAAEFCejRsRoyd8uVlw2JCr70OHY5rfIaL4JaPpywDXkJfmuRlng688GAFf9QbFLX2Oyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3edb7505-fd18-41ee-9dbb-a672326a70dd", "AQAAAAEAACcQAAAAEGiPMJmzC3BnHlFqpwmF9d1pf4O4hH/V0yuSH0+OlvVRMyWzGw3EAl9hpdhZjk7uEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46b35ee3-bcf2-47df-89e6-56618e61e8d4", "AQAAAAEAACcQAAAAEMpCeP02rmPFsRtMc/0I9ESFp3dXRz/ct6KagaO6Hy1rZfSJzkv+nW0lJNhPN6z9/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b25435a9-9413-4127-aa3c-5bb3e8b69ccf", "AQAAAAEAACcQAAAAEC0giUTeKkkflltft+akQQLmPxlU1FfzaTrUId1rHWbVzIQ7Tv/aHkM6o5yjRxLNdw==" });
        }
    }
}
