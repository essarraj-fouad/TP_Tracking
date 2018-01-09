﻿// <auto-generated />
using App.DAL;
using App.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace App.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20180109213301_ModuleManager")]
    partial class ModuleManager
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("App.Entities.Former", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Ordre");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.ToTable("Formers");
                });

            modelBuilder.Entity("App.Entities.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.Property<long?>("SpecialtyId");

                    b.HasKey("Id");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("App.Entities.Module", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<int>("HourNumber");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.Property<long?>("SpecialtyId");

                    b.HasKey("Id");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("App.Entities.Precision", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<long?>("ModuleId");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Precisions");
                });

            modelBuilder.Entity("App.Entities.PrecisionContent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<string>("Goal");

                    b.Property<int>("Ordre");

                    b.Property<long?>("PrecisionId");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.HasIndex("PrecisionId");

                    b.ToTable("PrecisionContents");
                });

            modelBuilder.Entity("App.Entities.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("App.Entities.Specialty", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.ToTable("Specialtys");
                });

            modelBuilder.Entity("App.Entities.Task", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<long?>("ProjectId");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("App.Entities.Trainee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<long?>("GroupId");

                    b.Property<string>("LastName");

                    b.Property<int>("Ordre");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("App.Entities.TraineeWork", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("FolderName");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.Property<int>("Validation");

                    b.Property<long?>("WorkToDoId");

                    b.HasKey("Id");

                    b.HasIndex("WorkToDoId");

                    b.ToTable("TraineeWorks");
                });

            modelBuilder.Entity("App.Entities.TraineeWorkNote", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.Property<long?>("TraineeWorkId");

                    b.HasKey("Id");

                    b.HasIndex("TraineeWorkId");

                    b.ToTable("TraineeWorkNotes");
                });

            modelBuilder.Entity("App.Entities.TraineeWorkValidateError", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Message");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.Property<long?>("TraineeWorkId");

                    b.HasKey("Id");

                    b.HasIndex("TraineeWorkId");

                    b.ToTable("TraineeWorkValidateErrors");
                });

            modelBuilder.Entity("App.Entities.Training", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<long?>("FormerId");

                    b.Property<long?>("GroupId");

                    b.Property<long?>("ModuleId");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.HasIndex("FormerId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ModuleId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("App.Entities.WorkToDo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<long?>("ModuleId");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.Property<string>("Title");

                    b.Property<long?>("WorkToDoCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("WorkToDoCategoryId");

                    b.ToTable("WorkToDos");
                });

            modelBuilder.Entity("App.Entities.WorkToDoCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.ToTable("WorkToDoCategorys");
                });

            modelBuilder.Entity("App.Entities.Group", b =>
                {
                    b.HasOne("App.Entities.Specialty", "Specialty")
                        .WithMany()
                        .HasForeignKey("SpecialtyId");
                });

            modelBuilder.Entity("App.Entities.Module", b =>
                {
                    b.HasOne("App.Entities.Specialty", "Specialty")
                        .WithMany()
                        .HasForeignKey("SpecialtyId");
                });

            modelBuilder.Entity("App.Entities.Precision", b =>
                {
                    b.HasOne("App.Entities.Module", "Module")
                        .WithMany("Precisions")
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("App.Entities.PrecisionContent", b =>
                {
                    b.HasOne("App.Entities.Precision", "Precision")
                        .WithMany("PrecisionContents")
                        .HasForeignKey("PrecisionId");
                });

            modelBuilder.Entity("App.Entities.Task", b =>
                {
                    b.HasOne("App.Entities.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("App.Entities.Trainee", b =>
                {
                    b.HasOne("App.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("App.Entities.TraineeWork", b =>
                {
                    b.HasOne("App.Entities.WorkToDo", "WorkToDo")
                        .WithMany()
                        .HasForeignKey("WorkToDoId");
                });

            modelBuilder.Entity("App.Entities.TraineeWorkNote", b =>
                {
                    b.HasOne("App.Entities.TraineeWork")
                        .WithMany("TraineeWorkNotes")
                        .HasForeignKey("TraineeWorkId");
                });

            modelBuilder.Entity("App.Entities.TraineeWorkValidateError", b =>
                {
                    b.HasOne("App.Entities.TraineeWork")
                        .WithMany("TraineeWorkValidateErrors")
                        .HasForeignKey("TraineeWorkId");
                });

            modelBuilder.Entity("App.Entities.Training", b =>
                {
                    b.HasOne("App.Entities.Former", "Former")
                        .WithMany()
                        .HasForeignKey("FormerId");

                    b.HasOne("App.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("App.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("App.Entities.WorkToDo", b =>
                {
                    b.HasOne("App.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId");

                    b.HasOne("App.Entities.WorkToDoCategory", "WorkToDoCategory")
                        .WithMany()
                        .HasForeignKey("WorkToDoCategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
