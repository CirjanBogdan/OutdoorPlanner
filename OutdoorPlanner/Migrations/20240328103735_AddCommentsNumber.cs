using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutdoorPlanner.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentsNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentsNumber",
                table: "PostViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentsNumber",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 13, 37, 34, 618, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 31, 6, 37, 34, 618, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 1, 0, 37, 34, 618, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 1, 12, 37, 34, 618, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 29, 16, 37, 34, 618, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 31, 15, 37, 34, 618, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 28, 21, 37, 34, 618, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 28, 12, 37, 34, 618, DateTimeKind.Local).AddTicks(3660));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentsNumber",
                table: "PostViewModel");

            migrationBuilder.DropColumn(
                name: "CommentsNumber",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 13, 26, 26, 543, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 31, 6, 26, 26, 543, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 1, 0, 26, 26, 543, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 1, 12, 26, 26, 543, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 29, 16, 26, 26, 543, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 31, 15, 26, 26, 543, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 28, 21, 26, 26, 543, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 28, 12, 26, 26, 543, DateTimeKind.Local).AddTicks(6053));
        }
    }
}
