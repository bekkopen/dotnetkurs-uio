using System.Collections.Generic;
using System.Web.Mvc;
using Del2.Oppg2.ListPersoner.Models;

namespace Del2.Oppg2.ListPersoner.Controllers
{
    public class PersonsController : Controller
    {
        public ActionResult Index()
        {
            var persons = new List<Person>
            {
                new Person {Name = "Patrick Bateman", Age = 27, Gender = "M"},
                new Person {Name = "Mystique", Age = 127, Gender = "K"},
                new Person {Name = "Two Face", Age = 58, Gender = "M"},
                new Person {Name = "Cruella De Vil", Age = 65, Gender = "K"},
                new Person {Name = "Orochimaru", Age = 100, Gender = "M"},
                new Person {Name = "Harvey Dent", Age = 56, Gender = "M"},
                new Person {Name = "KongenDin", Age = 75, Gender = "M"}
            };

            return View(persons);
        }
    }
}
