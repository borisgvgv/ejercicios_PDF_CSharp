using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        StreamWriter archivo;

        //Creamos archivo y añadimos un primer texto
        archivo = File.CreateText("Archivo.txt");
        archivo.WriteLine("Texto de la primera línea 1");
        archivo.Close();

        //Añadimos más texto al archivo
        archivo = File.AppendText("Archivo.txt");
        archivo.WriteLine("Añadimos texto en la segunda línea 1");
        archivo.Close();

        StreamReader leerArchivo;
        string linea;

        leerArchivo = File.OpenText("Archivo.txt");
        linea = leerArchivo.ReadLine();
        Console.WriteLine(linea);
        Console.WriteLine(leerArchivo.ReadLine());
        leerArchivo.Close();

        Console.WriteLine();
        //-------------------Otra forma de hacerlo con un costructor.-------------------

        //Creamos archivo y añadimos un primer texto
        using (StreamWriter archivo2 = new StreamWriter("Archivo2.txt"))
        {
            archivo2.WriteLine("Texto de la primera línea 2");
        }

        //Añadimos más texto al archivo
        using (StreamWriter addTexto = new StreamWriter("Archivo2.txt", true))
        {
            addTexto.WriteLine("Añadimos texto en la segunda línea 2");
        }

        using (StreamReader leerArchivo2 = new StreamReader("Archivo2.txt"))
        {
            do
            {
                linea = leerArchivo2.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            } while (linea != null);
        }
    }
}