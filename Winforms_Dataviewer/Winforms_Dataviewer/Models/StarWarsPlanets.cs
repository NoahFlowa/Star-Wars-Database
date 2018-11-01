using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Dataviewer
{
    public class StarWarsPlanets
    {
        public string name { get; set; }
        public string rotation_period { get; set; }
        public string orbital_period { get; set; }
        public string diameter { get; set; }
        public string climate { get; set; }
        public string gravity { get; set; }
        public string terrain { get; set; }
        public string surface_water { get; set; }
        public string population { get; set; }
        //public List<object> residents { get; set; }
        //public List<string> films { get; set; }
        //public DateTime created { get; set; }
        //public DateTime edited { get; set; }
        public string url { get; set; }

        public string circumference()
        {
            double theCircum = 0;
            double theDiameter = 0;

            double.TryParse(diameter, out theDiameter);

            theCircum = 3.14159265358979 * theDiameter;

            return $"{theCircum.ToString()}";
        }

    }
}
