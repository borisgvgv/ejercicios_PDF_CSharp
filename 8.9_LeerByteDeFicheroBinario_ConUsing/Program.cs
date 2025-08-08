/*
Y también podemos emplear la sintaxis alternativa, con "using", de modo que no
sea necesario cerrar el fichero de forma explícita:
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

        string nombre;
        byte unDato;

        System.Console.WriteLine("Nombre del fichero");
        nombre = Console.ReadLine();

        try
        {
            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                unDato = (byte)fichero.ReadByte();
                System.Console.WriteLine("El dato leído es {0}", unDato);
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Error" + e.Message);
            return;
        }


    }
}