using ActionResultts.Entities;
using ActionResultts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;

namespace ActionResultts.Controllers
{
    public class HomeController : Controller
    {
        

        public string Index()
        {
            return "fddsff";
        }


        public ViewResult Employee1()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Veli",
                    LastName = "Kerimli",
                    Cityid = 1,
                },


                new Employee()
                {
                    Id = 2,
                    FirstName = "Veli2",
                    LastName = "Kerimli2",
                    Cityid = 2,
                },


                new Employee()
                {
                    Id = 3,
                    FirstName = "Veli3",
                    LastName = "Kerimli3",
                    Cityid = 3,
                },
            };
            

            return View(employees);


        }



        public ViewResult Employee2()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Veli",
                    LastName = "Kerimli",
                    Cityid = 1,
                },


                new Employee()
                {
                    Id = 2,
                    FirstName = "Veli2",
                    LastName = "Kerimli2",
                    Cityid = 2,
                },


                new Employee()
                {
                    Id = 3,
                    FirstName = "Veli3",
                    LastName = "Kerimli3",
                    Cityid = 3,
                },
            };


            List<string> cities = new List <string>() {"bAKU" , "nAXCIVAN" , "gENCE"  };


            var vm = new EmployeeViewModel()
            {
                Cities = cities,
                Employees = employees

            };


            return View(vm);


        }

        public IActionResult Index4()
        {
            return Ok();
        }



        public IActionResult Index5()
        {
            return NotFound();
        }


        public IActionResult Index6()
        {
            return BadRequest();
        }


        public ActionResult Index7()
        {
            return Redirect("/home/index");
        }



        public IActionResult Index8()
        {
            return RedirectToAction("employee1");
        }


        public IActionResult Index9()
        {
            var routuValue = new RouteValueDictionary(
                new {action = "employee1" , controller = "home"  });


            return RedirectToRoute(routuValue);
        }




        public JsonResult GetJson()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Veli",
                    LastName = "Kerimli",
                    Cityid = 1,
                },


                new Employee()
                {
                    Id = 2,
                    FirstName = "Veli2",
                    LastName = "Kerimli2",
                    Cityid = 2,
                },


                new Employee()
                {
                    Id = 3,
                    FirstName = "Veli3",
                    LastName = "Kerimli3",
                    Cityid = 3,
                },
            };


            return Json(employees);
        }





    }
}
