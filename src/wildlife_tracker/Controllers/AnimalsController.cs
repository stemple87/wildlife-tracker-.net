using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using wildlife_tracker.Models;
using Microsoft.Data.Entity;

namespace wildlife_tracker.Controllers
{
    public class AnimalsController : Controller
    {

        private WildlifeTrackerContext db = new WildlifeTrackerContext();
        public IActionResult Index()
        {
            return View(db.Animals.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisAnimal = db.Animals.FirstOrDefault(x => x.AnimalId == id);
            return View(thisAnimal);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal item)
        {
            db.Animals.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisAnimal = db.Animals.FirstOrDefault(x => x.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost]
        public IActionResult Edit(Animal item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisAnimal = db.Animals.FirstOrDefault(x => x.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisAnimal = db.Animals.FirstOrDefault(x => x.AnimalId == id);
            db.Animals.Remove(thisAnimal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
