using System;

public class Menu
{

    protected int option = 0;


    public void SetOption(int opcion)
    {
        this.option = option;
    }
    public int GetOption()
    {
        return option;
    }

    public void Mostrar()
    {
        // Menu principal, repetitivo
        Console.WriteLine();
        Console.WriteLine("Escoja una opción:");
        Console.WriteLine("1.- Añadir datos de un nuevo fichero");
        Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
        Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
        Console.WriteLine("4.- Ver datos de un fichero");
        Console.WriteLine("5.- Salir");
        // Hacemos una cosa u otra según la opción escogida
    }

}