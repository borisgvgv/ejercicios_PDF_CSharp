using System;

class Program
{
    static void Main()
    {
        int resultado = 0;

        Console.Write("Primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Operador: ");
        char operador = Convert.ToChar(Console.ReadLine());

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case ':':
                resultado = num1 / num2;
                break;
            case '/':
                resultado = num1 / num2;
                break;

            default:
                Console.WriteLine("Este operador no existe");
                Console.WriteLine("Intentalo denuevo");
                break;
        }

        Console.WriteLine("{0} {1} {2} = {3}", num1, operador, num2, resultado);

    }
}