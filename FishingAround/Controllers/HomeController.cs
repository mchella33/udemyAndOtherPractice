using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using FishingAround.Entities;
using FishingAround.Models;

namespace FishingAround.Controllers
{
    public class HomeController : Controller
    {
        private AnthonyEntities db = new AnthonyEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CondolencesFromObituary()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GuestsViewModel()
        {
            return View();
        }

        public ActionResult MainPage()
        {
            var viewModel = new MainPageViewModel();

            using (var db = new AnthonyEntities())
            {
                List<Guest> guests = db.Guests.ToList();
                foreach (var guest in guests)
                {
                    var viewModelGuest = new Guest()
                    {
                        Name = guest.Name,
                        Message = guest.Message
                    };
                    viewModel.Guests.Add(viewModelGuest);
                }
            }
            return View(viewModel);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult GuestsPage()
        //{
        //    var viewModel = new GuestsPageViewModel();
        //    using (var db = new AnthonyEntities())
        //    {
        //        List<Guest> guests = db.Guests.ToList();

        //        foreach (var guest in guests)
        //        {
        //            var viewModelGuest = new ViewGuests()
        //            {
        //                Name = guest.Name,
        //                Message = guest.Message,

        //            };
        //            viewModel.GuestsPage.Add(viewModelGuest);
        //        }
        //    }
        //    return View(viewModelGuestsPage);

        //}
      
    }
}