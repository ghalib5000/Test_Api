using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Services
{
    public interface IServices
    {
        Inventory AddItems(Inventory items);
        Dictionary<String, Inventory> GetItems();
    }
}
