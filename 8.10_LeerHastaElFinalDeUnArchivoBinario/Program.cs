using System;
using System.IO;

public class Program
{
    public static void Main()
    {

        Console.Clear();
        System.Console.Write("Introduzca el nombre del archivo: ");
        string nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        //Creamos archivo y escribimos el texto.
        using (StreamWriter crearArchivo = new StreamWriter(nombreArchivo))
        {
            string texto;
            System.Console.WriteLine("Introduce un texto");
            do
            {

                texto = Console.ReadLine();
                if (texto != "fin")
                    crearArchivo.WriteLine(texto);

            } while (texto != "fin");
        }

        // Leyendo binarios

        FileStream archivo = File.OpenRead(nombreArchivo);
        for (int i = 0; i < archivo.Length; i++)
        {
            byte unDato = (byte)archivo.ReadByte();
            if (unDato == 10 || unDato == 13 || unDato == 255)
            {
                Console.WriteLine();

            }
            else
            {
                System.Console.Write(unDato);
            }
        }

        archivo.Close();


    }
}