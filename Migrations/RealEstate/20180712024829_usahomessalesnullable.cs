using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations.RealEstate
{
    public partial class usahomessalesnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.CreateTable(
                name: "USAHomeSales",
                columns: table => new
                {
                   ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
     

                    finalsalesprice=table.Column<decimal>(nullable:true),
                    listingprice=table.Column<string>(maxLength: 600, nullable:true),
                    notes=table.Column<string>(maxLength: 600, nullable:false),
                    parsedhomeID = table.Column<string>(maxLength: 600, nullable:false),
                    snapshotdate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    snapshottype = table.Column<string>(maxLength: 600, nullable:false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USAHouses", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
