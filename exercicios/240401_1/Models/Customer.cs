using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_1.Models
{
    public class Customer
    {
        public int CustomerId {get; set;} = 0;
        public string Name {get; set;} = "Não definido";
        public string EmailAddress {get; set;} = "Não definido";
        public List<Address> Addresses {get; set;} = new List<Address>();

        public string PrintToExportDelimited(){
            return $"{CustomerId};{Name};{EmailAddress}";
        }

        public override string ToString() {
            return $"{CustomerId} - {Name} - {EmailAddress}";
        }
    }   
}