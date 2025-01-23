
using ActionResultts.Context;
using ActionResultts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ActionResultsTutorial.Controllers
{
    public class StudentController : Controller
    {
       private readonly IStudentService studentService;

        private StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public async Task<IActionResult> Index (string key = "")
        {
            return View(await _studentService);
        }
    }
}