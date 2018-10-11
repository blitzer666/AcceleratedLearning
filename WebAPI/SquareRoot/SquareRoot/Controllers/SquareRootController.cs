using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet("api/squareroot")]
        public IActionResult SquareRoot(int? number)

            
        {
            if (number<0)
            {
                return BadRequest("Får inte ta roten ur negativa tal");
            }
            if (number ==null)
            {
                return BadRequest("Ange ett tal");
            }

            return Ok(Math.Sqrt((int)number));
        }

    }
}
