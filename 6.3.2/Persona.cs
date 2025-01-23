
using System;

public class Persona
{
    public static void Main()
    {
        Console.Clear();
        classPersona p = new classPersona();

        System.Console.WriteLine("Hola, Como te llamas?");
        string nombre = Console.ReadLine();

        p.SetNombre(nombre);
        p.MostrarSaludo();


    }
}



