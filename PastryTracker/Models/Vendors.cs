using System.Collections.Generic;
using System;

namespace PastryTracker.Models
{
    public class Vendor
    {
        public int ID { get; }
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Order> VendorOrders {get; set;}

        public static List<Order> VendorList = new List<Vendor> { };
        public static int idAssigner { get; set;}

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            idAssigner++;
            ID = idAssigner;
            VendorList.Add(this);
        }

        public static Vendor SearchID(int id)
        {
            for(int i=0;i< VendorList.Count;i++)
            {
                if (VendorList[i].ID == id)
                {
                    return VendorList[i];
                }
            }
            return null;
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

    }
}