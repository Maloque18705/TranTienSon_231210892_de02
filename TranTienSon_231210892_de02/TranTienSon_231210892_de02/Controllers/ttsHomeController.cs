using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TranTienSon_231210892_de02.Models;

namespace TranTienSon_231210892_de02.Controllers
{
    public class ttsHomeController : Controller
    {
        private readonly ILogger<ttsHomeController> _logger;

        public ttsHomeController(ILogger<ttsHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult ttsIndex()
        {
            return View("~/Views/Home/ttsIndex.cshtml");
        }

        public IActionResult ttsPrivacy()
        {
            return View("~/Views/Home/ttsPrivacy.cshtml");
        }

        public IActionResult ttsAbout()
        {
            return View("~/Views/Home/ttsAbout.cshtml");
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ttsError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
