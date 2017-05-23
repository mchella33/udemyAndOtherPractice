using LifeMakingMyDecisions.Entities;
using LifeMakingMyDecisions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeMakingMyDecisions.Controllers
{
    public class HomeController : Controller

    {
        private AnthonyEntities db = new AnthonyEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AboutHim()
        {
            return View();
        }
        public ActionResult Stories()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        //public ActionResult Entries()
        //{
        //    return View();
        //}
        
        public ActionResult Entries(EntriesViewModel input)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AnthonyEntities())
                {
                    var entry = db.Entries.FirstOrDefault(x => x.Submitter == input.Submitter);
                    if (entry != null)
                    {
                        var newEntry = new Entry();

                        newEntry.EntryID = Guid.NewGuid();
                        newEntry.Submitter = input.Submitter;
                        newEntry.Caption = input.Caption;
                        newEntry.Blog = input.Blog;

                        db.Entries.Add(newEntry);
                        db.SaveChanges();

                    }
                    //return View(input);
                    return RedirectToAction("index", "Home");
                }

            }
            return View(input);
        }
    }
}
