using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RC.Models;
using RC.Infra;

namespace RC.Controllers
{
    public class IncidenteController : RCController
    {
        private RCContext db = new RCContext();

        
        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.Categorias, "Id", "Nome");
            return View();
        }

        //
        // POST: /Incidente/Create

        [HttpPost]
        public ActionResult Create(Incidente incidente)
        { 
            try
            {
                if (ModelState.IsValid)
                {
                    db.Incidentes.Add(incidente);
                    db.SaveChanges();
                    Alert = new RCAlert("Novo incidente adicionado.", AlertType.Success);
                    return RedirectToAction("Create");
                }
            }
            catch (Exception e) { }
            ViewBag.IdCategoria = new SelectList(db.Categorias, "Id", "Nome", incidente.IdCategoria);
            return View(incidente);
        }

        //
        // GET: /Incidente/Edit/5

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}