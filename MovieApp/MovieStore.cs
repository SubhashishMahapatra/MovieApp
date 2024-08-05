using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppClasses;
using MovieAppClasses.Models;

namespace MovieApp
{
    public class MovieStore
    {
        public static void StartApp()
        {

            MovieManager movieManager = new MovieManager();

            char runProgram = 'y';

            Console.WriteLine("---------------------Welcome to Movie Studio---------------------");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");

            while (runProgram == 'y' || runProgram == 'Y')
            {

                Console.WriteLine("Total Movies Available: " + MovieManager.movies.Count);

                Console.WriteLine();
                Console.WriteLine("Choose Any One Option Below");
                Console.WriteLine();
                Console.Write("1. Add Movie  2. Display Movie  3. Delete Movie 4. Clear All 5. Exit: ");
                int choice = int.Parse(Console.ReadLine());

                MovieManager.MainMenu(choice);

                Console.WriteLine("Do you want to continue Y/N? ");
                runProgram = char.Parse(Console.ReadLine());

            }
        }
    }
}

