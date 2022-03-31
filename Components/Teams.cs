using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission13.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mission13.Components
{
    public class Teams : ViewComponent
    {
        private IBowlersRepository _repo { get; set; }

        public Teams(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            

            var teams = _repo.Teams
                .Select(x => x.TeamName)
                .Distinct()
                .OrderBy(x => x);


            return View(teams);
        }
    }
}
