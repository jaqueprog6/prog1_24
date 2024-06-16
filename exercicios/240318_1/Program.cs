using _240318_1.Models;

// Instância de objeto do tipo Customer
Customer c1 = new Customer();

// Atribuindo valores aos atributos do obejto c1
c1.CustomerId = 1;
c1.FirstName = "Yuri";
c1.LastName = "Vinicius";
c1.BirthDate = new DateTime();
c1.EmailAddress = "yurivsa98@gmail.com";

// Instância de objetos do tipo Address
Address address1 = new Address();
// Atribuindo valor aos atributos do objeto address1
address1.AddressId = 1;
address1.Street = "Jardim Itália";
address1.Neighbourhood = "Barão blabla";
address1.City = "Chapecó";
address1.Number = 98;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89560-000";
// AddressTYpe é do Enum - portanto espera receber 
// valor equivalente ao seu tipo
address1.AddressType = AddressType.Commercial;
// Guardando um endereço à lista de endereços do consumidor 

c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS: ");
// 
foreach(var ad in c1.Addresses){
    Console.WriteLine("-------------------");
    Console.WriteLine( $"Rua: {ad.Street}");
    Console.WriteLine( $"Bairro: {ad.Neighbourhood}");
    Console.WriteLine( $"Nro: {ad.Number}");
    Console.WriteLine( $"Cidade: {ad.City}");
    Console.WriteLine( $"Estado: {ad.FederalState}");
    Console.WriteLine( $"País: {ad.Country}");
}

Console.WriteLine( $"Nome: {c1.FirstName} {c1.LastName}" );
Console.WriteLine( $"Email: {c1.EmailAddress}");

