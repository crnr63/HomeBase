using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations
{
    public partial class newtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.CreateTable(
                name: "ParticipantQOTD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Creator = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    FamilyName = table.Column<string>(type: "TEXT", nullable: true),
                    GivenName = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantQOTD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QOTD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    QuestionAuthor = table.Column<string>(type: "TEXT", nullable: true),
                    QuestionDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    Theme = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QOTD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QOTDAnswer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Answer = table.Column<string>(type: "TEXT", nullable: true),
                    Question = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    QuestionDate = table.Column<DateTime>(type: "DateTime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QOTDAnswer", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
