using System;

public class ProbarArchivos
{
    public static void Main()
    {
        System.Console.WriteLine("Titulo: ");
        string titulo = Console.ReadLine();
        System.Console.WriteLine("Autor: ");
        string autor = Console.ReadLine();
        System.Console.WriteLine("Ubicación: ");
        string ubicacion = Console.ReadLine();

        Libro libro = new Libro(titulo, autor, ubicacion);


    }
}

public class Datos
{
    protected string titulo;
    protected string autor;
    protected string ubicacion;

    
    public Datos()
    {
        titulo = "Undefined";
        autor = "Undefined";
        ubicacion = "Undefined";

    }

    
  
}

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