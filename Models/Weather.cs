using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Api.Models
{
    public class Weather
    {
        public int id { get; set; }
        public double tempC { get; set; }
        public double tempF { get; set; }

        public Weather(int id)
        {
            this.id = id;

            var rnd = new Random();

            tempC = rnd.Next(-22, 55);
            tempF = (((tempC / 5) * 9) + 32);
        }
    }
}
