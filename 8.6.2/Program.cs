/*
(8.6.2) Mejora el ejemplo 08_06a para que no use "while (true)", sino una variable
booleana de control.
*/

// La forma en que lo resuelve aqui el ejercicio no me gusta en. En el siguiente ejemplo lo hago a mi manera

using System;
using System.IO;
public class Ejemplo_08_06a
{
    public static void Main()
    {
        StreamReader fichero;
        string nombre;
        bool fin = false;
        while (!fin) // Interrumpimos desde dentro con "break"
        {
            Console.Write("Nombre del fichero (\"fin\" para terminar)? ");
            nombre = Console.ReadLine();
            if (nombre == "fin")
                fin = true;
            if (File.Exists(nombre))
            {
                fichero = File.OpenText(nombre);
                Console.WriteLine("Su primera linea es: {0}",
                fichero.ReadLine());
                fichero.Close();
            }
            else
            {
                if (!fin)
                    Console.WriteLine("No existe!");

            }
        }
    }
}