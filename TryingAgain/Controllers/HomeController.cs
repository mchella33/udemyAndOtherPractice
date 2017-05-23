using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using TryingAgain.Entities;
using TryingAgain.Models;

namespace TryingAgain.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Obituary()
        {
            return View();
        }
        //[HttpGet]
        //[ValidateAntiForgeryToken]
        public ActionResult CreateVisitor(Visitors input)
        {
            if (ModelState.IsValid)

                using (var db = new AnthonyEntities())
            {
               var newVisitors = new Visitor();
                if (input == null)
                {
                        newVisitors.VisitorId = System.Guid.NewGuid();
                        newVisitors.Message = input.Message;
                    newVisitors.Name = input.Name;

                    //newVisitors.DatePosted = DateTime.Now;

                    db.Visitors.Add(newVisitors);
                    db.SaveChanges();
                    
                    }
                
            }
            return RedirectToAction("CreateVisitor", "Home");

        }

        //[HttpPost]
        ////[ValidateAntiForgeryToken]
        public ActionResult Visitors()
        {
            using (var db = new AnthonyEntities())
            {
                var visitors = db.Visitors.ToList();
                return View(visitors);
            }
           
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult UploadPicture(Pictures input)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AnthonyEntities())
                {
                    var pictures = db.Pictures.FirstOrDefault(x => x.PictureId == input.PictureId);
                    var newPictures = new Picture();
                    if (pictures == null)

                        //newPictures.PictureId = Guid.NewGuid();
                        

                    //if (input != null)
                    //{
                        newPictures.PictureId = new System.Guid();
                        newPictures.PictureUrl = input.PictureUrl;
                        newPictures.Caption = input.Caption;
                        newPictures.DateOfPicture = input.DateOfPicture;
                        newPictures.VisitorName = input.VisitorName;
                        newPictures.DatePicturePosted = DateTime.Now;

                    //}
                    if (pictures == null)

                        return RedirectToAction("UploadPicture", "Home");
                    
                    db.Pictures.Add(newPictures);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult PicturesList()
        {
            List<Picture> pictures;
            using (var db = new AnthonyEntities())
            {
                pictures = db.Pictures.ToList();
            }
            return View(pictures);
        }

        public ActionResult AddStory(Story input)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AnthonyEntities())
                {
                    var storys = db.Storys.FirstOrDefault(x => x.StoryId == input.StoryId);
                    var newStorys = new Story();
                    if (storys != null)
                    {
                        newStorys.StoryId = Guid.NewGuid();
                        newStorys.DatePosted = DateTime.Now;
                        if (input != null)
                        {
                            newStorys.StoryId = new Guid();
                            newStorys.Story1 = input.Story1;
                            newStorys.StoryTeller = input.StoryTeller;
                            newStorys.DateOfStory = input.DateOfStory;
                        }
                        db.Storys.Add(newStorys);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                }
                
            }
            return View(input);
        }

        public ActionResult StorysList()
        {
            List<Story> storys;
            using (var db = new AnthonyEntities())
            {
                storys = db.Storys.ToList();
            }
            return View();
        }


    }
}

