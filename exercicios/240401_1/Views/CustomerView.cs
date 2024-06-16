using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_1.Models;
using _240401_1.Controllers;
using _240401_1.Views;

namespace _240401_1.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;
        
        public CustomerView(){
            addressView = new();
            this.Init();
        }

        public void Init() {
            Console.WriteLine("MENU CUSTOMER");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidores");
                Console.WriteLine("4 - Exportar dados delimitados");
                Console.WriteLine("5 - Importar dados delimitados");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try {
                    menu = Convert.ToInt32(Console.ReadLine());

                    switch (menu) {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                            InsertCustomer();
                        break;
                        case 2:
                            SearchCustomer();
                        break;
                        case 3:
                            ListCustomers();
                        break;
                        case 4:
                            if (customerController.ExportDelimited()){
                                Console.WriteLine("Arquivo gerado com sucesso!");
                            }

                            else {
                                Console.WriteLine("Falha ao gerar arquivo.");
                            }
                        break;
                        case 5:
                            ImportFromDelimited();
                        break;
                        default:
                            Console.WriteLine("Opção Inválida.");
                            aux = true;
                        break;

                    }
                }
                catch {
                    Console.WriteLine("Opção Inválida.");
                    menu = -1; // caso a pessoa digite algo inválido
                }

            }
            while (aux);
        }
        
        private void ImportFromDelimited(){
            Console.WriteLine("Informe o caminho do arquivo");
            string pathFile = Console.ReadLine();

            Console.WriteLine("Informe o caracter delimitador");
            string delimiter = Console.ReadLine();

            string response = customerController.ImportDelimited(pathFile, delimiter);

            Console.WriteLine(response);

        }
        private void InsertCustomer() {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");

                Customer customer = new Customer(); 
                Console.Write("Nome: ");
                customer.Name = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Email: ");
                customer.EmailAddress = Console.ReadLine();
                Console.WriteLine("");

                int aux = 0;
                do {
                    Console.WriteLine("Deseja informar endereço? ");
                    Console.WriteLine("0 - Não");
                    Console.WriteLine("1 - Sim");
                    try {
                        aux = Convert.ToInt32(Console.ReadLine());
                        if (aux == 1) {
                            customerView.Address.Add(addressView.Insert());
                        }
                        else if (aux == 0) {
                            break;
                        }
                        else {
                        aux = 1;
                        Console.WriteLine("Opção Inválida."); 
                        Console.WriteLine("Tente Novamente."); 
                        }
                        
                    }

                    catch {
                        aux = 1;
                        Console.WriteLine("Opção Inválida."); 
                        Console.WriteLine("Tente Novamente."); 
                    }

                }

                while (aux != 0);

                try{
                    customerController.Insert(customer);
                    Console.WriteLine("Customer inserido com sucesso!");
                }
                
                catch{
                    Console.WriteLine("Ops! Ocorreu um erro.");
                }
                
        }

        private void SearchCustomer() {

            int aux = -1;
            do {
            Console.WriteLine("PESQUISAR CLIENTE");
            Console.WriteLine("*****************");
            Console.WriteLine("1 - Buscar por ID");
            Console.WriteLine("2 - Buscar por nome");
            Console.WriteLine("0 - Sair");

            string menuOpt = Console.ReadLine();
            aux = Convert.ToInt16(menuOpt);
            switch(aux) {
                case 1:
                    Console.WriteLine("Informe o id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    ShowCustomerById(id);
                break;
                case 2:
                    Console.WriteLine("Informe o nome: ");
                    string name = Console.ReadLine();
                    ShowCustomersByName(name);
                break;  

                case 0:
                break;

                default:
                    aux = -1;
                    Console.WriteLine("Opção inválida!");
                break;

            }
        } while(aux != 0);

    }
    
    private void ShowCustomerById(int id) {
        Customer c = customerController.GetCustomerById(id);
        if(c != null) {
            Console.WriteLine(c.ToString());
        }
        else {
            Console.WriteLine($"Consumidor de id {id} não encontrado");
        }
    }
    private void ShowCustomersByName(string name) {
        List<Customer> result = customerController.GetByName(name);
        if(result == null) {
            Console.Writeline("Não encontrado!");
            return;
        }
        else {
            Console.WriteLine("Lista de consumidores");
             foreach (Customer customer in result){
            PrintCustomerData(customer);
        }

        }
        
    }   
    private void PrintCustomerData(Customer customer){
        Console.WriteLine(Customer.ToString());
    }
    
    
    private void ListCustomers() {
            List<Customer> result = customerController.Get();
            if (result == null || result?.Count == 0) {
                Console.WriteLine("Não encontrado!");
                return;
            }

            if (result.Count == 0) {
                Console.WriteLine("Não encontrado!");
                return;
            }

            foreach (Customer customer in result) {
                Console.WriteLine(customer.ToString());
            }
        }
  }
 
 }