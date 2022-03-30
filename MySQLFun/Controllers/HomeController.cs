using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySQLFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {

        private IBowlerRepository _repo { get; set; }

        //Constructor
        public HomeController(IBowlerRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            //List<Teams> teams = _repo.Teams.ToList();

            var blah = _repo.Bowlers
                //.OrderBy(x => x.)
                .ToList();

            return View(blah);

        }

        [HttpPost]
        public IActionResult Create(Bowler blah)
        {
            _repo.AddBowler(blah);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int bowlerid)
        {
            var application = _repo.Bowlers.Single(x => x.BowlerID == bowlerid);
            return View("AddEdit", application);
        }

        [HttpPost]
        public IActionResult Edit(Bowler blah)
        {
            _repo.SaveChanges(blah);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int bowlerid)
        {
            var application = _repo.Bowlers.Single(x => x.BowlerID == bowlerid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(Bowler stuff)
        {
            _repo.DeleteBowler(stuff);
            return RedirectToAction("Index");
        }

    }
}
