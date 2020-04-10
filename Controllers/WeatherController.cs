using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_Api.Models;
using TestApi.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test_Api.Controllers
{
    [ApiController]
    [Route("v2/")]
    public class WeatherController : Controller
    {

        private readonly IServices _service;
        public WeatherController(IServices service)
        {

            _service = service;
        }

        [HttpPost]
        [Route("AddWeather")]
        public ActionResult<Weather> AddWeather(int id)
        {
            var weather = _service.AddWeather(id);
            if (weather == null)
            {
                return NotFound();
            }
            return weather;
        }

        [HttpGet]
        [Route("GetWeather")]
        public ActionResult<Dictionary<string, Weather>> GetWeather()
        {
            var weathers = _service.GetWeather();
            if (weathers.Count == 0)
            {
                return NotFound();
            }
            return weathers;
        }
    }
}
