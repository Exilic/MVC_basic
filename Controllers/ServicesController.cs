using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBasicsAssignment.Controllers
{
    public class ServicesController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(string degree, string scale )
        {
            if (degree == null) { ViewBag.Message = ""; }
            else
            {
                ViewBag.Message = CheckTemperature.Evaluate(degree, scale);
            }
            return View();
        }

        [HttpGet]
        public IActionResult GuessingGame()
        {
            int number = new Random().Next(101);

            HttpContext.Session.SetInt32("randomNumber", number);
            HttpContext.Session.SetInt32("trials", 0);
            ViewBag.random = HttpContext.Session.GetInt32("randomNumber");
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(string guess)
        {
            HttpContext.Session.SetInt32("trials", (int)(HttpContext.Session.GetInt32("trials")+1));
            int tryNumb = (int)HttpContext.Session.GetInt32("trials");
            int random = (int)HttpContext.Session.GetInt32("randomNumber");
            ViewBag.Message = RandomNumber.Evaluate(guess, random, tryNumb);
            if (Int32.Parse(guess) == random)
            {
                int number = new Random().Next(101);
                HttpContext.Session.SetInt32("randomNumber", number);
                HttpContext.Session.SetInt32("trials", 0);
            }
            return View();
        }
    }
}
