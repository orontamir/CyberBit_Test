using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CyberBit.Migrations
{
    public partial class addnewuser3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "DueDate", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "working", 1 },
                    { 2, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "eating", 1 },
                    { 3, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "working", 1 },
                    { 4, new DateTime(2021, 8, 27, 11, 11, 0, 0, DateTimeKind.Unspecified), 2, "sleeping", 1 },
                    { 5, new DateTime(2021, 8, 26, 11, 9, 0, 0, DateTimeKind.Unspecified), 3, "testing", 2 },
                    { 6, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "leaving", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
