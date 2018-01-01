namespace TP_Tracking.DAL
{
    using SQLite.CodeFirst;
    using System;
    using System.Data.Entity;
    using System.Data.SQLite;
    using System.Linq;
    using TP_Tracking.Entities;

    public class ModelContext : DbContext
    {
     
        // SQLite DataBase
        public ModelContext() : base(
            new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "SuiviTP.db", ForeignKeys = true }.ConnectionString
            },true)
        {}


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ModelContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }

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
    }


}