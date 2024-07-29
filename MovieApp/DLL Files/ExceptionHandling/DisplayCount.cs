using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClasses.ExceptionHandling
{
    internal class DisplayCount : Exception
    {
        public DisplayCount(string message):base(message) 
        {

        }
    }
}
