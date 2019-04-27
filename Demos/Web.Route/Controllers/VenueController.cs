using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class VenueController : SellerController
    {
        public IActionResult Index()
        {
            ViewData["sid"] = Name;
            return View();
        }
    }
}