using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class ApplyUserSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a404651e-242e-4c16-80e6-484914568654", "AQAAAAEAACcQAAAAEHxYwhCPDCq3uaqa4P6syOTmX06piN3pdrvyI2KanGsa6XvMaKOt/vr/IbYNbPEM4g==", "D29361292CF01044B8FE9EAB4FFB4801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55f2796f-e09f-4814-a6fe-97e541be6cc8", "AQAAAAEAACcQAAAAEDFJv0ivGYlMf3bYMvgFcvRcrn0EXeKAOV+vQQ+EUJXOhaM1C4epOdnnruWRBSl1cw==", "F59E67350BBB6A4DBB376B0BFB32E801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da3f64e5-2053-4d3f-a124-d37589aaffa4", "AQAAAAEAACcQAAAAEAl0B4URtIiNIQwA9A+JJH/uWgp8l/DKCgZnIOq8cFdzOjie6kpssxWDVyHQMyKlKw==", "216EEF6C5151884EBE5CF4F78953BF84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b224dbcd-fe1b-4cd7-a390-3612db0920cc", "AQAAAAEAACcQAAAAEIz2hF21cxOerOaUsd8IJ1aP9XVSIJUbWDsL7Oxq/Ol2m6gF1R+gHBiLTAItfS0wUg==", "7BD0706EA7EA8443B233C5EF9C0BF8DE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6ecf59a-92b2-4ecb-8deb-7cadcf682a5b", "AQAAAAEAACcQAAAAECLPXXm+Ljvagp05a7dmhCRgv6dBUJ0uGoyEZgrFDXJZeAJ0vW4Vr2qe+Ryk0MQuwQ==", "72F0B4BCCAECC943AB26C060C6F364E4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2bcda16-aed4-4b47-a4f8-4966070eba1b", "AQAAAAEAACcQAAAAEKhqmyKjxY0w5kxkMJUUuaop2EOrFLrBhAXPFEDprHzteLmg8LrBIsnDISGG6CNdQg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ac80574-2239-4a67-9d28-c827cdf5ae6a", "AQAAAAEAACcQAAAAEJR8mGc/ySKWsr4qgh17paMNUmAS4X6IhKjAgP/pCD9YQzd9eDZJoiTp6QIPxVcBzQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ac5347b-9e78-4f98-b748-88a051b55bdf", "AQAAAAEAACcQAAAAEINIlJqYlrHlaWJ0HNZ7SusBdDXdVC0GT12TNzQP8FDPkR7iNP0FLbGGaQ8qcjHl+g==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfe28dca-0ecd-4d6e-84f6-75a907b2b639", "AQAAAAEAACcQAAAAEBh/4VS6D5EZbsVe6PXc8j3yVKqP6WTrgN0Mjn1PJ6ZpE+zS7QdDIwvgqJsCC+c6bQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "061ec1c7-9509-438f-9b7a-a12c6e45ad2d", "AQAAAAEAACcQAAAAEJrRkukgyJQzKLGBdo4l66QFsgEa81eJlqDw2KnFBkIwE6FWu3mmfX7PEQam0Q6hDw==", null });
        }
    }
}
