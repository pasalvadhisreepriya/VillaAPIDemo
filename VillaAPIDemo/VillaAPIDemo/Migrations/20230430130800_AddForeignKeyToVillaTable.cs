using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaAPIDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 59, 953, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 59, 953, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 59, 953, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 59, 953, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 59, 953, DateTimeKind.Local).AddTicks(3369));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 24, 55, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 24, 55, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 24, 55, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 24, 55, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 37, 24, 55, DateTimeKind.Local).AddTicks(9546));
        }
    }
}
