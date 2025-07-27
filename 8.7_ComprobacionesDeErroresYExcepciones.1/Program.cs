/*
como ya vimos, generalmente lo razonable no es interceptar "todas las
excepciones a la vez", sino crear un análisis para cada caso, que permita
recuperarse del error y seguir adelante, para lo que se suelen crear varios bloques
"catch". Por ejemplo, en el caso de que queramos crear un fichero, podemos tener
excepciones como éstas:
 El fichero existe y es de sólo lectura (se lanzará una excepción del tipo
"IOException").
 La ruta del fichero es demasiado larga (excepción de tipo
"PathTooLongException").
 El disco puede estar lleno (IOException).
Así, dentro de cada bloque "catch" podríamos indicar una excepción más concreta
que una simple "Exception", de forma que el mensaje de aviso sea más concreto, o
que podamos dar pasos más adecuados para solucionar el problema:
*/

/*
Las excepciones más generales (IOException y, sobre todo, Exception) deberán ser
las últimas que analicemos, y las más específicas deberán ser las primeras.
Hay que recordar que, como la consola se comporta como un fichero de texto
(realmente, como un fichero de entrada y otro de salida), se puede usar
"try…catch" para comprobar ciertos errores relacionados con la entrada de datos,
como cuando no se puede convertir un dato a un cierto tipo (por ejemplo, si
queremos esperamos que introduzca un número, pero, en lugar de ello, tecleado
un texto).
*/

// Ejemplo_08_07b.cs
// Excepciones y ficheros (2)
// Introducción a C#, por Nacho Cabanes
using System;
using System.IO;
public class Ejemplo_08_07b
{
    public static void Main()
    {
        StreamWriter fichero;
        string nombre;
        string linea;

        Console.Write("Introduzca el nombre del fichero: ");
        nombre = Console.ReadLine();
        Console.Write("Introduzca la frase a guardar: ");
        linea = Console.ReadLine();
        try
        {
            fichero = File.CreateText(nombre);
            fichero.WriteLine(linea);
            fichero.Close();
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine("Nombre demasiado largo!");
        }
        catch (IOException e)
        {
            Console.WriteLine("No se ha podido escribir!");
            Console.WriteLine("El error exacto es: {0}", e.Message);
        }
    }
}