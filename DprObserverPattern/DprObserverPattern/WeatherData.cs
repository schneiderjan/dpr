using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public class WeatherData
    {
        public Degrees Degrees { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
    }

    public class Degrees
    {
        public float Temperature;
        public string Unit;
    }
}
