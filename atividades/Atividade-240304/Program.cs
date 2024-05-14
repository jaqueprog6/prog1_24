int numero1 = 0;
int numero2 = 0;
char operador = ' ';

Console.WriteLine("Digite o primeiro número:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o operador (+, -, , /):");
operador = char.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numero2 = int.Parse(Console.ReadLine());

int resultado = 0;

if (operador == '+')
{
    resultado = numero1 + numero2;
}
else if (operador == '-')
{
    resultado = numero1 - numero2;
}
else if (operador == '*')
{
    resultado = numero1 * numero2;
}
else if (operador == '/')
{
    if (numero2 == 0)
    {
        Console.WriteLine("Não é possível dividir por zero.");
    }
    else
    {
        resultado = numero1 / numero2;
    }
}

Console.WriteLine($"Resultado: {numero1} {operador} {numero2} = {resultado}");

