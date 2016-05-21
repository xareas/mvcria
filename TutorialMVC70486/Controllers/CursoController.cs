using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TutorialMVC70486.Models;

namespace TutorialMVC70486.Controllers
{
    
    public class CursoController : Controller
    {
        private EscuelaDB db = new EscuelaDB();

       [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
       [AllowAnonymous]
        public ActionResult Index(string buscar)
        {
            List<Curso> cursos;
            if (buscar?.Length > 0)
            {
                cursos = db.Cursos.Where(x => x.Title.Contains(buscar)).ToList();
            }
            else
            {
                cursos = db.Cursos.ToList();
            }

          return View(cursos);
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cursoID,Title,credits")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                db.Cursos.Add(curso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curso);
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }

            ViewBag.Demos = new SelectList(db.Cursos.ToList(), "CursoID","Title");

            return View(curso);
        }

        // POST: Curso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cursoID,Title,credits")] Curso curso)
        {
            //ModelState.AddModelError("","Otro mensaje de error");
            //ModelState.AddModelError("","Segundo mensaje de error");
            //ModelState.AddModelError("credits","Los creditos deben ser menor que 10");
           
            var val01= ModelState.IsValidField("credits");
            var val02 = ModelState["credits"].Errors.Count();
            if (ModelState.IsValid)
            {
                db.Entry(curso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curso);
        }

        
        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Curso curso = db.Cursos.Find(id);
            db.Cursos.Remove(curso);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public JsonResult ValidaCredito(int credits)
        {
            //verdadero en caso que credito sea igual a cinco.
            bool result = credits != 5;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
