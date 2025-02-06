using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOfLife.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Humans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Health = table.Column<double>(type: "REAL", nullable: false),
                    Fitness = table.Column<double>(type: "REAL", nullable: false),
                    Hunger = table.Column<double>(type: "REAL", nullable: false),
                    Engineering = table.Column<double>(type: "REAL", nullable: false),
                    BrainCapacity = table.Column<double>(type: "REAL", nullable: false),
                    Fun = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Humans");
        }
    }
}
