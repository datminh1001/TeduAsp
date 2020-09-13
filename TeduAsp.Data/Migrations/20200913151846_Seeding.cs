using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeduAsp.Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 13, 23, 18, 46, 372, DateTimeKind.Local).AddTicks(9046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 13, 22, 39, 10, 153, DateTimeKind.Local).AddTicks(5446));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 13, 22, 39, 10, 153, DateTimeKind.Local).AddTicks(5446),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 13, 23, 18, 46, 372, DateTimeKind.Local).AddTicks(9046));
        }
    }
}
