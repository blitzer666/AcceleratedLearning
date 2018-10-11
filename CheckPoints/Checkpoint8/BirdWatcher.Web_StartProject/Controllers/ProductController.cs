using BirdWatcher.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher.Web.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new List<Products>
        {
            new Products {Name = "Skiftnyckel", Quantity = 5},
            new Products {Name = "Hammare", Quantity = 10},
            new Products {Name = "Såg", Quantity = 0},
            

        });
        }

    }
}
