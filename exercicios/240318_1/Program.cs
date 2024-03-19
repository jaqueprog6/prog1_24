using _240318_1.Models;


Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Yuri";
c1.LastName = "Vinicius";
c1.BirthDate = new DateTime();
c1.EmailAddress = "yurivsa98@gmail.com";

Address address1 = new Address();
address1.AddressId = 1;
address1.Street = "Jardim Itália";
address1.Neighbourhood = "Barão blabla";
address1.City = "Chapecó";
address1.Number = 98;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89560-000";

c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS: ");
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

