using System;
using System.Drawing;
public class PruebaDeCoche
{
    public static void Main()
    {

        Coche coche1 = new Coche();

        Console.Write("Marca: ");
        string marca = Console.ReadLine();
        Console.WriteLine("Color");
        Console.Write("R: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("G: ");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.Write("B: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Potencia: ");
        double potencia = Convert.ToDouble(Console.ReadLine());

        coche1.SetDatosCoche(marca, r,g,b, potencia);
        coche1.mostrarCoche();

        


    }
}