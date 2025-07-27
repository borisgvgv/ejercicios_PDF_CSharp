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
        string nombre;

        do  // Interrumpimos desde dentro con "break"
        {
            Console.Write("Nombre del fichero (\"fin\" para terminar)? ");
            nombre = Console.ReadLine();
            if (nombre != "fin")
                nombre = nombre.ToLower() + ".txt";


            if (File.Exists(nombre))
            {
                using (StreamReader fichero = new StreamReader(nombre))
                {
                    string linea;
                    do
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                            Console.WriteLine(linea);

                    } while (linea != null);
                }
            }
            else if (nombre != "fin")
            {
                Console.WriteLine("No existe!");

            }

        } while (nombre != "fin");
    }
}