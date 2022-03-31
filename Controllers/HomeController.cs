using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission13.Models;
using Mission13.Models.ViewModels;
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
        

        public async Task<IActionResult> Index(string team)
        {

            

            var bowlers = new BowlersViewModel

            { 
                
                
                Bowlers = _repo.Bowlers
                .Where(b => b.Teams.TeamName == team || team == null)
                .OrderBy(b => b.BowlerID)

                

            };
            return View(bowlers);
        }

        
    }
}
