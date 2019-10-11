using System.Collections.Generic;
using System;

namespace PastryTracker.Models
{
    public class Order
    {
        public int ID { get; }

        public static List<Order> OrderList = new List<Order> { };
        public static int idAssigner { get; set;}

        public Order(string name, string size)
        {
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