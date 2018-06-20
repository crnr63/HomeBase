using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations
{
    public partial class newmigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.CreateTable(
                name: "ParticipantQOTD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Creator =  table.Column<string>(maxLength: 600, nullable:false),
                    DateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    FamilyName = table.Column<string>(maxLength: 600, nullable: true),
                    GivenName = table.Column<string>(maxLength: 600, nullable:false)
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
                         .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(maxLength: 600, nullable:false),
                    QuestionAuthor = table.Column<string>(maxLength: 600, nullable: true),
                    QuestionDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    Theme = table.Column<string>(maxLength: 600, nullable:false)
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
                         .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(maxLength: 600, nullable: true),
                    Question = table.Column<string>(maxLength: 600, nullable:false),
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
