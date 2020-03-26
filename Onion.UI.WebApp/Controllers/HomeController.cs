using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Onion.Domain.Services;
using Onion.UI.WebApp.Models;

namespace Onion.UI.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentDbService _service;

        public HomeController(ILogger<HomeController> logger,
                              IStudentDbService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetStudents());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
