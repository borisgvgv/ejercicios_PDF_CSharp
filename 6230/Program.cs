using System;

public class Libro
{

    string autor = "Pendiente";
    string titulo = "Pendiente";
    string nacionalidad = "Pendiente";

    public string GetAutor()
    {
        return autor;
    }
    public void SetAutor(string nuevoAutor)
    {
        autor = nuevoAutor;
    }

    public string GetTitulo()
    {
        return titulo;
    }
    public void SetTitulo(string nuevoTitulo)
    {
        titulo = nuevoTitulo;
    }

    public string GetNacionalidad()
    {
        return nacionalidad;
    }
    public void SetNacionalidad(string nuevaNacionalidad)
    {
        nacionalidad = nuevaNacionalidad;
    }

    public void MostrarLibro(){
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Título: {titulo}");
        Console.WriteLine($"Ubicación: {nacionalidad}");
    }

}

public class Libros{
    public static void Main(){

Libro libro_1 = new Libro();
Libro libro_2 = new Libro();

libro_2.SetAutor("Julio Cortazar");
libro_2.SetTitulo("Rayuela");
libro_2.SetNacionalidad("Argentina");

Console.WriteLine("Libro 1");
libro_1.MostrarLibro();
Console.WriteLine("Libro 2");
libro_2.MostrarLibro();

    }
}