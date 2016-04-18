﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using wildlife_tracker.Models;


namespace wildlife_tracker.Controllers
{
    public class AnimalsController : Controller
    {

        private WildlifeTrackerContext db = new WildlifeTrackerContext();
        public IActionResult Index()
        {
            return View(db.Animals.ToList());
        }
    }
}
