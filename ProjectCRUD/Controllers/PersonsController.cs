using Microsoft.AspNetCore.Mvc;
using ProjectCRUD.Data;
using ProjectCRUD.Models;

namespace ProjectCRUD.Controllers
{
    public class PersonsController : Controller
    {
        public readonly ApplicatinDbContext _db;

        public PersonsController(ApplicatinDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Persons obj)
        {
           
                _db.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("ViewPerson");
            
           
        }


         public IActionResult ViewPerson()
        {
            IEnumerable<Persons> ob = _db.Persons;
            return View("View",ob);
        }




         public IActionResult Edit(int? id)
        {
            var persons = _db.Persons.Find(id);

            return View(persons);

        }

        [HttpPost]
        public IActionResult Edit(Persons obj)
        {
            _db.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("ViewPerson");

           
        }

        public IActionResult Delete(int? id)
        {
            var persons = _db.Persons.Find(id);

            return View(persons);

        }
        public IActionResult DeletePerson(int? id)
        {
            var persons = _db.Persons.Find(id);
             _db.Remove(persons);
            _db.SaveChanges();
             return RedirectToAction("ViewPerson");

        }






    }
}
