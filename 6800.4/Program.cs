using System;

class Program
{
    public static void Main()
    {

        Documento documento = new Documento();
        Console.WriteLine();

        Libro libro = new Libro();
        libro.SetTitulo("Rayuela");
        libro.Mostrar();

        Cuaderno cuaderno = new Cuaderno();
        cuaderno.SetTitulo("Cuaderno de pintura");
        cuaderno.Mostrar();






    }
}