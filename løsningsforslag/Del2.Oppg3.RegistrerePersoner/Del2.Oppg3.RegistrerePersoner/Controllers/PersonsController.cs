using System.Collections.Generic;
using System.Web.Mvc;
using Del2.Oppg3.RegistrerePersoner.Models;

namespace Del2.Oppg3.RegistrerePersoner.Controllers
{
    public class PersonsController : Controller
    {
        private static readonly List<Person> Persons = new List<Person>
            {
                new Person {Name = "Patrick Bateman", Age = 27, Gender = "M"},
                new Person {Name = "Mystique", Age = 127, Gender = "K"},
                new Person {Name = "Two Face", Age = 58, Gender = "M"},
                new Person {Name = "Cruella De Vil", Age = 65, Gender = "K"},
                new Person {Name = "Orochimaru", Age = 100, Gender = "M"},
                new Person {Name = "Harvey Dent", Age = 56, Gender = "M"},
                new Person {Name = "KongenDin", Age = 75, Gender = "M"}
            };

        public ActionResult Index()
        {
            return View(Persons);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Person newPerson)
        {
            if (ModelState.IsValid)
            {
                Persons.Add(newPerson);
                return RedirectToAction("Index");
            }

            return View(newPerson);
        }
    }
}
