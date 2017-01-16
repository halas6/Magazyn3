using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Magazyn3.Models;

namespace Magazyn3.App_Data.Controllers
{
    [Authorize(Roles = "Uzytkownik")]
    public class UzytkownikTowaryController : Controller
    {
        private Entities db = new Entities();

        // GET: UzytkownikTowary
        public ActionResult Index()
        {
            return View(db.Towary.ToList());
        }

        // GET: UzytkownikTowary/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Towary towary = db.Towary.Find(id);
            if (towary == null)
            {
                return HttpNotFound();
            }
            return View(towary);
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
