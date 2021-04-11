using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MySql.EntityFrameworkCore.Metadata;

namespace Your_New_Favorite_Poem.Migrations
{
    public partial class UseGuidForPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //need to change authorId to a guid as well. Ensure that
            //authorID matches the newly genereated Id2
            //can we pull a Guid that pulls the previously used guid for new guid 
            //instead of creating a whole new guid for authorId
            //https://www.codeproject.com/Articles/1193009/Changing-primary-key-data-type-in-EF-Core


            migrationBuilder.AddColumn<Guid>("Id2", "authors", "TEXT", nullable: false, defaultValueSql: "newid()");
            migrationBuilder.AddColumn<Guid>("Id2", "poems", "TEXT", nullable: false, defaultValueSql: "newid()");

            migrationBuilder.DropForeignKey("FK_poems_authors_AuthorId", "poems");

            migrationBuilder.DropPrimaryKey("PK_authors", "authors");
            migrationBuilder.DropPrimaryKey("PK_poems", "poems");

            migrationBuilder.DropColumn("Id", "authors");
            migrationBuilder.DropColumn("Id", "poems");

            migrationBuilder.RenameColumn("Id2", "authors", "Id");
            migrationBuilder.RenameColumn("Id2", "poems", "Id");

            migrationBuilder.AddPrimaryKey("PK_authors", "authors", "Id");
            migrationBuilder.AddPrimaryKey("PK_poems", "poems", "Id");

            migrationBuilder.AddForeignKey("FK_poems_authors_AuthorId", "poems", "AuthorId", "authors", principalColumn: "Id");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 113, DateTimeKind.Unspecified).AddTicks(55), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "poems",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "poems",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 112, DateTimeKind.Unspecified).AddTicks(9695), new TimeSpan(0, 0, 0, 0, 0)));

            //migrationBuilder.AlterColumn<byte[]>(
            //    name: "AuthorId",
            //    table: "poems",
            //    type: "varbinary(16)",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            //migrationBuilder.AlterColumn<byte[]>(
            //    name: "Id",
            //    table: "poems",
            //    type: "varbinary(16)",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 112, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "authors",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "authors",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 109, DateTimeKind.Unspecified).AddTicks(63), new TimeSpan(0, 0, 0, 0, 0)));

            //migrationBuilder.AlterColumn<byte[]>(
            //    name: "Id",
            //    table: "authors",
            //    type: "varbinary(16)",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 113, DateTimeKind.Unspecified).AddTicks(55), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<ulong>(
                name: "IsVerified",
                table: "poems",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<ulong>(
                name: "IsDeleted",
                table: "poems",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "poems",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 112, DateTimeKind.Unspecified).AddTicks(9695), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "poems",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "poems",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 112, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<ulong>(
                name: "IsVerified",
                table: "authors",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<ulong>(
                name: "IsDeleted",
                table: "authors",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "authors",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 12, 20, 18, 4, 11, 109, DateTimeKind.Unspecified).AddTicks(63), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(16)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);
        }

        public void Convert(MigrationBuilder migrationBuilder, string tableName, string pKConstraintName, params string[] children)
        {
            

            //foreach (var child in children)
            //{
            //    DropForeignKey($"dbo.{child}s", $"{tableName}_Id", $"dbo.{tableName}s");
            //    DropIndex($"dbo.{child}s", new[] { $"{tableName}_Id" });
            //    RenameColumn($"dbo.{child}s", $"{tableName}_Id", $"old_{tableName}_Id");
            //    if (toGuid)
            //    {
            //        AddColumn($"dbo.{child}s", $"{tableName}_Id", c => c.Guid());
            //    }
            //    else
            //    {
            //        AddColumn($"dbo.{child}s", $"{tableName}_Id", c => c.Int());
            //    }
            //    Sql($"update c set {tableName}_Id=p.Id2 from {child}s c inner join {tableName}s p on p.Id=c.old_{tableName}_Id");
            //    DropColumn($"dbo.{child}s", $"old_{tableName}_Id");
            //}
            
            //foreach (var child in children)
            //{
            //    CreateIndex($"dbo.{child}", $"{tableName}_Id");
            //    AddForeignKey($"dbo.{child}", $"{tableName}_Id", $"dbo.{tableName}", "Id");
            //}
        }
    }

}
