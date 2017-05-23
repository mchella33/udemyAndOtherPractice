using FishingAround.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingAround.Models
{
    public class MainPageViewModel
    {
        public List<Guest> Guests { get; set; }

        public MainPageViewModel()
        {
            Guests = new List<Guest>();
        }
    }
}