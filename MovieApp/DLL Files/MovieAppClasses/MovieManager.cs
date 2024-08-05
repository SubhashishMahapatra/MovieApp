using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppClasses.ExceptionHandling;

namespace MovieAppClasses.Models
{
    public class MovieManager

    {


        public static List<Movie> movies = new List<Movie>();



        //Movie movie1 = new Movie();

        public MovieManager()
        {
            movies = SerializationDeserialization.Deserialization();
        }


        public static void MainMenu(int input)
        {
            switch (input)
            {
                case 1:
                    MovieManager.AddMovie(MovieManager.movies);
                    break;
                case 2:
                    MovieManager movieManager = new MovieManager();
                    movieManager.DisplayMovie(MovieManager.movies);
                    break;
                case 3:
                    MovieManager.DeleteMovie(MovieManager.movies);
                    break;
                case 4:
                    ClearAll(movies);
                    break;
                case 5:
                    break;

            }

        }

        public static void ClearAll(List<Movie> movie)
        {
            movies.Clear();
            SerializationDeserialization.Serialization(movie);
            Console.WriteLine("Cleared All Movie!");
        }
        

        public static void AddMovie(List<Movie> movie)
        {


            try
            {
                if (movie.Count < 5)
                {

                    Console.WriteLine();

                    Console.Write("Enter Movie Name: ");
                    string movName = Console.ReadLine();

                    Console.Write("Enter Movie Genre: ");
                    string movGenre = Console.ReadLine();

                    Console.Write("Enter Year of release: ");
                    int movYOR = int.Parse(Console.ReadLine());

                    string movID = GenerateMovieId(movName, movGenre, movYOR);

                    Movie newMovie = new Movie(movID, movName, movGenre, movYOR);


                    movie.Add(newMovie);

                    SerializationDeserialization.Serialization(movie);

                    Console.WriteLine("Your Movie has been Added Successfully!");
                }
                else
                {
                    throw new MovieStorage("Movie Capacity is Full!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static string GenerateMovieId(string movieName, string movieGenre, double movieYOR)
        {
            string name = movieName.Length >= 2 ? movieName.Substring(0, 2) : movieName;

            string genre = movieGenre.Length >= 2 ? movieGenre.Substring(0, 2) : movieGenre;

            string yearPart = movieYOR.ToString().Substring(movieYOR.ToString().Length - 2);

            return $"{name}{genre}{yearPart}";

        }

        public void DisplayMovie(List<Movie> movie)
        {


            try
            {
                if (movie.Count > 0)
                {

                    foreach (Movie movieList in movie)
                    {

                        Console.WriteLine("+-------------------------+-------------------------+");
                        Console.WriteLine($"| {"Movie Id",-20} | {movieList.MovieId,20} |");
                        Console.WriteLine("+-------------------------+-------------------------+");
                        Console.WriteLine($"| {"Movie Name",-20} | {movieList.MovieName,20} |");
                        Console.WriteLine("+-------------------------+-------------------------+");
                        Console.WriteLine($"| {"Movie Genre",-20} | {movieList.MovieGenre,20} |");
                        Console.WriteLine("+-------------------------+-------------------------+");
                        Console.WriteLine($"| {"Year of Release",-20} | {movieList.YearofRelease,20} |");
                        Console.WriteLine("+-------------------------+-------------------------+");
                        Console.WriteLine();

                    }
                }
                else
                {
                    throw new DisplayCount("No Movie Available to Display");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void DeleteMovie(List<Movie> movies)
        {


            try
            {

                if (movies.Count > 0)
                {



                    Console.WriteLine("Enter Movie ID: ");
                    string movId = Console.ReadLine();

                    bool flag = true;

                    foreach (Movie movie in movies)
                    {

                        if (movie.MovieId == movId)
                        {
                            movies.Remove(movie);
                            Console.WriteLine("Movie Removed Successfully");
                            SerializationDeserialization.Serialization(movies);
                            flag = false;
                            break;

                        }

                    }
                    if (flag)
                    {
                        Console.WriteLine("Movie Not Found");
                    }
                }
                else
                {
                    throw new DeleteCount("Movie Not Available to Delete");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}




