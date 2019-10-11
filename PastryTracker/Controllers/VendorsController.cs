using Microsoft.AspNetCore.Mvc;
using PastryTracker.Models;
using System.Collections.Generic;

namespace PastryTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Index()
        {
            return View();
        }   
    }
}