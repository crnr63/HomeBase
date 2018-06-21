using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations
{
    public partial class ripmigd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
  
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
migrationBuilder.CreateTable(
                name: "QOTDAnswer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Answer = table.Column<string>(type: "TEXT", nullable: true),
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false),

                    Question = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    QuestionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Author= table.Column<string>(type: "TEXT", nullable: true),
                    AuthorName=table.Column<string>(type: "TEXT", nullable: true),
                                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QOTDAnswer", x => x.ID);
                });
        }
    }
}
