using System.Collections.Generic;
using System;

namespace PastryTracker.Models
{
    public class Order
    {
        public int ID { get; }
        public string VendorName {get; set;}
        public DateTime Date {get; set;}
        public string Description {get; set;}
        public float Cost {get; set;}
        public bool Fullfilled {get; set;}
        public bool PaymentReceived {get; set;}

        public static List<Order> OrderList = new List<Order> { };
        public static int idAssigner { get; set;}

        public Order(string name, DateTime date, string description, float cost)
        {
            VendorName = name;
            Date = date;
            Description = description;
            Cost = cost;
            Fullfilled = false;
            PaymentReceived = false;
            idAssigner++;
            ID = idAssigner;
            OrderList.Add(this);

        }

        // public void CheckOffItem(int id)
        // {
        //     for (int i=0; i<PackList.Count; i++ )
        //     {
        //         if (PackList[i].ID == id)
        //         {
        //             PackList[i].Packed = true;
        //         }
        //     }
        // }
        public static Order SearchID(int id)
        {
            for(int i=0;i< OrderList.Count;i++)
            {
                if (OrderList[i].ID == id)
                {
                    return OrderList[i];
                }
            }
            return null;
        }
    }
}