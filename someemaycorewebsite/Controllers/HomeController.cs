using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace ownwebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {


            _logger = logger;
        }

        // GET: Home
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult FeedBack()
        {


            return View("Index");

        }


        public IActionResult Netcore4()
        {
            return View();
        }
        public IActionResult Html()
        {
            return View();
        }
        public IActionResult CSS()
        {
            return View();
        }
        public IActionResult Mssql()
        {
            return View();
        }
        public IActionResult Netcore()
        {
            return View();
        }
        public IActionResult Netcore2()
        {
            return View();
        }
        public IActionResult Netcore3()
        {
            return View();
        }
        public IActionResult SweetAlert()
        {
            return View();
        }
        public IActionResult Netcoreprojects()
        {
            return View();
        }
        public IActionResult CreateEntity()
        {
            return View();
        }
        public IActionResult Adddatatodb()
        {
            return View();
        }

    }
}