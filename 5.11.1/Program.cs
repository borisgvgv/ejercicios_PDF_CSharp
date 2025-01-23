using System;

public class Program
{
    public static int Suma(int a, int b)
    {
        return a + b;
    }
    public static int Main(string[] args)
    {

        System.Console.WriteLine("Cantidad de parámetros: {0}", args.Length);

        if (args.Length == 3)
        {
                    System.Console.WriteLine("{0} = {1}", args[0], Suma(Convert.ToInt32(args[1]), Convert.ToInt32(args[2])));

        }
        else  
        {
            Console.WriteLine("Falta algún parámetro!");
            Environment.Exit(1);
        }
        return 0;

        
    }
}
