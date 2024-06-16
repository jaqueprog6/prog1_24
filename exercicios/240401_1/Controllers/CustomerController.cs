using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_1.Models;
using _240401_1.Repository;
using _240401_1.Utils;


namespace _240401_1.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;
        public CustomerController(){
            customerRepository = new CustomerRepository();
        }
        public void Insert(Customer customer){
            customerRepository.Save(customer);
        }
        
        public Customer Get(int id){
            return customerRepository.Retrieve(id);
        }

        public List<Customer> Get(){
            return customerRepository.Retrieve();
        }

        public List<Customer> GetByName(string name){
            return customerRepository.RetrieveByName(name);
     }

        public void ExportDelimited(){
            List<Customer> list = customerRepository.Retrieve();

            string fileContent = string.Empty;
            foreach(var c in list){
                fileContent += $"{c.PrintToExportDelimited()}\n";
            }

            string fileName = $"Customer_{DateTimeOffeset.Now.ToUnixTimeSeconds()}.txt";
            ExportToFile.SaveToDelimitedTxt(fileName,fileContent);
        }

        public bool ImportFromDelimited (string filePath, string delimiter) {
            bool results = true;
            string msgReturn = string.Empty;
            int lineCountSucess = 0;
            int lineCountError = 0;
            int lineTotalCount = 0;

            try {
                if(!File.Exists(filePath)){
                    return "ERRO: Arquivo de importação não encontrado.";
                    
                    using(StreamReader sr = new StreamReader(filePath)){
                        string line = string.Empty;
                        while((line = sr.ReadLine()) != null){
                            lineCountTotal ++;
                            if (!customerRepository.ImportFromTxt(line, delimiter)){
                                results = false;
                                lineCountError++;
                            }

                            else {
                                lineCountSucess ++;
                            }

                        }
                    }
                }
            }
            catch (System.Exception) {
                return $"ERRO: {ex.Message}";
            }

            if(results){
                msgReturn = "Dados importados com sucesso!";
            }
            else {
                msgReturn = "Dados parcialmente importados.";
            }
            msgReturn += $"\n Total de linhas: {lineCountTotal}";
            msgReturn += $"\n Sucesso: {lineCountSucess}";
            msgReturn += $"\n Erro: {lineCountError}";
            return msgReturn;
        }
    }
}