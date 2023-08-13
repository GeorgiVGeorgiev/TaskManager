using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddGeoTaskDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentars_GeoTask_TaskId",
                table: "Comentars");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_GeoTask_TaskId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTask_Clients_ClientId",
                table: "GeoTask");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTask_Statuses_StatusId",
                table: "GeoTask");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTask_Types_TypeId",
                table: "GeoTask");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTask_Workers_CheckerId",
                table: "GeoTask");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTask_Workers_WorkerId",
                table: "GeoTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeoTask",
                table: "GeoTask");

            migrationBuilder.RenameTable(
                name: "GeoTask",
                newName: "GeoTasks");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTask_WorkerId",
                table: "GeoTasks",
                newName: "IX_GeoTasks_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTask_TypeId",
                table: "GeoTasks",
                newName: "IX_GeoTasks_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTask_StatusId",
                table: "GeoTasks",
                newName: "IX_GeoTasks_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTask_ClientId",
                table: "GeoTasks",
                newName: "IX_GeoTasks_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTask_CheckerId",
                table: "GeoTasks",
                newName: "IX_GeoTasks_CheckerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeoTasks",
                table: "GeoTasks",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comentars_GeoTasks_TaskId",
                table: "Comentars",
                column: "TaskId",
                principalTable: "GeoTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_GeoTasks_TaskId",
                table: "Documents",
                column: "TaskId",
                principalTable: "GeoTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTasks_Clients_ClientId",
                table: "GeoTasks",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTasks_Statuses_StatusId",
                table: "GeoTasks",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTasks_Types_TypeId",
                table: "GeoTasks",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTasks_Workers_CheckerId",
                table: "GeoTasks",
                column: "CheckerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTasks_Workers_WorkerId",
                table: "GeoTasks",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentars_GeoTasks_TaskId",
                table: "Comentars");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_GeoTasks_TaskId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTasks_Clients_ClientId",
                table: "GeoTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTasks_Statuses_StatusId",
                table: "GeoTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTasks_Types_TypeId",
                table: "GeoTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTasks_Workers_CheckerId",
                table: "GeoTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_GeoTasks_Workers_WorkerId",
                table: "GeoTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeoTasks",
                table: "GeoTasks");

            migrationBuilder.RenameTable(
                name: "GeoTasks",
                newName: "GeoTask");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTasks_WorkerId",
                table: "GeoTask",
                newName: "IX_GeoTask_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTasks_TypeId",
                table: "GeoTask",
                newName: "IX_GeoTask_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTasks_StatusId",
                table: "GeoTask",
                newName: "IX_GeoTask_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTasks_ClientId",
                table: "GeoTask",
                newName: "IX_GeoTask_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_GeoTasks_CheckerId",
                table: "GeoTask",
                newName: "IX_GeoTask_CheckerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeoTask",
                table: "GeoTask",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7dfec82-0820-42a9-9f3a-6dac8c395bc2", "AQAAAAEAACcQAAAAEJi6KFUqNMlGWwz64glYPQwq1DNP++jdUaBmWubr4HwO7E/kT8x9hd4iVK4QsJCYJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53bc0d44-0e72-4723-ad4b-b17b0b9b8201", "AQAAAAEAACcQAAAAEHqea2gRL0NC0HWq9MbI4WhBhhLK+zp511H+JRSkXlsAyQIifc2RdqYJfV1ioEEWjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c04c49ae-7e72-4461-993d-42b0990e1122", "AQAAAAEAACcQAAAAEEt1/3Cg9ebSDo47YpuWGe9v0RchXG/gI7qNa9N7nwU8o6lzwB/Zxz+B1+fB3k4KWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5faa7eb5-9e77-4a70-9027-d4ac3cced1cf", "AQAAAAEAACcQAAAAED7AdCOd3EwNqEovbfqz6y5H3KUiwp23lBkXOlIrBgdtAfUe+ACcpP7nPFqvC/1OBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26b327b5-cd89-410a-a72b-97bf5f816c0a", "AQAAAAEAACcQAAAAEHm0Vxf37nb3ZmPorY92rDJG6p3/jSH+S9mf8ecroKKtgR6Q6I5hlUgqn8RbDEMooA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comentars_GeoTask_TaskId",
                table: "Comentars",
                column: "TaskId",
                principalTable: "GeoTask",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_GeoTask_TaskId",
                table: "Documents",
                column: "TaskId",
                principalTable: "GeoTask",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTask_Clients_ClientId",
                table: "GeoTask",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTask_Statuses_StatusId",
                table: "GeoTask",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTask_Types_TypeId",
                table: "GeoTask",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTask_Workers_CheckerId",
                table: "GeoTask",
                column: "CheckerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeoTask_Workers_WorkerId",
                table: "GeoTask",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
