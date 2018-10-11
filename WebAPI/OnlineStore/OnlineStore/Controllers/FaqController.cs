using Common.Services;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{

    public class FaqController : Controller
    {
        public IActionResult TopFive()
        {
            return View();
        }
        public IActionResult Index()
        {
            var vm = new FaqModel();
            var stringService = new StringService();
            string original = "Det var en gamal gubbe";

            vm.CuttingExample = stringService.CutString(original, 5);

            return View(vm);
        }


        public IActionResult Pow()
        {
            return Ok("PoWWWW!");
        }
        public IActionResult Age()
        {
            return Ok(17);
        }

    }
}
