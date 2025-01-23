/*
(5.11.4) Crea una variante del ejercicio 5.11.3, en la que Main devuelva también el
código 2 si alguno de los dos números con los que se quiere operar no tiene un
valor numérico válido.
*/

using System;

public class Program
{
    public static int Suma(int a, int b)
    {
        return a + b;
    }

    public static int Resta(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicacion(int a, int b)
    {
        return a * b;
    }
    public static int Division(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        else
        {
            return a / b;
        }
    }


    public static int Main(string[] args)
    {

        System.Console.WriteLine("Cantidad de parámetros: {0}", args.Length);

        if (args.Length == 3)
        {
            // Hay que inicializar con un valor las variables a y b para que no de error
            int a=0, b=0;

            // Validamos que ambos parámetros sean números
            //Intenta convertir una cadena en un número entero. Devuelve true si tiene éxito, de lo contrario, false
            if (!int.TryParse(args[1], out a)|| !int.TryParse(args[2], out b))
            {
                Console.WriteLine("Alguno de los parámetros no es un número válido.");
                Environment.Exit(2);
            }

            switch (args[0])
            {
                case "suma":
                    System.Console.WriteLine(Suma(a, b));
                    break;

                case "resta":
                    System.Console.WriteLine(Resta(a, b));
                    break;

                case "multiplicacion":
                    System.Console.WriteLine(Multiplicacion(a, b));
                    break;

                case "division":
                    if (b == 0)
                    {
                        System.Console.WriteLine("No es posible dividir por 0");
                    }
                    else
                    {
                        System.Console.WriteLine(Division(a, b));

                    }
                    break;

                default:
                    System.Console.WriteLine("Operación desconocida");
                    break;
            }

        }
        else if (args.Length == 0)
        {
            Console.WriteLine("Falta algún parámetro!");
            Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Hay un error en el la operación indicada");
            Environment.Exit(2);
        }

        return 0;

    }
}
