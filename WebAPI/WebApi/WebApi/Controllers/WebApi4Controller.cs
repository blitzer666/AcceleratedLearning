using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("webapi4")]
    public class WebApi4Controller : Controller
    {
        [Route("splitchocolate")]
        public IActionResult SplitChocolate(double numberofpersons)
        {
            {
                double chocolatepieces = 25;
                double sum = chocolatepieces / numberofpersons;

                if (numberofpersons > 0)
                    return Ok("Each person gets " + sum + " pieces of chocolate");
                else
                    return BadRequest("Enter a higher number");
            }

        }
        [Route("validateorder")]

        public IActionResult ValidateOrderNumber(string validateordernumber)
        {
            Regex rx = new Regex(@"[A-Z a-z]{2}-[0-9]{4}$");
            if (rx.IsMatch(validateordernumber))
            {
                Regex rgx = new Regex(@"[A-Z a-z]{2}-[0-2]{1}[0-9]{3}$");
                if (rgx.IsMatch(validateordernumber))
                    return Ok($"{validateordernumber} finns i systemet");
                else
                    return NotFound($"{validateordernumber} finns INTE i systemet");

            }
            else
                return BadRequest("Fel format");

        }




    [Route("enterusername")]

        public IActionResult EnterUserName(string username)
        {

            if (username.ToUpper() == "STEWIE")
                return BadRequest("DATA ERROR");

            else if (username.ToUpper() == "PETER")
                return Content($"<img src =  https://i.ytimg.com/vi/zhBxfNm3rJE/maxresdefault.jpg>", "text/html");

            else if (username.ToUpper() == "LOIS" || username.ToUpper() == "MEG" || username.ToUpper() == "CHRIS" || username.ToUpper() == "BRIAN")
                return Ok("BILD PÅ TUMME UPP");

            else
                return Content($"<img src = https://media1.tenor.com/images/e98aa36a3bf561a1e3d9c4e83178d917/tenor.gif?itemid=10038754>", "text/html");

           
        }
    }

}
