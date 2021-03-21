using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Your_New_Favorite_Poem.Migrations
{
    public partial class UseCurrentTimeStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 836, DateTimeKind.Unspecified).AddTicks(6400), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 836, DateTimeKind.Unspecified).AddTicks(5530), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 836, DateTimeKind.Unspecified).AddTicks(4650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 829, DateTimeKind.Unspecified).AddTicks(8190), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 836, DateTimeKind.Unspecified).AddTicks(6400), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 836, DateTimeKind.Unspecified).AddTicks(5530), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 836, DateTimeKind.Unspecified).AddTicks(4650), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 3, 21, 21, 14, 49, 829, DateTimeKind.Unspecified).AddTicks(8190), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP()");
        }
    }
}
