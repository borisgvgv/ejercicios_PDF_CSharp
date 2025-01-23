using System;

public class Libro
{
    public static void Main()
    {
        Console.Clear();
        classDocumento l = new classDocumento();
        classLibro numeroDePaginas = new classLibro();


        l.SetAutor("García Marques");
        l.SetTitulo("100 años de soledad");
        l.SetUbicacion("Colombia");
        l.MostrarLibro();
        numeroDePaginas.SetNumPaginas(500);
        numeroDePaginas.MostrarNumPaginas();
        


        System.Console.WriteLine();

        l.SetAutor("Julio Cortazar");
        l.SetTitulo("Rayuela");
        l.SetUbicacion("Argentina");
        l.MostrarLibro();
        numeroDePaginas.SetNumPaginas(600);
        numeroDePaginas.MostrarNumPaginas();




    }

}