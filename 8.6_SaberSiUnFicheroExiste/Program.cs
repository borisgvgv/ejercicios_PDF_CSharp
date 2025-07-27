/*
Hasta ahora, estamos intentando abrir ficheros para lectura, pero sin comprobar
realmente si el fichero existe o no, lo que puede suponer que nuestro programa
falle en caso de que el fichero no se encuentre donde nosotros esperamos o de
que introduzcamos un nombre incorrecto.
Una primera solución es usar "File.Exists(nombre)", para comprobar si está, antes
de intentar abrirlo:
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {

        StreamReader fichero;
        string nombre;

        while (true)
        {
            Console.WriteLine("Nombre del fichero \"fin\" para terminar.");
            nombre = Console.ReadLine();

            if (nombre == "fin")
                break;
            if (File.Exists(nombre))
            {
                fichero = File.OpenText(nombre);
                fichero.ReadLine();
                fichero.Close();
            }
            else
            {
                Console.WriteLine("El fichero no existe");
            }
        }
    }
}

