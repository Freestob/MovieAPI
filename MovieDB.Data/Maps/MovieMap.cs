using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using MovieDB.Domain.Models;


namespace MovieDB.Data.Maps
{
    class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MovieTitle);
            Property(x => x.Genre);
            Property(x => x.Description);
        }
    }
}
