﻿namespace App.DAL
{
    using System;

    using System.Linq;
    using App.Entities;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Data.Sqlite;

    public class ModelContext : DbContext
    {
        static Dictionary<String, ModelContext> UniqueContextByEntity = new Dictionary<string, ModelContext>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqliteConn = new SqliteConnection(@"DataSource = ../../traineeManager.db");
            optionsBuilder.UseSqlite(sqliteConn);
        }
        // Project Manager
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        // Trainning Manager
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Precision> Precisions { get; set; }
        public virtual DbSet<PrecisionContent> PrecisionContents { get; set; }
        

        public virtual DbSet<Former> Formers { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }

        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Specialty> Specialtys { get; set; }


        // TP Traking Manager
        public virtual DbSet<WorkToDo> WorkToDos { get; set; }
        public virtual DbSet<WorkToDoCategory> WorkToDoCategorys { get; set; }
        public virtual DbSet<TraineeWorkValidateError> TraineeWorkValidateErrors { get; set; }
        public virtual DbSet<TraineeWork> TraineeWorks { get; set; }
        public virtual DbSet<TraineeWorkNote> TraineeWorkNotes { get; set; }

        #region Get Unique Conrext
        /// <summary>
        /// Get the unique context by Entity Type
        /// </summary>
        /// <param name="EntityName">Entity Name</param>
        /// <returns>Modelc context instance</returns>
        public static ModelContext getContext(Type EntityType)
        {
            return getContext(EntityType.Name);

        }
        /// <summary>
        /// Get the unique context by Entity Name
        /// </summary>
        /// <param name="EntityName">Entity Name</param>
        /// <returns>Modelc context instance</returns>
        public static ModelContext getContext(string EntityName)
        {
            if (UniqueContextByEntity.ContainsKey(EntityName))
                return UniqueContextByEntity[EntityName];
            else
            {
                UniqueContextByEntity[EntityName] = new ModelContext();
                return UniqueContextByEntity[EntityName];
            }

        }
        #endregion
    }


}