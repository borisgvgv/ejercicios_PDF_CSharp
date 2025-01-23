
using System;

public class Persona
{
    public static void Main()
    {
        Console.Clear();
        classPersona p1 = new classPersona();
        classPersonaInglesa pInglesa = new classPersonaInglesa();
        classPersonaItaliana pItaliana = new classPersonaItaliana();

        //--------------------------------
        System.Console.WriteLine("Hola, Como te llamas?");
        string nombre1 = Console.ReadLine();

        p1.SetNombre(nombre1);
        p1.MostrarSaludo();

        System.Console.WriteLine();
        System.Console.WriteLine("Hola, Como te llamas?");
        string nombrePI = Console.ReadLine();

        pInglesa.SetNombre(nombrePI);
        pInglesa.MostrarSaludo();
        pInglesa.TomarTe();

        System.Console.WriteLine();
        System.Console.WriteLine("Hola, Como te llamas?");
        string nombrePIt = Console.ReadLine();

        pItaliana.SetNombre(nombrePIt);
        pItaliana.MostrarSaludo();
        pItaliana.TomarTe();

    }
}



