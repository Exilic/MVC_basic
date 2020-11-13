using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBasicsAssignment.Controllers
{
    public class AboutController : Controller
    {

        PersonLife _personLife = new PersonLife();

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<LifeEvent> aboutMe = _personLife.All();
            return View(aboutMe);
        }
    }
}
