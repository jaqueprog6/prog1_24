/*Escreva um programa em C# que sirva como uma ficha cadastral, 
tente caprichar no layout, essa ficha cadastral deve coletar alguns dados do usuário:
-Nome -E-mail -Data de nascimento -Sexo ou gênero -CEP -Rua -Número -Bairro -Cidade -UF -País*/


using System;
using System.Collections.Generic;

// Classe com todos dados do usuário
public class Usuario
{
    private string? nome;
    private string? email;
    private string? dataNascimento;
    private string? genero;
    private string? cep;
    private string? rua;
    private string? numero;
    private string? bairro;
    private string? cidade;
    private string? estado;
    private string? pais;


    // Construtor
    public Usuario(string nome, string email, string dataNascimento,
                         string genero, string cep, string rua, string numero,
                          string bairro, string cidade, string estado, string pais)
    {
        this.nome = nome;
        this.email = email;
        this.dataNascimento = dataNascimento;
        this.genero = genero;
        this.cep = cep;
        this.rua = rua;
        this.numero = numero;
        this.bairro = bairro;
        this.cidade = cidade;
        this.estado = estado;
        this.pais = pais;
    }

    public string? getNome(){
        return this.nome;
    }

    public void retornaDados(){
        Console.Clear();
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("E-Mail: "+email);
        Console.WriteLine("Data de Nascimento: "+dataNascimento);
        Console.WriteLine("Genero: "+genero);
        Console.WriteLine("CEP: "+cep);
        Console.WriteLine("Rua: "+rua);
        Console.WriteLine("Numero: "+numero);
        Console.WriteLine("Bairro: "+bairro);
        Console.WriteLine("Cidade: "+cidade);
        Console.WriteLine("Estado: "+estado);
        Console.WriteLine("Pais: "+pais);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string? option = "";
        List<Usuario> listaUsuarios = new List<Usuario>();

        do{
            Console.Clear();
            Console.WriteLine("FICHA CADASTRAL");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Cadastrar Usuario");
            Console.WriteLine("2. Remover Usuario");
            Console.WriteLine("3. Consultar Usuario");
            Console.WriteLine("4. Sair");
            Console.WriteLine("--------------------------");
            Console.Write("Escolha uma opcao: ");

            option = Console.ReadLine();

            switch (option)
            {
                // Cadastrar Usuario
                case "1":
                {
                    // Variaveis temporárias para alimentar o construtor
                    string? nome;
                    string? email;
                    string? dataNascimento;
                    string? genero;
                    string? cep;
                    string? rua;
                    string? numero;
                    string? bairro;
                    string? cidade;
                    string? estado;
                    string? pais;

                    Console.Clear();
                    Console.WriteLine(" Informe o Nome do Usuario:");
                    nome = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe o E-Mail do Usuario");
                    email = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe a Data de nascimento do Usuario");
                    dataNascimento = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe o Genero do Usuario");
                    genero = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe o CEP do Usuario");
                    cep = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe a Rua do Usuario");
                    rua = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe o Numero da casa do Usuario");
                    numero = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe o Bairro do Usuario");
                    bairro = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe a Cidade do Usuario");
                    cidade = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe o Estado do Usuario");
                    estado = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(" Informe o País do Usuario");
                    pais = Console.ReadLine();

                        // Cadastro acontece aqui
                        listaUsuarios.Add(new Usuario(nome, email, dataNascimento, genero, cep, rua, numero, bairro, cidade, estado, pais));

                        break;
                }
                    
                // Remover Usuario
                case "2":
                {
                    Console.Clear();
                    if (listaUsuarios.Count > 0)
                    {
                        for (int i = 0; i < listaUsuarios.Count; i++)
                        {
                            Console.WriteLine((i+1) + " - " + listaUsuarios[i].getNome());
                        }

                        Console.WriteLine("Digite o ID do usuario que sera consultado:");
                        int id;
                        // Valida se a entrada foi realmente INT
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Entrada invalida, digite apenas o numero ID");
                        }

                        // Valida se o ID informado existe ]
                        if ((id-1 >= 0 && id-1 < listaUsuarios.Count))
                        {
                            
                            listaUsuarios.RemoveAt(id-1);
                        }
                        else
                        {
                            Console.WriteLine("ID Inexistente");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                       Console.WriteLine("Lista de usuarios ja esta vazia");  
                       Console.ReadLine();
                    }                              
                    break;
                }
                 
                // Consultar Usuario
                case "3":
                    // Tras todos nomes de usuarios na tela
                    // Usuario escolhe qual quer consultar
                    // Tras informacoes do usuario escolhido

                    Console.Clear();
                    if (listaUsuarios.Count > 0)
                    {
                        for (int i = 0; i < listaUsuarios.Count; i++)
                        {
                            Console.WriteLine((i+1) + " - " + listaUsuarios[i].getNome());
                        }

                        Console.WriteLine("Digite o ID do usuario que sera consultado:");
                        int id;
                        // Valida se a entrada foi realmente INT
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Entrada invalida, digite apenas o numero ID");
                        }

                        // Valida se o ID informado existe ]
                        if ((id-1 >= 0 && id-1 < listaUsuarios.Count))
                        {
                            
                            listaUsuarios[id-1].retornaDados();
                        }
                        else
                        {
                            Console.WriteLine("ID Inexistente");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                       Console.WriteLine("Lista de usuarios esta vazia");  
                    }                              
                        
                    Console.ReadLine();

                    break;
            }

        } while(option != "4");

    Console.Clear();
    }
}