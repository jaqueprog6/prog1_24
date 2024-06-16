using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_1.Models;
using _240401_1.Data;

namespace _240401_1.Repository
{
    public class AddressRepository
    {
        public void Create(Address address) {
            DataSet.Addresses.Add(address);
        }

        public Address Read(int id)
        {
            // foreach "para cada" para cada item de uma lista ele executa o código
            foreach (var a in DataSet.Addresses)
            {
                if (a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }


        public List<Address> Read(){
            return DataSet.Addresses;
        }

        private int GetNextId(){
            int n = 0;
            foreach(var a in DataSet.Addresses){
                if (a.Id > n) {
                    n = a.Id;
                }
            }

            return n++;
        }
    }

}