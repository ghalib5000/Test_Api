using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Api.Models;
using TestApi.Models;

namespace TestApi.Services
{
    public class Services : IServices
    {
        private readonly Dictionary<string, Inventory> dict;

        private readonly Dictionary<string, Weather> _weather;

        public Services()
        {
            dict = new Dictionary<string, Inventory>();
            _weather = new Dictionary<string, Weather>();
        }

        public Inventory AddItems(Inventory items)
        {
            dict.Add(items.name, items);
            return items;
        }

        public Dictionary<String,Inventory> GetItems()
        {
            return dict;
        }

        public Weather AddWeather(int id)
        {
            Weather weat = new Weather(id);
            
            _weather.Add(Convert.ToString(id), weat);
            return weat;

        }


        public Dictionary<string, Weather> GetWeather()
        {
            return _weather;
        }
    }
}
