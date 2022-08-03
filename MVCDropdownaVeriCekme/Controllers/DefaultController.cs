using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDropdownaVeriCekme.Models.Entity;

namespace MVCDropdownaVeriCekme.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Entities db = new Entities();
        public ActionResult Index()
        {
            List<SelectListItem> sehirler = (from i in db.tbl_sehirler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.Sehir,
                                                 Value = i.ID.ToString()
                                             }).ToList();
            ViewBag.shr = sehirler;
            return View();
        }
    }
}