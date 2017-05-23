using Anthony.Entities;
using Anthony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anthony.Controllers
{
    public class HomeController : Controller
    {
        private AnthonyEntities db = new AnthonyEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GuestBook()
        {
            return View();
        }
        public ActionResult GuestBook(GuestsViewModel input)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AnthonyEntities())
                {
                    var guest = db.Guests.FirstOrDefault(x => x.FirstName == input.FirstName);
                    if (guest == null && input.FirstName == input.FirstName)
                    {
                        var newGuest = new Guest();

                        newGuest.GuestId = Guid.NewGuid();
                        newGuest.FirstName = input.FirstName;
                        newGuest.LastName = input.LastName;
                        newGuest.Email = input.Email;

                        db.Guests.Add(newGuest);
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(input);
        }
        //public ActionResult MainPage()
        //{
        //    return View();
        //}
        public ActionResult Stories()
        {
            return View();

        }
        public ActionResult Stories(PostViewModel input)
        {
            var viewModel = new PostViewModel();

            using (var db = new AnthonyEntities())
            {
                List<Post> posts = db.Posts.ToList();
                foreach (var post in posts)
                {
                    var viewModelPost = new PostViewModel
                    {
                        PostId = post.PostId,
                        Url = post.Url,
                        Comment = post.Comment,

                    };
                    viewModel.Comment.Add(viewModelPost);
                    }
            }
            return View(viewModel);
        }
    }

}