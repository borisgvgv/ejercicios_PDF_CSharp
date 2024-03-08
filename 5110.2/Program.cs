/*
Crea una calculadora básica, llamada "calcula", que deberá sumar, restar,
multiplicar o dividir los dos números que se le indiquen como parámetros.
Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60
*/

using System;

class Calculadora
{
    static void Main(string[] args)
    {
        if (args.Length == 3)
        {
            // Obtener los números y el operador de la línea de comandos
            if (double.TryParse(args[0], out double num1) && double.TryParse(args[2], out double num2))
            {
                string operador = args[1];

                // Realizar la operación según el operador proporcionado
                switch (operador)
                {
                    case "+":
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case "x":
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operador no válido. Use +, -, x, /.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Los argumentos no son números válidos");
            }
        }
        else
        {
            Console.WriteLine("Formato incorrecto. Uso: calcula <número1> <operador> <número2>");
            
        }
    }
}
