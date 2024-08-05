using System;

class Program
{
    static void Main()
    {

        System.Console.WriteLine("Añade un refrán");
        string refran = Console.ReadLine();
        
        string[] refrandescompuesto = refran.Split();

        foreach (string resultado in refrandescompuesto)
        {
            Console.WriteLine(resultado);
        }


    }
}
