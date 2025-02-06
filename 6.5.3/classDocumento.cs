using System;

public class classDocumento
{

    protected string autor;
    protected string titulo;
    protected string ubicacion;

    public string GetAutor()
    {
        return autor;
    }

    public void SetAutor(string newAutor)
    {
        autor = newAutor;
    }

    public string GetTitulo()
    {
        return titulo;
    }

    public void SetTitulo(string newTitulo)
    {
        titulo = newTitulo;
    }

    public string GetUbicacion()
    {
        return ubicacion;
    }

    public void SetUbicacion(string newUbicacion)
    {
        ubicacion = newUbicacion;
    }

    public void MostrarLibro()
    {
        System.Console.WriteLine();//Salto de línea
        System.Console.WriteLine("Libro Actual");
        System.Console.WriteLine("Autor: {0}", autor);
        System.Console.WriteLine("Título: {0}", titulo);
        System.Console.WriteLine("Ubicación: {0}", ubicacion);
    }

}