using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations
{
    public partial class questionid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "QOTDAnswer",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "QOTDAnswer");

            migrationBuilder.AlterColumn<string>(
                name: "Theme",
                table: "QOTD",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
