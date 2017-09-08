using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace DojoSurvey.Controllers
{
    public class surveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("index");
        }
        
        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string location, string language, string comments)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = comments;
            return View("result");
        }
    }
}