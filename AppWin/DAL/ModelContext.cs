namespace App.DAL
{
 
    using SQLite.CodeFirst;
    using System;
    using System.Data.Entity;
    using System.Data.SQLite;
    using System.Linq;
    using TP_Tracking.Entities;

    public class ModelContext : DbContext
    {
        // Read ConnectionString from AppConfig
        //public ModelContext(): base("name=ModelContext")
        //{
        //}

        // SQLite DataBase
        public ModelContext() : base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "GAppEE_Demo.db", ForeignKeys = true }.ConnectionString
            },true)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ModelContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }

        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }


}