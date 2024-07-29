using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClasses.Models
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int YearofRelease { get; set; }


        public Movie() { }

        public Movie(string movieId, string movieName, string movieGenre, int yearofRelease)
        {
            MovieId = movieId;
            MovieName = movieName;
            MovieGenre = movieGenre;
            YearofRelease = yearofRelease;
        }




    }
}
