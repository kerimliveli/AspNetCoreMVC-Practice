using ActionResultts.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ActionResultts.Models
{
    public class EmployyeAddViewModel
    {

        public Employee Employee { get; set; }


        public List<SelectListItem> Cities { get; set;}
    }
}
