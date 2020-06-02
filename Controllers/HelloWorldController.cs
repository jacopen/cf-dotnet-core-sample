using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Configuration;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IConfiguration Configuration { get; }
        public HelloWorldController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            ViewData["Val"] = Configuration.GetSection("Logging:LogLevel:Default").Value;

            return View();
        }
    }
}