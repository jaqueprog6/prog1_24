using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class DataSet
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Collection> Collections { get; set; }
        public static List<Rental> Rentals { get; set; }
    }
}