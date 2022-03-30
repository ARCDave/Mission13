using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission13.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        private BowlersDbContext _repo { get; set; }


        public HomeController(BowlersDbContext temp)
        {
            _repo = temp;
        }
        

        public IActionResult Index()
        {
            var bowlers = _repo.Bowlers.ToList();

            return View(bowlers);
        }

        
    }
}
