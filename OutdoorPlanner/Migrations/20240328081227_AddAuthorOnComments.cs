using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutdoorPlanner.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorOnComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CommentsAndPostViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostViewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentsAndPostViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentsAndPostViewModel_PostViewModel_PostViewModelId",
                        column: x => x.PostViewModelId,
                        principalTable: "PostViewModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CommentViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CommentsAndPostViewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentViewModel_CommentsAndPostViewModel_CommentsAndPostViewModelId",
                        column: x => x.CommentsAndPostViewModelId,
                        principalTable: "CommentsAndPostViewModel",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CommentsAndPostViewModel_PostViewModelId",
                table: "CommentsAndPostViewModel",
                column: "PostViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentViewModel_CommentsAndPostViewModelId",
                table: "CommentViewModel",
                column: "CommentsAndPostViewModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentViewModel");

            migrationBuilder.DropTable(
                name: "CommentsAndPostViewModel");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 8, 44, 35, 217, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 31, 1, 44, 35, 217, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 31, 19, 44, 35, 217, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 1, 7, 44, 35, 217, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 29, 11, 44, 35, 217, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 31, 10, 44, 35, 217, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 28, 16, 44, 35, 217, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 28, 7, 44, 35, 217, DateTimeKind.Local).AddTicks(1607));
        }
    }
}
