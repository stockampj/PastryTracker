using Microsoft.AspNetCore.Mvc;
using PastryTracker.Models;
using System.Collections.Generic;

namespace PastryTracker.Controllers
{
    public class VendorsController : Controller
    {

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendorList = Vendor.VendorList;
            return View(vendorList);
        }
        
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Index(string name, string description)
        {
            Vendor vendor = new Vendor (name, description);
            List<Vendor> vendorList = Vendor.VendorList;
            return View(vendorList);
        }

    }
}