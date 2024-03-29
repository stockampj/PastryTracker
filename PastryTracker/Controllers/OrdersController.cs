using Microsoft.AspNetCore.Mvc;
using PastryTracker.Models;
using System;
using System.Collections.Generic;

namespace PastryTracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{id}/orders/new")]
        public ActionResult New(int id)
        {
            Vendor vendor = Vendor.SearchID(id);
            return View(vendor);
        }

          
        [HttpGet("/vendors/{vID}/order/{oID}")]
        public ActionResult Show(int oID)
        {
            Order order = Order.SearchID(oID);
            return View(order);
        }
        [HttpGet("/vendors/{vID}/orders/{oID}/edit")]
        public ActionResult Edit(int oID)
        {
            Order order = Order.SearchID(oID);
            return View(order);
        }

        [HttpPost("/vendors/{vID}/orders/{oID}")]
        public ActionResult Show(int oID, int year, int month, int day, string description, float cost, bool fulfilled, bool paymentreceived)
        {
            DateTime date = new DateTime(year, month, day, 0, 0, 0);
            Order order = Order.SearchID(oID);
            order.Date = date;
            order.Description = description;
            order.Cost = cost;
            order.PaymentReceived = paymentreceived;
            order.Fulfilled = fulfilled;
            return View(order);
        }
    }
}