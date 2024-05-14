using _240401_1.Models;
using _240401_1.Views;

bool aux = true;
do{
    Console.WriteLine("***********************");
    Console.WriteLine("MEU PROGRAMA DE PEDIDOS");
    Console.WriteLine("***********************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    try {
        menu = Convert.ToInt32(Console.ReadLine());
         switch(menu){
            case 1:
                CustomerView customerView = new CustomerView();
            break;
            case 2:
                ProductView productView = new ProductView();
            break;
            case 3:
                OrderView orderView = new OrderView();
            break;
            case 0:
                aux = false;
                Console.WriteLine("Obrigado e volte sempre!");
            break;

            default:
                Console.WriteLine("Opção Inválida.");
            break;
    
        }
    }
    catch {
        Console.WriteLine("Opção Inválida.");
        aux = true;
    }
}
while (aux);

/*

Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Lord Vader";
//c1.EmailAddress = "lordvader@ladonegrodanet.com";
//c1.HomeAddress = "Fortaleza Vader";
//c1.WorkAddres = "Estrela da Morte";

Customer c2 = new Customer(2);
c2.Name = "Anakin Skywalker";
//c2.EmailAddress = "anakimsky@sabreluz.com";
//c2.HomeAddress = "Tatooine";
//c2.WorkAddres = "Ferro Velho";

Customer c3 = new Customer(3);
c3.Name = "Princesa Leia Organa";
//EmailAddress = "princesaleia@ladodaforca.com";
//HomeAddress = "Alderaan";
//WorkAddres = "D'Qar";

// Usando outra assinatura para o método construtor

/*Customer c4 = new Customer(
    4,
    "Yoda",
    "yoda.green@gmail.com",
    "Dagobah - Planeta",
    "Planeta pantanoso"
);

List<Customer> clientes = [c1, c2, c3];
Console.WriteLine("Lista de clientes");
foreach (var cliente in clientes){
    Console.WriteLine("----------------");
    Console.WriteLine($"Nome: {cliente.Name}");
    //Console.WriteLine($"E-mail: {cliente.Email.Address}");
    //Console.WriteLine($"Endereço de trabalho: {cliente.WorkAddress}");
    //Console.WriteLine($"Endereço residencial: {cliente.HomeAddress}");
}
*/
