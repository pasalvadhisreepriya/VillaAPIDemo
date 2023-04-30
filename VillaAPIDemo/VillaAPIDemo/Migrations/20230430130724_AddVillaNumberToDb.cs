using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaAPIDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 36, 17, 876, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 36, 17, 876, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 36, 17, 876, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 36, 17, 876, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 36, 17, 876, DateTimeKind.Local).AddTicks(5184));
        }
    }
}
