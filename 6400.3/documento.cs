using System;
public class Documento
{

    protected string titulo;
    protected int lanzamiento;

    public Documento()
    {
        titulo = "indefinido";
        lanzamiento = 0;
    }

    public string GetTitulo()
    {
        return titulo;
    }
    public int GetLanzamiento()
    {
        return lanzamiento;
    }

    public void SetDatos(string titulo, int lanzamiento)
    {
        this.titulo = titulo;
        this.lanzamiento = lanzamiento;
    }

    public void Mostrar()
    {
        Console.WriteLine("Titulo: {0}", titulo);
        Console.WriteLine("Lanzamiento: {0}", lanzamiento);
        Console.WriteLine();
    }

}

