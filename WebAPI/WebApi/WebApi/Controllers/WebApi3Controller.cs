using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebApi.Controllers
{
    [Route("webapi3")]
    public class WebApi3Controller : Controller
    {

        //public IActionResult AddPlanet()
        //{

        //    string formContent = "";
        //    using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
        //    {
        //        formContent = reader.ReadToEndAsync().Result;
        //    }


        //}
        [Route("frukostmat")]
        public IActionResult KollaFrulle(string frukost)
        {
            //string formContent = "";
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))

            {
                if (frukost == "Egg")

                    return Ok($"Du borde inte äta {frukost} till frukost");

                else
                    return Ok("Det är gott med " + frukost + " till frukost");
            }
        }

        [Route("PickBackgroundColor")]

        //public IActionResult PickBackgroundColor()
        //{
        //    form1.Attributes.Add("style", "background-color:#FF5050;");
        //}
//________________________________________________________________________________________________________________
        [Route("kvadrera")]

        public IActionResult Kvadrera(int kvadrera)
        {
            
            int sum = kvadrera * kvadrera;
            return Ok(sum);

        }
        //____________________________________________________________________________________________________
        [Route("numberlist")]

        public IActionResult ListWithNumbers(Numbers numbers)
        {
            int i = 0;
            var mylist = new List<int>();
            for ( i = numbers.StartNumber; i < numbers.EndNumber; i++)
                {                   
                     mylist.Add(i);                   
                }
            var v = string.Join(',', mylist);
            return Ok(v);

        }
        //___________________________________________________________________________________________________________
    }
}



