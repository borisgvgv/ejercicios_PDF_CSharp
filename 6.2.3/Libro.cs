/*
(6.2.3) Para guardar información sobre libros, vamos a comenzar por crear una
clase "Libro", que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos
strings) y métodos Get y Set adecuados para leer su valor y cambiarlo. Prepara
también un Main (en la misma clase), que cree un objeto de la clase Libro, dé
valores a sus tres atributos y luego los muestre.
*/

using System;

public class Libro
{
    string autor;
    string titulo;
    string ubicacion;

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

public class ProgramLibro
{
    public static void Main()
    {
        Console.Clear();
        Libro l = new Libro();

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