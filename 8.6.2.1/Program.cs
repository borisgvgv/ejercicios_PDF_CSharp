/*
(8.6.2) Mejora el ejemplo 08_06a para que no use "while (true)", sino una variable
booleana de control.
*/

using System;
using System.IO;
public class Ejemplo_08_06a
{
    public static void Main()
    {
        StreamReader fichero;
        string nombre;

        do  // Interrumpimos desde dentro con "break"
        {
            Console.Write("Nombre del fichero (\"fin\" para terminar)? ");
            nombre = Console.ReadLine();
            
            if (File.Exists(nombre))
            {
                fichero = File.OpenText(nombre);
                Console.WriteLine("Su primera linea es: {0}",
                fichero.ReadLine());
                fichero.Close();
            }
            else if (nombre != "fin")
            {
                    Console.WriteLine("No existe!");

            }
        } while (nombre != "fin");
    }
}