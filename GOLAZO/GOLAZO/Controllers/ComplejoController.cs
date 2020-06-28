using GOLAZO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOLAZO.Controllers
{
    public class ComplejoController : Controller
    {
        // GET: Complejo
        public ActionResult Index()
        {
            GolazoContext db = new GolazoContext();

            List<COMPLEJO> complejos = db.COMPLEJO.ToList();

            return View(complejos);
        }
    }
}