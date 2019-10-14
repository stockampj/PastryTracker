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

        public static List<Vendor> VendorList = new List<Vendor> { };
        public static int idAssigner { get; set;}

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            VendorOrders = new List<Order> { };
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
        
        public static void CreateVendor(string name, string description)
        {
            if (name != null)
            {
                bool VendorExists = false;
                foreach(Vendor vendor in VendorList)
                    if (vendor.Name == name)
                    {
                        VendorExists = true;
                    }
                if (VendorExists == false)
                {
                     Vendor vendor = new Vendor (name, description);
                }
            }
        }
    }
}