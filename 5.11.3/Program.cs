/*
(5.11.3) Crea una variante del ejercicio 5.11.2, en la que Main devuelva el código 1
si la operación indicada no es válida o 0 cuando sí sea una operación aceptable.
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
            int a = Convert.ToInt32(args[1]);
            int b = Convert.ToInt32(args[2]);

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
        else
        {
            Console.WriteLine("Falta algún parámetro!");
            Environment.Exit(1);
        }
        return 0;


    }
}

