/*
(8.7.2) Un programa que pida al usuario un número, una operación (+, -, *, /) y un
segundo número, y muestre el resultado de la correspondiente operación. Si se
teclea un dato no numérico, el programa deberá mostrar un aviso y volver a
pedirlo, en vez de interrumpir la ejecución.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Número 1");
        int n1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Número2");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int resultado = 0;
        char operador;

        System.Console.WriteLine("Operación (*,/,+,-)");
        do
        {
            operador = Convert.ToChar(Console.ReadLine());
            switch (operador)
            {
                case '*':
                    System.Console.WriteLine("{0} {1} {2} = {3}", n1, operador, n2, n1 * n2);
                    break;
                case '/':
                    System.Console.WriteLine("{0} {1} {2} = {3}", n1, operador, n2, n1 / n2);
                    break;
                case '+':
                    System.Console.WriteLine("{0} {1} {2} = {3}", n1, operador, n2, n1 + n2);
                    break;
                case '-':
                    System.Console.WriteLine("{0} {1} {2} = {3}", n1, operador, n2, n1 - n2);
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (operador != '*' || operador != '/' || operador != '+' || operador != '-');

    }
}



