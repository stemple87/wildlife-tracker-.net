using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using wildlife_tracker.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace wildlife_tracker.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: /<controller>/
        private WildlifeTrackerContext db = new WildlifeTrackerContext();
        public IActionResult Index()
        {
            return View(db.Animals.ToList());
        }
    }
}
