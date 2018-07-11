using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeBase.Migrations.FantasyZone
{
    public partial class weektable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       migrationBuilder.CreateTable(
                name: "FantasyWeekGames",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ATL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    BKN_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    BOS_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    CHA_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    CHI_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    CLE_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    DAL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    DEN_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    Det_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    GSW_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    HOU_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    IND_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    LAC_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    LAL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MEM_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MIA_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MIL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MIN_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    NOP_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    NYK_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    OKC_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    ORL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    PHI_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    PHO_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    POR_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    SAC_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    SAS_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    TOR_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    UTA_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    WAS_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    WeekNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FantasyWeekGames", x => x.ID);
                });     
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
      migrationBuilder.CreateTable(
                name: "FantasyWeekGames",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ATL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    BKN_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    BOS_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    CHA_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    CHI_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    CLE_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    DAL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    DEN_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    Det_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    GSW_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    HOU_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    IND_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    LAC_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    LAL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MEM_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MIA_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MIL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    MIN_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    NOP_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    NYK_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    OKC_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    ORL_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    PHI_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    PHO_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    POR_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    SAC_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    SAS_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    TOR_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    UTA_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    WAS_Games = table.Column<int>(type: "INTEGER", nullable: false),
                    WeekNumber = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FantasyWeekGames", x => x.ID);
                });
        }
    }
}
