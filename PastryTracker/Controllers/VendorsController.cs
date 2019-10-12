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
            Vendor.CreateVendor(name, description);
            List<Vendor> vendorList = Vendor.VendorList;
            return View(vendorList);
        }
        
        [HttpGet("/vendors/{vID}")]
        public ActionResult Show(int vID)
        {
            Vendor vendor = Vendor.SearchID(vID);
            return View(vendor);
        }

        [HttpGet("/vendors/{vID}/refresh")]
        public ActionResult Refresh(Vendor vendor)
        {
            int vID = vendor.ID;
        
            return RedirectToAction("Show");
        }   

    }
}