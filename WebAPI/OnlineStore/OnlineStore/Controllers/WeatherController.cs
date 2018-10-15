using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using OnlineStore.Models.Smhi;
using OnlineStore.Services;

namespace OnlineStore.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            var vm = new WeatherViewModel
            {
                Latitude = 59.1M,
                Longitude = 17.9M
            };

            return View(vm);
        }
        public IActionResult GetWeather(WeatherViewModel vm)
        {
 

     

            try
            {
                var smhiService = new SmhiService();

                Rootobject result = smhiService.GetMeteorologicalForecast(vm.Longitude, vm.Latitude);
                vm.TimeTemps = smhiService.FilterTemperature(result, DateTime.Now);
            }
            catch (Exception ex)
            {
                vm.ErrorMessage = ex.Message;
            }
            return View("Index", vm);

            //string result = smhiService.GetMeteorologicalForecast(vm.Longitude, vm.Latitude);
            //vm.TimeTemps = new List<TimeTemp>();

            //vm.TimeTemps.Add(new TimeTemp { Temp = 18, Time = DateTime.Now });
            //vm.TimeTemps.Add(new TimeTemp { Temp = 16, Time = DateTime.Now });

            //return Ok ("Yes!" + vm.Longitude);
        }
    }
}