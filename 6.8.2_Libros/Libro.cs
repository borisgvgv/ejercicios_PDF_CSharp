using System;

public class Libro
{
    public static void Main()
    {
        Console.Clear();
        classDocumento documento = new classDocumento();
        classNumPaginas numeroDePaginas = new classNumPaginas();

        documento.MostrarDocumento();
        numeroDePaginas.MostrarNumPaginas();
        System.Console.WriteLine();

        System.Console.Write("Tipo de documento: ");
        string tipodDeDocumento = Console.ReadLine();
        System.Console.Write("Título: ");
        string titulo = Console.ReadLine();
        System.Console.Write("Autor: ");
        string autor = Console.ReadLine();
        System.Console.Write("Ubicación: ");
        string ubicacion = Console.ReadLine();
        System.Console.Write("Número de pág: ");
        int numPag = Convert.ToInt32(Console.ReadLine());

        classDocumento documento2 = new classDocumento(tipodDeDocumento, titulo, autor, ubicacion);
        classNumPaginas numeroDePaginas2 = new classNumPaginas(numPag);

        documento2.MostrarDocumento();
        numeroDePaginas2.MostrarNumPaginas();
        System.Console.WriteLine();

        




    }

}