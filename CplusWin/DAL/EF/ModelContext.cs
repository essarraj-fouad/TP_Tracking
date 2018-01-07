namespace App.DAL
{
    using SQLite.CodeFirst;
    using System;
    using System.Data.Entity;
    using System.Data.SQLite;
    using System.Linq;
    using App.Entities;
    using System.Collections.Generic;

    public class ModelContext : DbContext
    {
        static Dictionary<String, ModelContext> UniqueContextByEntity = new Dictionary<string, ModelContext>();

        // SQLite DataBase
        public ModelContext() : base(
            new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "SuiviTP.db", ForeignKeys = true }.ConnectionString
            }, true)
        { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ModelContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }
        // Taks Manager

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Former> Formers { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<WorkToDo> WorkToDos { get; set; }
        public virtual DbSet<Specialty> Specialtys { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
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
        public static ModelContext getUniqueContextByEntity(Type EntityType)
        {
            return getUniqueContextByEntity(EntityType.Name);

        }
        /// <summary>
        /// Get the unique context by Entity Name
        /// </summary>
        /// <param name="EntityName">Entity Name</param>
        /// <returns>Modelc context instance</returns>
        public static ModelContext getUniqueContextByEntity(string EntityName)
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