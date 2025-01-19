using ActionResultts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ActionResultts.Controllers
{
    public class EmployeeController : Controller
    {

        [HttpGet]

        public IActionResult Add()
        {
            var vm = new EmployyeAddViewModel()
            {
                Employee = new Entities.Employee(),
                Cities = new List<SelectListItem>
                {
                      new SelectListItem {Text = "Baku", Value="1"},
                     new SelectListItem {Text = "Monaco", Value="2"},
                     new SelectListItem {Text = "Roma", Value="3"},
                  new SelectListItem {Text = "London", Value="4"},

                 }
            };
            return View(vm);
        }


        [HttpPost]
        public IActionResult Add(EmployyeAddViewModel viewmodel)
        {
            var vm = new EmployyeAddViewModel()
            {
                Employee = new Entities.Employee()
                
            };

            return View(vm);
        }
    }
}
