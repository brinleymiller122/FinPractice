using FinPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinPractice.Controllers
{
    public class HomeController : Controller
    {
        private IProjectsRepository repo { get; set; }

        public HomeController(IProjectsRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            ViewBag.ProjectList = repo.Projects.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project p)
        {
            if (ModelState.IsValid)
            {
                repo.SaveProject(p);
                return View("Confirmation", p);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int projectid)
        {
            ViewBag.ProjectList = repo.Projects.ToList();
            var projectInfo = repo.Projects.Single(x => x.ProjectId == projectid);
            return View("Create", projectInfo);
        }

        [HttpPost]
        public IActionResult Edit(Project p)
        {
            if (ModelState.IsValid)
            {
                repo.UpdateProject(p);
                return RedirectToAction("Index");

            }
            else
            {
                return View(p);
            }
        }

        [HttpGet]
        public IActionResult Delete(int projectid)
        {
            var projectinfo = repo.Projects.Single(x => x.ProjectId == projectid);
            return View(projectinfo);
        }

        [HttpPost]
        public IActionResult Delete(Project p)
        {
            //may need to reference projects before RemoveProject
            repo.RemoveProject(p);
            return RedirectToAction("Index");
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
