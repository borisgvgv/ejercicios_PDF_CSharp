using System;
class Program
{
    public static int Main(string[] args)
    {

        Console.WriteLine("Parámetros: {0}", args.Length);

        if (args.Length == 3)
        {

            if (double.TryParse(args[0], out double num1) && double.TryParse(args[2], out double num2))
            {

                if (!double.IsNaN(num1) || !double.IsNaN(num2))
                {


                    string operador = args[1];
                    double resultado = 0;

                    switch (operador)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;
                        default:
                            Console.WriteLine("Use un operador +");
                            break;

                    }
                    Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
                    Environment.Exit(0);

                }

            }
            else
                {
                    Console.WriteLine("Operación imposible algún valor no es un número");
                    Environment.Exit(2);
                }

        }

        if (args.Length != 0)
        {
            Console.WriteLine("Operación aceptable");
            Console.WriteLine("Formato correcto: num operador num");
            Environment.Exit(3);

        }



        if (args.Length == 0)
        {
            Console.WriteLine("No se ha indicado ningún parametro");
            Environment.Exit(4);
        }
        return 0;

    }
}
