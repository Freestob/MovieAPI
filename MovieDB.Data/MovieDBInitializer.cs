using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MovieDB.Domain.Models;

namespace MovieDB.Data
{
    class MovieDBInitializer :DropCreateDatabaseIfModelChanges<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
           context.Movies.Add(new Movie()
            {
                MovieTitle = "The Land Before Time",
                Genre = "Children",
                Description = "A longneck is on his pursuit for a leafstar"
            });
            context.Movies.Add(new Movie()
            {
                MovieTitle = "Saw",
                Genre = "Educational",
                Description = "A man shows you how to use a saw"
            });
            context.SaveChanges();
                
        }
    }
}
