using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace TutorialMVC70486.Controllers
{
    [RoutePrefix("Bind")]
    [Route("{action}")]
    public class BindController : Controller
    {
        // GET: Bind
       
       [Route("Camaron",Name = "Camaron")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Make()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakePost()
        {
            return View("Index");
        }

        public ActionResult PostAjax(comicBook book)
        {
            var nombre = book.Titulo;
            var monto = book.Costo;
            return Json(new { status = 0, mensaje = "mensaje enviado desde el servidor de datos" });

        }
    }

    public class comicBook
    {
        public string Titulo { get; set; }
        public decimal Costo { get; set; }
    }

}