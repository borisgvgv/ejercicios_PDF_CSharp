using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Ruta de la carpeta
        string carpeta = @"/workspaces/ejercicios_PDF_CSharp/8.4_AñadirAUnFicheroExistente_ConClases";
        // Extensión que queremos buscar
        string extension = "*.txt";

        // Obtener los archivos con esa extensión y convertirlos en lista
        List<string> lista = new List<string>(Directory.GetFiles(carpeta, extension).OrderBy(f => Path.GetFileName(f)).ToArray());

        // Mostrar cada archivo en la consola
        foreach (string file in lista)
        {
            //Console.WriteLine(file); // muestra el direcctorio y el nombre del archivo
            Console.WriteLine(Path.GetFileName(file)); // Muestra solo el nombre del archivo .txt

            /*
            Otras variantes útiles:
            Path.GetExtension(path) → Obtiene la extensión (por ejemplo, .txt)
            Path.GetFileNameWithoutExtension(path) → Nombre sin la extensión (ejemplo en vez de ejemplo.txt)
            Path.GetDirectoryName(path) → Obtiene solo la carpeta de la ruta
            */
        }
    }
}
