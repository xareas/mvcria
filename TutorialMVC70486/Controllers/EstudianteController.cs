using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using TutorialMVC70486.Models;

namespace TutorialMVC70486.Controllers
{
    public class EstudianteController : Controller
    {
        private EscuelaDB db = new EscuelaDB();

        public void Pruebas()
        {
            var datos = db.Estudiantes.Include(x => x.enrollments);
        }

        // GET: Estudiante
        
        public ActionResult Index(string sortOrder,string filter,int? page)
        {

            ViewBag.lastNameSortParm = String.IsNullOrEmpty(sortOrder) ? "lastName_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            var students = db.Estudiantes.AsQueryable();
           // var students = db.Estudiantes.Select(x=>x);

           if (!filter.IsNullOrWhiteSpace())
            {
                students = students.Where(x => x.midName.Contains(filter));
               // ViewBag.filter = filter;
            }
           
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.lastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.enrollmentDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.enrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.lastName);
                    break;
            }

            int pageSize =  10;
            int rowCount = students.Count() / pageSize;
            int pageNumber = (page ?? 1);
            if (pageNumber > rowCount)
            {
                pageNumber = rowCount;
            }
            students = students.Skip(pageNumber*pageSize).Take(pageSize);
            ViewBag.rowCount = rowCount;
            ViewBag.page = pageNumber;
            return View(students.ToList());
        }

        // GET: Estudiante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Details",estudiante);
        }

        // GET: Estudiante/Create
        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }

        // POST: Estudiante/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "estudianteID,lastName,midName,enrollmentDate")] Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                db.Estudiantes.Add(estudiante);
                db.SaveChanges();
                return Json(estudiante);
            }

            return Json(new { status = 0, message = "El modelo no cumple con las reglas de negocio" });
        }

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Edit",estudiante);
        }

        // POST: Estudiante/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "estudianteID,lastName,midName,enrollmentDate")] Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudiante).State = EntityState.Modified;
                db.SaveChanges();
                return Json(estudiante);
            }
           
            return Json(new { status = 0, message ="El modelo no cumple con las reglas de negocio" });
        }

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Delete",estudiante);
        }

        // POST: Estudiante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public JsonResult DeleteConfirmed(int id)
        {
            var estudiante = db.Estudiantes.Find(id);
            if(estudiante==null)
                return Json(new { status = 0, message="No existe el registro" });
            try
            {
                db.Estudiantes.Remove(estudiante);
                db.SaveChanges();
                return Json(new { status=1, message="OK"  });
            }
            catch (Exception ex)
            {

                return Json(new { status = 0, message=ex.Message });
            }
           
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
