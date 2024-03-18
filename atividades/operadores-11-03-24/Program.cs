/*
Escreva um programa C# que seja capaz de perguntar ao usuário um operador aritmético específico (+ - * /)

E com base na operação escolhida pelo usuário, imprima na tela a tabuada de 1 a 9 daquela operação.

Utilize uma formatação de impressão e laço de repetição while ou for para exibir a tabuada completa dinamicamente;
*/


        string? option;

        do{
            Console.Clear();
            Console.WriteLine("Qual operação deseja executar? ( + | - | * | / ) ou digite x para sair");

            option = Console.ReadLine();

            switch (option)
            {
                // Usuário selecionou +
                case "+":
                {
                    for(int i=1;i<10;i++)
                    {
                        for(int j=1;j<10;j++)
                        {
                            Console.WriteLine(i + " + " + j + " = " + (i+j));
                        }
                    }
                     Console.ReadLine();
                     break;
                }
                
                // Usuário selecionou -
                case "-":
                {
                    for(int i=1;i<10;i++)
                    {
                        for(int j=1;j<10;j++)
                        {

                            Console.WriteLine(i + " - " + j + " = " + (i-j));
                        }
                    }
                     Console.ReadLine();
                     break;
                }
                 
                // Usuário selecionou *
                case "*":
                {
                    for(int i=1;i<10;i++)
                    {
                        for(int j=1;j<10;j++)
                        {

                            Console.WriteLine(i + " * " + j + " = " + (i*j));
                        }
                    }
                     Console.ReadLine();
                     break;
                }

                // Usuário selecionou /
                case "/":
                {
                    for(float i=1;i<10;i++)
                    {
                        for(float j=1;j<10;j++)
                        {

                            Console.WriteLine(i + " / " + j + " = " + (i/j));
                        }
                    }
                     Console.ReadLine();
                     break;
                }
            }
        } while(option != "x");

    Console.Clear();
