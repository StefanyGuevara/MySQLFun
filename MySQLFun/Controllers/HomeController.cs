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
    }
}
