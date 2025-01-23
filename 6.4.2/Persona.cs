
using System;

public class Persona
{
    public static void Main()
    {
        Console.Clear();
        classPersona p1 = new classPersona();
        classPersona p2 = new classPersona();
        classPersonaInglesa pInglesa = new classPersonaInglesa();

        System.Console.WriteLine("Hola, Como te llamas?");
        string nombre1 = Console.ReadLine();

        p1.SetNombre(nombre1);
        p1.MostrarSaludo();

        System.Console.WriteLine();
        System.Console.WriteLine("Hola, Como te llamas?");
        string nombre2 = Console.ReadLine();

        p2.SetNombre(nombre2);
        p2.MostrarSaludo();

        System.Console.WriteLine();
        System.Console.WriteLine("Hola, Como te llamas?");
        string nombrePI = Console.ReadLine();

        pInglesa.SetNombre(nombrePI);
        pInglesa.MostrarSaludo();
        pInglesa.TomarTe();


    }
}



