using Microsoft.AspNetCore.Mvc;
using WorkSpaceApplication2.Entities;
using WorkSpaceApplication2.Repositories;

namespace WorkSpaceApplication2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentRepository repository = new StudentRepository(); 
            return View(repository.GetList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            StudentRepository repository = new StudentRepository();
            repository.Add(student.FirstName,student.LastName);
            return RedirectToAction("Index");
        }

    }
}
