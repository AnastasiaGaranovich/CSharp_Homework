using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static public class CitiesStorage
    {
        static private Dictionary<string, string> _cities;
        static public Dictionary<string, string> CitiesCode => _cities;
        static CitiesStorage()
        {
            _cities = new Dictionary<string, string>();
            _cities["Minsk"] = "26850";
            _cities["Alma-Ata"] = "36870";
            _cities["Astana"] = "35188";
            _cities["Ashhabad"] = "38880";
            _cities["Baky"] = "37850";
            _cities["Moscow"] = "27612";
            _cities["Vilnus"] = "26730";
            _cities["Dushanbe"] = "38836";
            _cities["Erevan"] = "37789";
            _cities["Kyiv"] = "33345";
            _cities["Riga"] = "26422";
        }
    }
}
