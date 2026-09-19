using Bootcamp_MVC_EF.Data;
using Bootcamp_MVC_EF.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Bootcamp_MVC_EF.Controllers
{
    [Authorize]
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
            if (ModelState.IsValid)
            {
                _db.Departments.Add(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            return View(department);
          
        }


        //===============
        //Edit
        //==========================
        [HttpGet]
        public ActionResult Edit(string uuid)
        {
            var dept = _db.Departments.FirstOrDefault(e =>e.Uuid== uuid);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        [HttpPost]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                var olddept = _db.Departments.FirstOrDefault(e => e.Uuid == department.Uuid);

                if (olddept == null)
                    return NotFound();

                olddept.Name = department.Name;
                olddept.Description=department.Description;


                //_db.Departments.Update(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            return View(department);

        }


        //===============
        //Delete
        //==========================
        [HttpGet]
        public ActionResult Delete(string uuid)
        {
            var dept = _db.Departments.FirstOrDefault(e => e.Uuid == uuid);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(string uuid)
        {
            var dept = _db.Departments.FirstOrDefault(e => e.Uuid == uuid);
            if (dept == null)
            {
                return NotFound();
            }

            _db.Departments.Remove(dept);
                _db.SaveChanges();
                return RedirectToAction("Index");
         

        }



    }
}
