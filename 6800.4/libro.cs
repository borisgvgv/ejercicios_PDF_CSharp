using System;

class Libro : Documento
{

    protected string titulo;

    public Libro()
    {
        Console.WriteLine("Libro");
        titulo = "Indef";
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void Mostrar()
    {
        Console.WriteLine(titulo);
        Console.WriteLine();
    }


}