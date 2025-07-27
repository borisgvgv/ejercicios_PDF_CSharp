/*
El uso de "File.Exists" nos permite saber si el fichero existe, pero ese no es el único
problema que podemos tener al acceder a un fichero. Puede ocurrir que no
tengamos permiso para acceder al fichero, a pesar de que exista, o que
intentemos escribir en un dispositivo que sea sólo de lectura (como un CD-ROM,
por ejemplo).
Por ello, una forma más eficaz de comprobar si ha existido algún tipo de error es
comprobar las posibles "excepciones", con las que ya tuvimos un contacto al final
del tema 2.
Típicamente, los pasos que puedan ser problemáticos irán dentro del bloque "try"
y los mensajes de error y/o acciones correctoras estarán en el bloque "catch". Así,
un primer ejemplo, que mostrara todo el contenido de un fichero de texto y que
en caso de error se limitara a mostrar un mensaje de error y a abandonar el
programa, podría ser:
*/

/*
El resultado, si ese fichero no existe, sería algo como
Introduzca el nombre del fichero
prueba
Ha habido un error: No se pudo encontrar el archivo
'C:\Fuentes\nacho\prueba'.
*/

// Ejemplo_08_07a.cs
// Excepciones y ficheros (1)
// Introducción a C#, por Nacho Cabanes
using System;
using System.IO;
public class Ejemplo_08_07a
{
    public static void Main()
    {
        StreamReader fichero;
        string nombre;
        string linea;
        Console.WriteLine("Introduzca el nombre del fichero");
        nombre = Console.ReadLine();
        try
        {

            fichero = File.OpenText(nombre);
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            }
            while (linea != null);

            fichero.Close();
        }
        catch (Exception exp)
        {
            Console.WriteLine("Ha habido un error: {0}", exp.Message);
            return;
        }
    }
}

