using System;

public class Libro : Datos
{
    public Libro(string titulo, string autor, string ubicacion)
    {
        System.Console.WriteLine("Creando Libro");
        System.Console.WriteLine();
        System.Console.WriteLine("Título: {0}", titulo);
        System.Console.WriteLine("Autor: {0}", autor);
        System.Console.WriteLine("Ubicación: {0}", ubicacion);
    }


}
