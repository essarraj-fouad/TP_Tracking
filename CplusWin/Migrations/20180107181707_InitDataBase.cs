using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace App.Migrations
{
    public partial class InitDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    HourNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialtys",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialtys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkToDoCategorys",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkToDoCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    ProjectId = table.Column<long>(nullable: true),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    SpecialtyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Specialtys_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialtys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkToDos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ModuleId = table.Column<long>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    WorkToDoCategoryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkToDos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkToDos_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkToDos_WorkToDoCategorys_WorkToDoCategoryId",
                        column: x => x.WorkToDoCategoryId,
                        principalTable: "WorkToDoCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    GroupId = table.Column<long>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FormerId = table.Column<long>(nullable: true),
                    GroupId = table.Column<long>(nullable: true),
                    ModuleId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Formers_FormerId",
                        column: x => x.FormerId,
                        principalTable: "Formers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TraineeWorks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    FolderName = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    Validation = table.Column<int>(nullable: false),
                    WorkToDoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraineeWorks_WorkToDos_WorkToDoId",
                        column: x => x.WorkToDoId,
                        principalTable: "WorkToDos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TraineeWorkNotes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    TraineeWorkId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeWorkNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraineeWorkNotes_TraineeWorks_TraineeWorkId",
                        column: x => x.TraineeWorkId,
                        principalTable: "TraineeWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TraineeWorkValidateErrors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModification = table.Column<DateTime>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    Ordre = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    TraineeWorkId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeWorkValidateErrors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraineeWorkValidateErrors_TraineeWorks_TraineeWorkId",
                        column: x => x.TraineeWorkId,
                        principalTable: "TraineeWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SpecialtyId",
                table: "Groups",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_GroupId",
                table: "Trainees",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TraineeWorkNotes_TraineeWorkId",
                table: "TraineeWorkNotes",
                column: "TraineeWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_TraineeWorks_WorkToDoId",
                table: "TraineeWorks",
                column: "WorkToDoId");

            migrationBuilder.CreateIndex(
                name: "IX_TraineeWorkValidateErrors_TraineeWorkId",
                table: "TraineeWorkValidateErrors",
                column: "TraineeWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_FormerId",
                table: "Trainings",
                column: "FormerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_GroupId",
                table: "Trainings",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ModuleId",
                table: "Trainings",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkToDos_ModuleId",
                table: "WorkToDos",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkToDos_WorkToDoCategoryId",
                table: "WorkToDos",
                column: "WorkToDoCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "TraineeWorkNotes");

            migrationBuilder.DropTable(
                name: "TraineeWorkValidateErrors");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "TraineeWorks");

            migrationBuilder.DropTable(
                name: "Formers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "WorkToDos");

            migrationBuilder.DropTable(
                name: "Specialtys");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "WorkToDoCategorys");
        }
    }
}
