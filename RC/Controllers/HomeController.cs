using RC.Infra;
using RC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RC.Controllers
{
    public class HomeController : RCController
    {
        //
        // GET: /Home/

        private RCContext db = new RCContext();

        public ActionResult Index()
        {
            var lista = db.Incidentes.AsQueryable();
            return View(lista);
        }

    }
}
