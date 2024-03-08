/*
(5.11.1) Crea un programa llamado "suma", que calcule (y muestre) la suma de dos
números que se le indiquen como parámetros en línea de comandos. Por
ejemplo, si se teclea "suma 2 3" deberá responder "5", si se teclea "suma 2"
responderá "2" y si se teclea únicamente "suma" deberá responder "no hay
suficientes datos" y devolver un código de error 1.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 2)
        {
            // Si hay dos argumentos, intenta convertirlos a números
            if (double.TryParse(args[0], out double num1) && double.TryParse(args[1], out double num2))
            {
                // Calcula y muestra la suma
                double suma = num1 + num2;
                Console.WriteLine(suma);
            }
            else
            {
                Console.WriteLine("Los argumentos no son números válidos");
                Environment.Exit(1);
            }
        }
        else if (args.Length == 1)
        {
            // Si hay un argumento, intenta convertirlo a número
            if (double.TryParse(args[0], out double num))
            {
                // Muestra el único número proporcionado
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("El argumento no es un número válido");
                Environment.Exit(1);
            }
        }
        else
        {
            // Si no hay suficientes argumentos, muestra un mensaje de error y devuelve el código de error 1
            Console.WriteLine("No hay suficientes datos");
            Environment.Exit(1);
        }
    }
}
