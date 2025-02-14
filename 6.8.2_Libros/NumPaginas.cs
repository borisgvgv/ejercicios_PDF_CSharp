/*
(6.2.3) Para guardar información sobre libros, vamos a comenzar por crear una
clase "Libro", que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos
strings) y métodos Get y Set adecuados para leer su valor y cambiarlo. Prepara
también un Main (en la misma clase), que cree un objeto de la clase Libro, dé
valores a sus tres atributos y luego los muestre.
*/

using System;

public class NumPaginas
{

    protected int numPaginas;

    public NumPaginas()
    {

        numPaginas = 0;
    }

    public NumPaginas(int newNumPaginas)
    {

        numPaginas = newNumPaginas;
    }

    public void MostrarNumPaginas()
    {
        System.Console.WriteLine("Número de páginas: {0}", numPaginas);
    }

}

