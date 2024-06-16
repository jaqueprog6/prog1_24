bool aux = true;
do {
    Console.WriteLine("*******************");
    Console.WriteLine("Aluguel de Livros");
    Console.WriteLine("*******************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Acervo");
    Console.WriteLine("3 - Locação");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    try {
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu) {
            case 1:
            break;
            case 2:
            break;
            case 3:
            break;
            case 0:
            break;
            default:
                Console.WriteLine("Opção inválida.");
            break;
        }
    }

    catch {
        Console.WriteLine("Opção Inválida.");
        menu = -1;
        aux = true;
    }
}

while(aux);