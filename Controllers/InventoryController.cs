using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApi.Controllers
{
    [ApiController]
    [Route("v1/")]
    public class InventoryController : ControllerBase
    {
        private readonly IServices _service;
        public InventoryController(IServices service)
        {
            
            _service = service;
        }

        [HttpPost]
        [Route("AddItems")]
        public ActionResult<Inventory> AddItems(Inventory items)
        {
            var inventory = _service.AddItems(items);
            if (inventory == null)
            {
                return NotFound();
            }
            return inventory;
        }

        [HttpGet]
        [Route("GetItems")]
        public ActionResult<Dictionary<string,Inventory>> GetItems()
        {
            var inventoryitems = _service.GetItems();
            if (inventoryitems.Count == 0)
            {
                return NotFound();
            }
            return inventoryitems;
        }






    }
}
