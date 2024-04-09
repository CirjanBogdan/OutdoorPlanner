using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutdoorPlanner.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePostComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentCreateBindingModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentCreateBindingModel", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentCreateBindingModel");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 11, 12, 26, 904, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 31, 4, 12, 26, 904, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 31, 22, 12, 26, 904, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 1, 10, 12, 26, 904, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 29, 14, 12, 26, 904, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 31, 13, 12, 26, 904, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 28, 19, 12, 26, 904, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 28, 10, 12, 26, 904, DateTimeKind.Local).AddTicks(5411));
        }
    }
}
