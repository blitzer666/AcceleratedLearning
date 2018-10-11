using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebApi.Controllers
{
    [Route("webapi6")]
    public class WebApi6Controller : Controller
    {
        [HttpPost("AddDocument")]
        public IActionResult AddDocument(Document document)
        {
            return Ok(document);
        }

    }
}