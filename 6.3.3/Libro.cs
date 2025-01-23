using System;

public class Libro
{
    public static void Main()
    {
        Console.Clear();
        classLibro l = new classLibro();

        l.SetAutor("García Marques");
        l.SetTitulo("100 años de soledad");
        l.SetUbicacion("Colombia");
        l.MostrarLibro();

        System.Console.WriteLine();

        l.SetAutor("Julio Cortazar");
        l.SetTitulo("Rayuela");
        l.SetUbicacion("Argentina");
        l.MostrarLibro();



    }

}