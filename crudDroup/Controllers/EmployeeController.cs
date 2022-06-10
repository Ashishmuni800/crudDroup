using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudDroup.Models;
using crudDroup.Models.ViewModel;

namespace crudDroup.Controllers
{
    public class EmployeeController : Controller
    {
        private DbConnection db;
        public EmployeeController(DbConnection db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            //var data=(from e in db.employees join c in db.countries on e.Id equals c.Id
            //          join s in db.states on c.Id=s.)   
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateAll all)
        {
            var c = db.countries.SingleOrDefault(e => e.Id == all.country);
            var s = db.states.SingleOrDefault(e => e.Id == all.state);
            var ci = db.cities.SingleOrDefault(e => e.Id == all.city);
            var obj = new Employee()
            {
                FirstName = all.FirstName,
                LastName = all.LastName,
                Gender = all.Gender,
                Language =all.Language,
                country = c,
                state = s,
                city = ci
            };
            db.employees.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetCountries()
        {
            var countydata = db.countries.ToList();
            return Json(countydata);
        }

        public IActionResult GetStates(int id)
        {
            var statedata = db.states.Where(e=>e.country.Id==id);
            return Json(statedata);
        }

        public IActionResult GetCities(int id)
        {
            var citydata = db.cities.Where(e=>e.state.Id==id);
            return Json(citydata);
        }
    }
}
