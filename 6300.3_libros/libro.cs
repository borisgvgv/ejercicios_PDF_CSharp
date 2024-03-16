using System;

public class Libro
{

    protected int numeracion;
    protected string titulo;
    protected string autor;
    protected int lanzamiento;

    public Libro()
    {
        titulo = "pndte";
        autor = "pndte";
        lanzamiento = 0;
    }

    public void SetNumeracion(int nuevaNumeracion)
    {
        numeracion = nuevaNumeracion;
    }
    public string GetTitulo()
    {
        return titulo;
    }
    public void SetTitulo(string nuevoTitulo)
    {
        titulo = nuevoTitulo;
    }

    public string GetAutor()
    {
        return autor;
    }
    public void SetAutor(string nuevoAutor)
    {
        autor = nuevoAutor;
    }

    public int GetLanzamiento()
    {
        return lanzamiento;
    }
    public void SetLanzamiento(int nuevoLanzamiento)
    {
        lanzamiento = nuevoLanzamiento;
    }

    public void mostrar()
    {
        Console.WriteLine("Numeración: {0}", numeracion);
        Console.WriteLine("Titulo: {0}", titulo);
        Console.WriteLine("Autor: {0}", autor);
        Console.WriteLine("Lanzamiento: {0}", lanzamiento);
    }

}
