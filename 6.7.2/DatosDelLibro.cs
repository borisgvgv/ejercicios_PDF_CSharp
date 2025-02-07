using System;

public class DatosDelLibro
{

    protected string titulo;
    protected string autor;
    protected string nacionalidad;
    public DatosDelLibro(string newT, string newA, string newN)
    {
        titulo = newT;
        autor = newA;
        nacionalidad = newN;
    }
    public DatosDelLibro(string newT, string newA)
    {
        titulo = newT;
        autor = newA;
        nacionalidad = "";
    }

    public void MostrarDatosDelLibro()
    {
        System.Console.WriteLine("Título: {0}", titulo);
        System.Console.WriteLine("Autor: {0}", autor);
        
        if (nacionalidad != "")
        {

            System.Console.WriteLine("Nacionalidad: {0}", nacionalidad);
        }
        else
        {
            System.Console.WriteLine("Nacionalidad: Ciudadano del mundo");
        }

    }
}