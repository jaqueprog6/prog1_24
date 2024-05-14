using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_1.Models;
using _240401_1.Data;

namespace _240401_1.Repository
{
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            DataSet.Customers.Add(customer);
        }

        public Customer Retrieve(int id)
        {
            // foreach "para cada" para cada item de uma lista ele executa o código
            foreach (var c in DataSet.Customers)
            {
                if (c.CustomerId == id)
                {
                    return c;
                }
            }
            return null;
        }


        public List<Customer> Retrieve(){
            return DataSet.Customers;
        }

        public List<Customer> RetrieveByname(string name) {
            List<Customer> retorno = new List<Customer>();
            foreach (var c in DataSet.Customers) {
                if (c.Name.Contains (name)) {
                    retorno.Add(c);
                }
            }

            return retorno;
        }
        private int GetNextId(){
            int n = 0;
            foreach(var c in DataSet.Customers){
                if (c.CustomerId > n) {
                    n = c.CustomerId;
                }
            }

            return n++;
    }

}

}
