using System;

public class Documento
{
    public static void Main()
    {
        Console.Clear();
        Titulo titulo = new Titulo("Libro", "Rayuela");
        Autor autor = new Autor("Autor" , "Julio Cortazar");
        System.Console.WriteLine(titulo.ToString());
        System.Console.WriteLine(autor.ToString());
    }
}
public class Tipo
{
    protected string tipo;
    public Tipo(string tipo)
    {
        this.tipo = tipo;
    }
    public string ToString()
    {
        return tipo + " ";
    }
}

public class Titulo : Tipo
{
    protected string titulo;
    public Titulo(string tipo, string titulo) : base(tipo)
    {
        this.titulo = titulo;
    }

    public new string ToString()
    {
        return tipo + ": " + titulo;
    }
}

public class Autor : Tipo
{
    protected string nombre;
    public Autor(string tipo, string nombre) : base(tipo)
    {
        this.nombre = nombre;
    }

    public new string ToString()
    {
        return tipo + ": " + nombre;
    }
}