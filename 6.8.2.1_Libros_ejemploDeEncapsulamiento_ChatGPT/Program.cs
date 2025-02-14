using System;

public class Program
{
    public static void Main()
    {
        IItem item = new Libro("C# Programming", "John Doe", "Shelf 1");
        item.MostrarDetalles();

    }
}
public interface IItem // Ejemplo con una interfaz para crear un documento genérico
{
    void MostrarDetalles();
}

public class Datos
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Ubicacion { get; set; }
}


public class Libro : Datos, IItem
{
    public Libro(string titulo, string autor, string ubicacion)
    {
        this.Titulo = titulo;
        this.Autor = autor;
        this.Ubicacion = ubicacion;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("Creando Libro");
        Console.WriteLine("Título: {0}", this.Titulo);
        Console.WriteLine("Autor: {0}", this.Autor);
        Console.WriteLine("Ubicación: {0}", this.Ubicacion);
    }
}

public class Documento : Datos, IItem
{
    public Documento(string titulo, string autor, string ubicacion)
    {
        this.Titulo = titulo;
        this.Autor = autor;
        this.Ubicacion = ubicacion;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("Creando Documento");
        Console.WriteLine("Título: {0}", this.Titulo);
        Console.WriteLine("Autor: {0}", this.Autor);
        Console.WriteLine("Ubicación: {0}", this.Ubicacion);
    }
}


