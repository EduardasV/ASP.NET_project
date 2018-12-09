using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.Age;

            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey", Age = 38 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 29 });
            people.Add(new PersonModel { FirstName = "Alice", LastName = "Bob", Age = 21 });

            return View(people);
        }
    }
}