using Microsoft.AspNetCore.Mvc;

namespace StudentTask.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Getall()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
