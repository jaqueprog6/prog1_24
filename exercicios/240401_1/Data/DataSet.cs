using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_1.Models;

namespace _240401_1.Data
{
    public class DataSet
    {
        public static List<Address> Addresses { get; set; } 
            = new List<Address>();
        public static List<Customer> Customers { get; set; } 
            = new List<Customer>();// customers é um tipo
        public static List<Product> Products { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<OrderItem> OrderItems { get; set; }
    
    }

}