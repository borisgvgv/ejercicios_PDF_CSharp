// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string carpeta = @"/workspaces/ejercicios_PDF_CSharp/8.4_AñadirAUnFicheroExistente_ConClases";
        string extension = "*.txt";

        if (Directory.Exists(carpeta))
        {
            string[] archivos = Directory.GetFiles(carpeta, extension);

            if (archivos.Length > 0)
            {
                Console.WriteLine("Archivos .txt encontrados:");

                foreach (string archivo in archivos)
                {
                    Console.WriteLine(Path.GetFileName(archivo)); // Solo el nombre del archivo
                    // Console.WriteLine(archivo); // O la ruta completa
                }
            }
            else
            {
                Console.WriteLine("No se encontraron archivos .txt.");
            }
        }
        else
        {
            Console.WriteLine("La carpeta especificada no existe.");
        }


    }
}

