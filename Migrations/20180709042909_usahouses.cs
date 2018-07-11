using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations
{
    public partial class usahouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


     
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
 migrationBuilder.CreateTable(
                name: "USAHouses",
                columns: table => new
                {
                    ID = table.Column<string>(type: "VARCHAR", nullable: false)
                         .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address  = table.Column<string>(maxLength: 600, nullable:false),
                    bathrooms = table.Column<decimal>(),
                    bedrooms = table.Column<decimal>(),
                    city = table.Column<string>(maxLength: 600, nullable:false),
                    cost = table.Column<decimal>(),
                    emailID = table.Column<string>(maxLength: 600, nullable:false),
                    insertionDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    squarefootage = table.Column<int>(type: "INTEGER", nullable: false),
                    state = table.Column<string>(maxLength: 600, nullable: true),
                    type = table.Column<string>(maxLength: 600, nullable: true),
                    zipcode = table.Column<string>(maxLength: 600, nullable: true),
                    QuestionAuthor = table.Column<string>(maxLength: 600, nullable: true),
                    QuestionDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    Theme = table.Column<string>(maxLength: 600, nullable:false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USAHouses", x => x.ID);
                });


                   migrationBuilder.CreateTable(
                name: "USAHouses",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    address = table.Column<string>(type: "TEXT", nullable: true),
                    bathrooms = table.Column<decimal>(type: "TEXT", nullable: false),
                    bedrooms = table.Column<decimal>(type: "TEXT", nullable: false),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    cost = table.Column<decimal>(type: "TEXT", nullable: false),
                    emailID = table.Column<string>(type: "TEXT", nullable: true),
                    insertionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    squarefootage = table.Column<int>(type: "INTEGER", nullable: false),
                    state = table.Column<string>(type: "TEXT", nullable: true),
                    type = table.Column<string>(type: "TEXT", nullable: true),
                    zipcode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USAHouses", x => x.ID);
                });
            migrationBuilder.DropTable(
                name: "USAHouses");
        }
    }
}
