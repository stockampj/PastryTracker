using Microsoft.AspNetCore.Mvc;
using PastryTracker.Models;
using System.Collections.Generic;
using System;

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

        [HttpPost("/vendors/{vID}")]
        public ActionResult Create(int vID, string name, int year, int month, int day, string description, float cost)
        {
            Vendor vendor = Vendor.SearchID(vID);
            DateTime date = new DateTime(year, month, day, 0, 0, 0);
            if (description != null)
            {
            Order order = new Order(name, vID, date, description, cost);
            vendor.VendorOrders.Add(order);
            }
            Vendor.setActive(vendor.ID);
            
            return View("Show", vendor);
        }
  
    }
}