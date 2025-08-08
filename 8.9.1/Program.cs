/*
(8.9.1) Abre un fichero con extensión EXE (cuyo nombre introducirá el usuario) y
comprueba si realmente se trata de un ejecutable, mirando si los dos primeros
bytes del fichero son un 77 (que corresponde a una letra "M", según el estándar
que marca el código ASCII) y un 90 (una letra "Z"), respectivamente.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {

        Console.Clear();
        Console.WriteLine("Creando archivo .exe");
        Console.WriteLine("Nombre del archivo");
        string nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".exe";

        //creamos archivo
        using (StreamWriter archivo = new StreamWriter(nombreArchivo))
        {
            Console.WriteLine("Escribe en el archivo");
            string texto;
            do
            {
                do
                {
                    texto = Console.ReadLine();
                    if (texto != "fin" && texto != "")
                        archivo.WriteLine(texto);

                } while (texto != "fin" || texto == "");

            } while (texto != "fin");
        }

        //Leemos Archivo
        using (StreamReader leerArchivo = new StreamReader(nombreArchivo))
        {
            string linea;
            do
            {
                linea = leerArchivo.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            } while (linea != null);
        }

        /*
                byte dato;
                using (FileStream leerBinario = new FileStream(nombreArchivo, FileMode.Open))
                {
                    dato = (byte)leerBinario.ReadByte();
                    System.Console.WriteLine("El primer dato es {0}", dato);
                }
        


        int cantidad = 0;
        string linea2;
        string[] lineas = new string[1000000];
        byte[] dato = new byte[1000000];

        using (StreamReader leerArchivoBinario = new StreamReader(nombreArchivo))
        {

            do
            {

                linea2 = leerArchivoBinario.ReadLine();
                if (linea2 != null && cantidad < 1000000)
                {
                    lineas[cantidad] = leerArchivoBinario.ReadLine();
                    cantidad++;
                }

            } while (linea2 != null);
        }

*/

        using (FileStream leerbinario = new FileStream(nombreArchivo, FileMode.Open))
        {
            int cantidad = 0;
            string lineas;
            string[] arrayLineas = new string[1000000];

            StreamReader leer;
            leer.OpenText(nombreArchivo)
            do
            {
                lineasPuras = leer.ReadLine();
                if (lineas != null)
                    arrayLineas[cantidad] = lineas;
                cantidad++;

            } while (lineas != null);


            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < arrayLineas[i].Length; j++)
                {
                    dato[j] = (byte)leerbinario.ReadByte();
                    System.Console.Write(dato[j]);
                }
                System.Console.WriteLine();
            }

        }

    }
}

