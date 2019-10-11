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
            if (name != null)
            {
                bool VendorExists = false;
                foreach(Vendor vendor in Vendor.VendorList)
                    if (vendor.Name == name)
                    {
                        VendorExists = true;
                    }
                if (VendorExists == false)
                {
                     Vendor vendor = new Vendor (name, description);
                }
            }
            List<Vendor> vendorList = Vendor.VendorList;
            return View(vendorList);
        }

    }
}