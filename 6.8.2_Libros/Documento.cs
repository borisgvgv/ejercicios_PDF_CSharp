using System;

public class Documento : Datos
{
    public Documento(string titulo, string autor, string ubicacion)
    {
        System.Console.Write("Creando Documento");
        System.Console.WriteLine();
        System.Console.WriteLine("Título: {0}", titulo);
        System.Console.WriteLine("Autor: {0}", autor);
        System.Console.WriteLine("Ubicación: {0}", ubicacion);
    }
}