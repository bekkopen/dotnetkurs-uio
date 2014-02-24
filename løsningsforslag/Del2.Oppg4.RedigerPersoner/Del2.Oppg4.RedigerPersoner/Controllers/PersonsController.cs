using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Del2.Oppg4.RedigerPersoner.Models;

namespace Del2.Oppg4.RedigerPersoner.Controllers
{
    public class PersonsController : Controller
    {
        private static readonly List<Person> Persons = new List<Person>
            {
                new Person {Id = 1, Name = "Patrick Bateman", Age = 27, Gender = "M"},
                new Person {Id = 2, Name = "Mystique", Age = 127, Gender = "K"},
                new Person {Id = 3, Name = "Two Face", Age = 58, Gender = "M"},
                new Person {Id = 4, Name = "Cruella De Vil", Age = 65, Gender = "K"},
                new Person {Id = 5, Name = "Orochimaru", Age = 100, Gender = "M"},
                new Person {Id = 6, Name = "Harvey Dent", Age = 56, Gender = "M"},
                new Person {Id = 7, Name = "KongenDin", Age = 75, Gender = "M"}
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

        public ActionResult Update(int id)
        {
            var personToEdit = Persons.First(person => person.Id == id);

            return View(personToEdit);
        }

        [HttpPost]
        public ActionResult Update(Person updatedPerson)
        {
            Persons.RemoveAll(person => person.Id == updatedPerson.Id);
            Persons.Add(updatedPerson);

            return RedirectToAction("Index");
        }
    }
}
