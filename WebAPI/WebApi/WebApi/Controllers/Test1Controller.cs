using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{

    [Route("Test1")]
    public class Test1Controller : Controller
    {
        [Route ("hej")]

        public string Hej()
        {
            return "Pingvin";

        }

        [Route("qwerty")]
        public string svejs()
        {
            return "Hej";
        }
    }
}
