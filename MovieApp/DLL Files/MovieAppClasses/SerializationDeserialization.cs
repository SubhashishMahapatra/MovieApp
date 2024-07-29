using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieAppClasses.Models
{
    public class SerializationDeserialization
    {
        public static void Serialization(List<Movie> movies)
        {
            File.WriteAllText("AccountData.json", JsonConvert.SerializeObject(movies));
        }

        public static List<Movie> Deserialization()
        {
            string fileName = "AccountData.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            else
            {
                return new List<Movie>();
            }
        }
    }
}
