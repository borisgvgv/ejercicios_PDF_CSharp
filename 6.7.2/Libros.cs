using System;

/*
(6.7.2) Amplía el proyecto del ejercicio 6.6.2 (Libro): la clase Libro tendrá un
segundo constructor que permita dar valores al autor y el título, pero no a la
ubicación, que tomará el valor por defecto "No detallada"
*/

public class Libros
{

    public static void Main()
    {
        DatosDelLibro datosDelLibro = new DatosDelLibro("Rayuela", "Cortazar", "Argentina");
        DatosDelLibro datosDelLibro2 = new DatosDelLibro("100 años de Soledad", "Gabriel García Marques");

        datosDelLibro.MostrarDatosDelLibro();
        System.Console.WriteLine();
        datosDelLibro2.MostrarDatosDelLibro();
    }

}

