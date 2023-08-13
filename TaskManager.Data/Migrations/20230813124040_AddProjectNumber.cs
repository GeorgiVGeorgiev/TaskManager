using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddProjectNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectNumber",
                table: "GeoTask",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectNumber",
                table: "GeoTask");

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
        }
    }
}
