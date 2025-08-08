/*
Los ficheros de texto son habituales, pero es aún más frecuente encontrarnos con
ficheros en los que la información está estructurada como una secuencia de bytes,
más o menos ordenada. Esto ocurre en las imágenes, los ficheros de sonido, de
video, etc.

Vamos a ver cómo leer de un fichero "general", y lo aplicaremos a descifrar la
información almacenada en ciertos formatos habituales, como una imagen BMP o
un fichero de sonido MP3.

Como primer acercamiento, vamos a ver cómo abrir un fichero (no
necesariamente de texto) y leer el primer byte que contiene. Comenzaremos por
utilizar la clase "FileStream", diseñada para acceder a un byte o a bloques de bytes.
Esta clase tiene un método ReadByte, que devuelve un entero con valor -1 en caso
de error, o un dato que podríamos convertir a byte si la lectura ha sido correcta,
así:
*/

/*
Los otros modos de apertura posibles (cuyos nombre en inglés son casi
autoexplicativos) son: 
- Append (añade al final o crea si no existe), Create (crea el fichero o lo sobreescribe si ya existía)
- CreateNew (crea si no existía, o falla si existe)
- Open (abre si existe o falla si no existe)
- OpenOrCreate (abre si existe o lo crea si no existe)
- Truncate (abre un fichero que debe existir y lo vacía).

Si quisiéramos leer un segundo dato, volveríamos a llamar a ReadByte, porque
tras cada lectura, avanza la posición actual dentro del fichero.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        FileStream fichero;
        string nombre;
        byte unDato;
        string linea;

        System.Console.WriteLine("Nombre del fichero");
        nombre = Console.ReadLine();

        try
        {
            fichero = File.OpenRead(nombre);
            unDato = (byte)fichero.ReadByte();
            System.Console.WriteLine("El byte leído es {0}", unDato);
            fichero.Close();

        }
        catch (System.Exception e)
        {

            System.Console.WriteLine("Error" + e.Message);
            return;
        }

        // ----------------- leer fichero hasta el final -----------------

        StreamReader LeerFichero;
        LeerFichero = File.OpenText(nombre);
        do
        {
            linea = LeerFichero.ReadLine();
            if (linea != null)
                System.Console.WriteLine(linea);

        } while (linea != null);
        LeerFichero.Close();

    }
}