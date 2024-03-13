// Trabalhando com variáveis C#

// Strings
// Declarando variável sem inicialização
string message1 = null;
//Inicializar a variável com nulo
string message2 = null;

// Inicializar a string vazia
string message3 = System.String.Empty; // "";
// Declarar uma string com um valor implícito
var message4 = "Uma mensagem aleatória";

Console.WriteLine( message4 );

// Concatenando Strings
string concat = (message1 == null ? "" : message1) + " " + message2 + " " +
                message3 + " " + message4;
Console.WriteLine( "/n" + concat );

Console.WriteLine( 
    "A temperatura hoje {0:D} é {1}ºC"
    ,DateTime.Now
    ,23 
);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado);


// Comentário de marcação 240304

// Substituindo conteúdo de strings 
string nomeCompleto = "Jack Camargo";
nomeCompleto =
    nomeCompleto.Replace("Jack", "Do espaço");
Console.WriteLine(nomeCompleto);

// Comparação de strings
bool isNomeEqual =
 (nomeCompleto == "Jack Camargo");

 bool isNomeEqual2 = 
    string.Equals(nomeCompleto, "Jack Do espaço Camargo");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo resultado: {isNomeEqual2}");

// TIPOS NÚMERICOS
/*
    sbyte: Amazena valores entre -128 e 127
    short: Armazena valores entre -32, 768 e 32,767
    int: Armazena valores entre -2,147,483,648 e 2,147,483,647
    long: Armazena valores entre -9,223,372,036,854,775,807 e 9,233,372,036,854,775,807
*/

float myFLoat = 10f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;


myDouble = Convert.ToDouble(Console.ReadLine());

