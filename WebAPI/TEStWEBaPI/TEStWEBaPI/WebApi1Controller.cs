using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEStWEBaPI.wwwroot;

namespace TEStWEBaPI
{
    [Route("WebApi1")]
    public class WebApi1Controller : Controller
    {
        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            Planet planet = ParsePlanet(formContent);

            return Ok($"Ny planet {planet.Name} skapad med storleken {planet.Size}");
        }

        private static Planet ParsePlanet(string formcontent)
        {
            var list = formcontent.Split('&');

            var planet = new Planet();

            foreach (var row in list)
            {
                // Planet=Pluto
                var key = row.Split("=")[0];
                var value = row.Split("=")[1];

                if (key == "Name")
                    planet.Name = value;

                if (key == "Size")
                    planet.Size = int.Parse(value);
            }

            return planet;
        }



    }
}
