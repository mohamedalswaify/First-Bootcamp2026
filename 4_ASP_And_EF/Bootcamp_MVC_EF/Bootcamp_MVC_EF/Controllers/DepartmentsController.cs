using Bootcamp_MVC_EF.Data;
using Bootcamp_MVC_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_MVC_EF.Controllers
{
    public class DepartmentsController : Controller
    {
        //DI 
        private readonly AppDbContext _db;
        public DepartmentsController(AppDbContext db)
        {
            _db = db;
        }


        public ActionResult Index()
        {
            //Entity Framework Approach
            IEnumerable<Department> depts = _db.Departments.ToList();
            return View(depts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            _db.Departments.Add(department); 
            _db.SaveChanges();
            return RedirectToAction("Index");


        }



    }
}
