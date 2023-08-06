using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class ApplyUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"), 0, "a2bcda16-aed4-4b47-a4f8-4966070eba1b", "User2@base.bg", false, "Първан", "Георгиев", false, null, "User2@base.bg", "User2@base.bg", "AQAAAAEAACcQAAAAEKhqmyKjxY0w5kxkMJUUuaop2EOrFLrBhAXPFEDprHzteLmg8LrBIsnDISGG6CNdQg==", null, false, null, false, "User2@base.bg" },
                    { new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"), 0, "5ac80574-2239-4a67-9d28-c827cdf5ae6a", "Worker1@base.bg", false, "Първан", "Георгиев", false, null, "Worker1@base.bg", "Worker1@base.bg", "AQAAAAEAACcQAAAAEJR8mGc/ySKWsr4qgh17paMNUmAS4X6IhKjAgP/pCD9YQzd9eDZJoiTp6QIPxVcBzQ==", null, false, null, false, "Worker1@base.bg" },
                    { new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"), 0, "3ac5347b-9e78-4f98-b748-88a051b55bdf", "Worker2@base.bg", false, "Иван", "Иванов", false, null, "Worker2@base.bg", "Worker2@base.bg", "AQAAAAEAACcQAAAAEINIlJqYlrHlaWJ0HNZ7SusBdDXdVC0GT12TNzQP8FDPkR7iNP0FLbGGaQ8qcjHl+g==", null, false, null, false, "Worker2@base.bg" },
                    { new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"), 0, "dfe28dca-0ecd-4d6e-84f6-75a907b2b639", "User1@base.bg", false, "Евелина", "Георгиева", false, null, "User1@base.bg", "User1@base.bg", "AQAAAAEAACcQAAAAEBh/4VS6D5EZbsVe6PXc8j3yVKqP6WTrgN0Mjn1PJ6ZpE+zS7QdDIwvgqJsCC+c6bQ==", null, false, null, false, "User1@base.bg" },
                    { new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"), 0, "061ec1c7-9509-438f-9b7a-a12c6e45ad2d", "administrator@admin", false, "Георги", "Георгиев", false, null, "administrator@admin", "administrator@admin", "AQAAAAEAACcQAAAAEJrRkukgyJQzKLGBdo4l66QFsgEa81eJlqDw2KnFBkIwE6FWu3mmfX7PEQam0Q6hDw==", null, false, null, false, "administrator@admin" }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "PhoneNumber", "Position", "UserId" },
                values: new object[] { new Guid("a13c085f-4d96-4244-8ea4-607c4b6989f6"), "0899999999", "Admin", new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4") });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "PhoneNumber", "Position", "UserId" },
                values: new object[] { new Guid("acda7da9-d7a0-4fd0-9aca-f6000da77582"), "0877777777", "Проектант", new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84") });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "PhoneNumber", "Position", "UserId" },
                values: new object[] { new Guid("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a"), "0888888888", "Мерач", new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"));

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: new Guid("a13c085f-4d96-4244-8ea4-607c4b6989f6"));

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: new Guid("acda7da9-d7a0-4fd0-9aca-f6000da77582"));

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: new Guid("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"));
        }
    }
}
