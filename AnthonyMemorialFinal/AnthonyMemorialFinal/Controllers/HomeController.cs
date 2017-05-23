using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnthonyMemorialFinal.Entities;
using AnthonyMemorialFinal.Models;


namespace AnthonyMemorialFinal.Controllers
{
    public class HomeController : Controller
    {
        private AnthonyEntities db = new AnthonyEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Stories()
        {
            return View();
        }
        public ActionResult Tributes()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GuestEntries(input)
        {
            return View();
        }
        
    }
}