using Microsoft.AspNetCore.Mvc;
using PastryTracker.Models;
using System;
using System.Collections.Generic;

namespace PastryTracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("vendors/{id}/orders/new/")]
        public ActionResult New(int id)
        {
            Vendor vendor = Vendor.SearchID(id);
            return View(vendor);
        }

        [HttpPost("/vendors/{id}/orders/")]
        public ActionResult Create(int id, string name, int year, int month, int day, string description, float cost)
        {
            DateTime date = new DateTime(year, month, day, 0, 0, 0);
            Order order = new Order(name, date, description, cost);
            Vendor vendor = Vendor.SearchID(id);
            vendor.VendorOrders.Add(order);
            
            return RedirectToAction("Index", "Vendors");
        }   
    }
}