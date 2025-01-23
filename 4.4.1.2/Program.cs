using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Hola quien eres?");
        string nombre = Console.ReadLine();

        if (nombre == "María")
        {
            nombre = "Jefa";
        }
        else if (nombre == "Boris")
        {
            nombre = "Jefe";
        }

        string saludo = "Hola " + nombre;

        Console.WriteLine(saludo);
        
    }
}