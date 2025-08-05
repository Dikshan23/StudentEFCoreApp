using Microsoft.AspNetCore.Mvc;
using StudentEFCoreApp12.Data;
using StudentEFCoreApp12.Models;

namespace StudentEFCoreApp12.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Student/
        public IActionResult Index()
        {
            return View(_context.Students.ToList());
        }

        // GET: /Student/Create
        public IActionResult Create() => View();

        // POST: /Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: /Student/Edit/5
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: /Student/Edit
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: /Student/Delete/5
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
                return NotFound();

            return View(student); // This shows Delete.cshtml for confirmation
        }

        // POST: /Student/DeleteConfirmed
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
                return NotFound();

            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: /Student/Details/5
        public IActionResult Details(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
