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

       

        using (FileStream leerbinario = new FileStream(nombreArchivo, FileMode.Open))
        {
            int cantidad = 0;
            byte[] dato = new byte[1000000];
            string lineas;
            string[] arrayLineas = new string[1000000];

            using (StreamReader leer = new StreamReader(nombreArchivo))
            {
                do
                {
                    lineas = leer.ReadLine();
                    if (lineas != null && dato[cantidad] != 10)
                        arrayLineas[cantidad] = lineas;
                    cantidad++;

                } while (lineas != null);

            }


            for (int i = 0; i < cantidad; i++)
            {
                if (arrayLineas[i] == null)
                    continue;
                for (int j = 0; j <= arrayLineas[i].Length; j++)
                {
                    dato[j] = (byte)leerbinario.ReadByte();
                    if (dato[j] != 10)
                        System.Console.Write(dato[j]);
                }
                System.Console.WriteLine();
            }

        }

    }
}

