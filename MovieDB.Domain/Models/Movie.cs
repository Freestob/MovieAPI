using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.Domain.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
