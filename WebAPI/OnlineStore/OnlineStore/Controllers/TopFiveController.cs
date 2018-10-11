using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{

    public class TopFiveController : Controller
    {
        public IActionResult TopFive()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
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



