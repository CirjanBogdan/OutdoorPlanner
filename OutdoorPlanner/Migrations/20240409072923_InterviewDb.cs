using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutdoorPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InterviewDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 10, 11, 29, 22, 948, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 12, 4, 29, 22, 948, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 12, 22, 29, 22, 948, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 13, 10, 29, 22, 948, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 10, 14, 29, 22, 948, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 12, 13, 29, 22, 948, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 4, 9, 19, 29, 22, 948, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 4, 9, 10, 29, 22, 948, DateTimeKind.Local).AddTicks(7555));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 11, 47, 3, 555, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 1, 4, 47, 3, 555, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 1, 22, 47, 3, 555, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 2, 10, 47, 3, 555, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 30, 14, 47, 3, 555, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 1, 13, 47, 3, 555, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 47, 3, 555, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 29, 10, 47, 3, 555, DateTimeKind.Local).AddTicks(9843));
        }
    }
}
