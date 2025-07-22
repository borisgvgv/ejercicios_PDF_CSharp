using System;
using System.IO;


public class Program
{
    public static async Task Main()
    {
        Console.Clear();

        //Utilizar using System.IO para poder trabajar con directorios y archivos
        string directorio = @"/workspaces/ejercicios_PDF_CSharp/8.4_AñadirAUnFicheroExistente_ConClases";
        string extension = "*.txt";


        if (Directory.Exists(directorio))
        {
            System.Console.WriteLine("Directorio Encontrado.");

            //OrderBy(f => Path.GetFileName(f)).ToArray() --- Ordena alfabeticamente el array.
            string[] archivosTxtEncontrados = Directory.GetFiles(directorio, extension).OrderBy(f => Path.GetFileName(f)).ToArray();

            //Obtenemos ruta completa del archívo
            foreach (string archivo in archivosTxtEncontrados)
            {
                System.Console.WriteLine(archivo);
            }

            System.Console.WriteLine();
            //Obtenemos solo el nombre archívo
            foreach (string archivo in archivosTxtEncontrados)
            {
                System.Console.WriteLine(Path.GetFileName(archivo));

            /*
            Otras variantes útiles:
            Path.GetExtension(path) → Obtiene la extensión (por ejemplo, .txt)
            Path.GetFileNameWithoutExtension(path) → Nombre sin la extensión (ejemplo en vez de ejemplo.txt)
            Path.GetDirectoryName(path) → Obtiene solo la carpeta de la ruta
            */
            }

        }
        else
        {
            System.Console.WriteLine("Directorio no encontrado.");
        }

    }
}