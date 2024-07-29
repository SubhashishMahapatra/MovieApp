using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClasses.ExceptionHandling
{
    public class MovieStorage : Exception
    {
        public MovieStorage(string message) : base(message)
        {

        }
    }
}
