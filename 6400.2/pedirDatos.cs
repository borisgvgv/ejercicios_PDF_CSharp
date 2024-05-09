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
        while (!int.TryParse(Console.ReadLine(), out edad)){

            Console.WriteLine("Por favor, ingrese una edad válida (número entero).");
            Console.Write("Ingrese la edad: ");

        }
        return edad;
    }

/*
    public void pedirDatos()
    {
        Persona persona = new Persona();

        Console.WriteLine("Recoger datos de la persona");
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Nacionalidad: ");
        string nacionalidad = Console.ReadLine();
        Console.Write("Edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        persona.SetDatos(nombre, nacionalidad, edad);
    }
*/

}