using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        // 

        public ActionResult Header()
        {
            return View();
        }

        public ActionResult Home()
        {
            ViewBag.name = "Ayesha Akhtar";
            ViewBag.id = "19-41292-3";
            ViewBag.email = "ayesha.akhtar.1999@gmail.com";
            ViewBag.contact = "01798406965";
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.institution = "Scholastica";
            ViewBag.OlevelYear = "2017";
            ViewBag.AlevelYear = "2019";
            ViewBag.board = "CIE";
            ViewBag.university = "AIUB";
            ViewBag.cgpa = "3.99";
            ViewBag.semester = "10th";
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.oop1 = "Game rental store management";
            ViewBag.oop2 = "Medicine POS Management System";
            ViewBag.web = "Pharmacy Management System";
            ViewBag.advWeb = "Pharmacy Management System";
            return View();
        }

        public ActionResult References()
        {
            ViewBag.ref1 = "Sameen Abrar";
            ViewBag.ref1email = "sameenabrar13@gmail.com";
            ViewBag.ref2 = "Mosraka Akhtar Ruhi";
            ViewBag.ref2email = "makhtar.ruhi@gmail.com";
            return View();
        }
    }
}