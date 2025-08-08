/*
Podemos usar también un constructor para acceder al fichero. Este constructor
recibirá dos parámetros: el nombre del fichero y el modo de apertura. Por ahora,
nos interesará un único modo, que será "FileMode.Open", que nos permite leer
datos desde un fichero que ya existe:
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
        Console.WriteLine("Introduzca el nombre del fichero");
        string nombre = Console.ReadLine();
        try
        {
            FileStream fichero = new FileStream(nombre, FileMode.Open);
            byte unDato = (byte)fichero.ReadByte();
            Console.WriteLine("El byte leido es un {0}", unDato);
            fichero.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            return;
        }
    }
}