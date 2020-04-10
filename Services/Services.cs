using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Services
{
    public class Services : IServices
    {
        private readonly Dictionary<string, Inventory> dict;

        public Services()
        {
            dict = new Dictionary<string, Inventory>();
           
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
    }
}
