using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Logging; 
using System.Diagnostics; 
using SchoolMind.Models;

namespace SchoolMind.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly ILogger<ProfessorController> _logger;

        public ProfessorController(ILogger<ProfessorController> logger) {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}