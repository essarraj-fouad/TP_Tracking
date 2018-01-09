using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace App.Migrations
{
    public partial class ModuleManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SpecialtyId",
                table: "Modules",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Precisions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    ModuleId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Precisions_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrecisionContents",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Goal = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    PrecisionId = table.Column<long>(nullable: true),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrecisionContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrecisionContents_Precisions_PrecisionId",
                        column: x => x.PrecisionId,
                        principalTable: "Precisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modules_SpecialtyId",
                table: "Modules",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_PrecisionContents_PrecisionId",
                table: "PrecisionContents",
                column: "PrecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Precisions_ModuleId",
                table: "Precisions",
                column: "ModuleId");
 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Specialtys_SpecialtyId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "PrecisionContents");

            migrationBuilder.DropTable(
                name: "Precisions");

            migrationBuilder.DropIndex(
                name: "IX_Modules_SpecialtyId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "SpecialtyId",
                table: "Modules");
        }
    }
}
