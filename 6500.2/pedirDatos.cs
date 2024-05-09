using System;

class PedirDatos
{

    public string PedirNombre()
    {
        Console.Write("Nombre: ");
        return Console.ReadLine();
    }

    public string PedirNacionalidad()
    {
        Console.Write("Nacionalidad: ");
        return Console.ReadLine();
    }

    public int PedirEdad()
    {
        Console.Write("Edad: ");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad))
        {
            Console.WriteLine("Por favor, ingrese una edad válida (número entero).");
            Console.Write("Ingrese la edad: ");
        }
        return edad;
    }
    
}