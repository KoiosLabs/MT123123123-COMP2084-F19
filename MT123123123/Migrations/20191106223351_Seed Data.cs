using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT123123123.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Msg", "Name", "PostedAt" },
                values: new object[] { 1, "Hi all y'alls", "Billy Bob", new DateTime(2019, 11, 6, 17, 33, 51, 319, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Msg", "Name", "PostedAt" },
                values: new object[] { 2, "Hi", "Sally Joe", new DateTime(2019, 11, 6, 17, 33, 51, 322, DateTimeKind.Local).AddTicks(9736) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
