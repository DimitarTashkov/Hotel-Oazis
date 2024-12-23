using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelOazis.Migrations
{
    /// <inheritdoc />
    public partial class addServicesToRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Services");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Services",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Services_RoomId",
                table: "Services",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Rooms_RoomId",
                table: "Services",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Rooms_RoomId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_RoomId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Services");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Services",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Rooms",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
