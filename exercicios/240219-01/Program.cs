﻿// Trabalhando com variáveis C#

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


// Envie uma nova branch local para o repositorio remoto
