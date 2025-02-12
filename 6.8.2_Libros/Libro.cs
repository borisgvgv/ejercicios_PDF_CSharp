using System;

public class Libro
{
    public static void Main()
    {
        Console.Clear();
        Documento documento = new Documento();
        NumPaginas numeroDePaginas = new NumPaginas();

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

                Documento documento2 = new Documento(tipodDeDocumento, titulo, autor, ubicacion);
                NumPaginas numeroDePaginas2 = new NumPaginas(numPag);

                documento2.MostrarDocumento();
                numeroDePaginas2.MostrarNumPaginas();
                System.Console.WriteLine();

        
    }

}