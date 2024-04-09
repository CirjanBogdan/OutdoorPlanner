using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutdoorPlanner.Migrations
{
    /// <inheritdoc />
    public partial class LikesNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikesNumber",
                table: "CommentViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LikesNumber",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikesNumber",
                table: "CommentViewModel");

            migrationBuilder.DropColumn(
                name: "LikesNumber",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 11, 44, 13, 118, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 1, 4, 44, 13, 118, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 1, 22, 44, 13, 118, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 2, 10, 44, 13, 118, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 30, 14, 44, 13, 118, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 4, 1, 13, 44, 13, 118, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 29, 19, 44, 13, 118, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 29, 10, 44, 13, 118, DateTimeKind.Local).AddTicks(2922));
        }
    }
}
