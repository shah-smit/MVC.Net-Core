using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDevelopment.Controllers
{
    public class MainController : Controller
    {
        Movie movie = new Movie();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 15)
        {
            
            movie.Title = "smit";
            return View(movie);
        }

        [HttpPost]
        public IActionResult Calculate(Movie movie)
        {
            UpdatePartnerSetting(movie.Title);
            return View("Welcome",movie);
        }

        [HttpPost]
        public IActionResult UpdateModel(Movie movie)
        {
            UpdatePartnerSetting(movie.Price.ToString());
            return View("Welcome", movie);
        }



        public void UpdatePartnerSetting(string partnerId)
        {
            Console.WriteLine(partnerId);
        }
    }
}
