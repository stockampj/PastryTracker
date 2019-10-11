using Microsoft.AspNetCore.Mvc;
using PastryTracker.Models;
using System.Collections.Generic;

namespace PastryTracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/orders")]
        public ActionResult Index()
        {
            return View();
        }   
    }
}