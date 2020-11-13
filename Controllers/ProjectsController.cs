using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBasicsAssignment.Controllers
{
    public class ProjectsController : Controller
    {

        GitHubProjects _gitProjects = new GitHubProjects();

        // GET: /<controller>/

        public IActionResult Index()
        {
            List<Project> gitList = _gitProjects.All();
            return View(gitList);
        }
    }
}
