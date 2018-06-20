using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations
{
    public partial class whyalltext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.DropTable(
                name: "ParticipantQOTD");

            migrationBuilder.DropTable(
                name: "QOTD");

            migrationBuilder.DropTable(
                name: "QOTDAnswer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
