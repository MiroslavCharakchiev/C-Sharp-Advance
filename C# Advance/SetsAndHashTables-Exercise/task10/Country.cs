using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    public class Country
    {
        public string CountyName { get; set; }

        public Dictionary<string, long> CityPopulation = new Dictionary<string, long>();
    }
}
