using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddTaskTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e98fb330-4a66-44fd-9c8c-c994167ac9bb", "AQAAAAEAACcQAAAAEMigtySRvVralcew67P3SpQsLttUSwTkceiilTpCN3jGN6EWi8GIISAhAusdNoCxfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06a31c4c-0b00-4edf-8a18-6efebcb14895", "AQAAAAEAACcQAAAAEDl4SBPjNZttl/+R0Jt/Xe8VqxC3yL/NbPZ00Xz/i/x2JkoFHpkXHxEZ0w1vrLa5PQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1dfbdff-95e3-46d8-bdc5-296c4d5e6748", "AQAAAAEAACcQAAAAEGPJ+zAsDWClpl4fMzeYTRzFdCuK/+RCJFmMoCoSMXwd2YvwGzHW0akeI3xNz7IkeQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ad18b24-6154-4d78-9137-40d5ba92be72", "AQAAAAEAACcQAAAAELUPd69IvzGShf/vE/81NlRDOg8wYN0CMeUDeeW0HmP1oWPusPBeFbOuwCZ8Bn1ehQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4913d631-ef75-40d4-9b4e-8950ac862ce3", "AQAAAAEAACcQAAAAENJwNTbXW8PFl+hrdqd5oIFqgRSQUjQLMlwFhgkMMDVQFTZbKZ4npjEVML1ZicYtqA==" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Геодезическо заснемане" },
                    { 2, "Трасировка" },
                    { 3, "Вертикално планиране" },
                    { 4, "Комбинирана скица" },
                    { 5, "Изменение на план за регулация" },
                    { 6, "Заснеамне за площ" },
                    { 7, "Заснемане по чл.19 от ЗУЗСО" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a404651e-242e-4c16-80e6-484914568654", "AQAAAAEAACcQAAAAEHxYwhCPDCq3uaqa4P6syOTmX06piN3pdrvyI2KanGsa6XvMaKOt/vr/IbYNbPEM4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55f2796f-e09f-4814-a6fe-97e541be6cc8", "AQAAAAEAACcQAAAAEDFJv0ivGYlMf3bYMvgFcvRcrn0EXeKAOV+vQQ+EUJXOhaM1C4epOdnnruWRBSl1cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da3f64e5-2053-4d3f-a124-d37589aaffa4", "AQAAAAEAACcQAAAAEAl0B4URtIiNIQwA9A+JJH/uWgp8l/DKCgZnIOq8cFdzOjie6kpssxWDVyHQMyKlKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b224dbcd-fe1b-4cd7-a390-3612db0920cc", "AQAAAAEAACcQAAAAEIz2hF21cxOerOaUsd8IJ1aP9XVSIJUbWDsL7Oxq/Ol2m6gF1R+gHBiLTAItfS0wUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6ecf59a-92b2-4ecb-8deb-7cadcf682a5b", "AQAAAAEAACcQAAAAECLPXXm+Ljvagp05a7dmhCRgv6dBUJ0uGoyEZgrFDXJZeAJ0vW4Vr2qe+Ryk0MQuwQ==" });
        }
    }
}
