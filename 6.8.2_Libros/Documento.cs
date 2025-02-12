using System;

public class Documento
{

    protected string documento;
    protected string titulo;
    protected string autor;
    protected string ubicacion;

    public Documento()
    {
        documento = "Undefined";
        titulo = "Undefined";
        autor = "Undefined";
        ubicacion = "Undefined";
    }

    public Documento(string newDocumento, string newTitulo, string newAutor, string newUbicacion)
    {
        documento = newDocumento;
        titulo = newTitulo;
        autor = newAutor;
        ubicacion = newUbicacion;
    }

    public void MostrarDocumento()
    {
        System.Console.WriteLine();//Salto de línea

        System.Console.WriteLine("Documento actual");
        System.Console.WriteLine("Tipo de documento: {0}", documento);
        System.Console.WriteLine("Título: {0}", titulo);
        System.Console.WriteLine("Autor: {0}", autor);
        System.Console.WriteLine("Ubicación: {0}", ubicacion);
    }

}