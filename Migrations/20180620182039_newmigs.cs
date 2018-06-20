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

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
  migrationBuilder.DropTable(
                name: "ParticipantQOTD");

            migrationBuilder.DropTable(
                name: "QOTD");

            migrationBuilder.DropTable(
                name: "QOTDAnswer");
        }
    }
}
