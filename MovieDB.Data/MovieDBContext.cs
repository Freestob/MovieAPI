using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDB.Domain.Models;
using MovieDB.Data.Maps;
using System.Data.Entity;

namespace MovieDB.Data
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("MovieDB")
        {
            //Drop the database and recreate on each run
            //Database.SetInitializer(new DropCreateDatabaseAlways<GrandCircusLmsContext>());
            // Create the DB if it doesn't exist.  
            Database.SetInitializer(new CreateDatabaseIfNotExists<MovieDBContext>());
            //Will Drop and recreate if model changes.
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TaskListRevisitedContext>());
            //Custom Initializer
            //Database.SetInitializer(new MovieDBContext());
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMap());
            base.OnModelCreating(modelBuilder);

        }
    }
}
