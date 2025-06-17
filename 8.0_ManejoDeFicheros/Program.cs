using System;
using System.IO;
/*

La línea using System.IO; en C# indica que el código está usando el espacio de nombres (namespace) System.IO, que contiene tipos para manejar entradas y salidas del sistema, especialmente archivos, directorios y flujos de datos (streams).
¿Qué permite hacer System.IO?

Al incluir using System.IO;, puedes trabajar directamente con clases como:

- File..............Operaciones con archivos (crear, leer, escribir, borrar, copiar, mover)
- FileInfo..........Información detallada sobre un archivo
- Directory.........Operaciones con directorios (crear, mover, enumerar)
- DirectoryInfo.....Información detallada sobre un directorio
- StreamReader......Leer texto desde archivos
- StreamWriter......Escribir texto en archivos
- FileStream........Leer/escribir datos binarios en archivos

*/

public class Pogram
{
    public static void Main()
    {
        StreamWriter fichero1; // en este caso ficgero es na variable d ela class StreamWriter del espacio de nombre using System.IO

        fichero1 = File.CreateText("prueba1.txt");
        fichero1.WriteLine("Hola esta es la primera línea de texto");
        fichero1.Write("Esta la segunda");
        fichero1.WriteLine("Esta la tercera");
        fichero1.Close();


        /*
        Una forma alternativa de crear el fichero es no usar "File.CreateText", sino un
        constructor que reciba el nombre de fichero, así:
        */

        StreamWriter fichero2 = new StreamWriter("prueba2.txt");
        fichero2.WriteLine("Hola esta es la primera línea de texto 2");
        fichero2.Write("Esta la segunda linea del texto2");
        fichero2.WriteLine("Esta la tercera línea del texto 2");
        fichero2.Close();

        /*
        Existe otra sintaxis, más compacta, que nos permite olvidarnos (hasta cierto
        punto) de cerrar el fichero, empleando la orden "using" para delimitar el bloque
        que lee datos del fichero, de esta forma:
        */

        using (StreamWriter fichero3 = new StreamWriter("prueba3.txt"))
        {
            fichero3.WriteLine("Hola esta es la primera línea de texto 2");
            fichero3.Write("Esta la segunda linea del texto2");
            fichero3.WriteLine("Esta la tercera línea del texto 2");
        }

    }

}