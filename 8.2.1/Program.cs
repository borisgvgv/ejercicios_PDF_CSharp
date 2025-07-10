/*
(8.2.1) Crea un programa que lea las tres primeras líneas del fichero creado en el
ejercicio 8.1.1 y las muestre en pantalla. Usa OpenText para abrirlo.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        LeerFichero leerFichero = new LeerFichero();
    }
}

public class CrearFichero
{
    protected string texto;

    public CrearFichero()
    {
        do
        {
            if (texto == null)
            {
                using (StreamWriter fichero = new StreamWriter("fichero.txt"))
                {
                    System.Console.Write("Escribe un texto: ");
                    texto = Console.ReadLine();
                    fichero.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter fichero = new StreamWriter("fichero.txt", true))
                {
                    System.Console.Write("Añade un texto: ");
                    texto = Console.ReadLine();
                    fichero.WriteLine(texto);
                }
            }

        } while (texto != "fin");
    }
}

public class LeerFichero
{

    public LeerFichero()
    {
        CrearFichero fichero = new CrearFichero();

        StreamReader ficha;
        string linea;

        ficha = File.OpenText("fichero.txt");

        do
        {
            linea = ficha.ReadLine();
            System.Console.WriteLine(linea);
            if (linea != null)
            {
                System.Console.WriteLine(ficha.ReadLine());

            }

        } while (linea != null);


        System.Console.WriteLine();//Salto de línea
        System.Console.WriteLine("Ahora leemos solo las tres primeras líneas del archhivo como pide el ejercicio");

        ficha = File.OpenText("fichero.txt");

       
        for (int i = 0; i < 3; i++)
        {
            linea = ficha.ReadLine();
            if (linea != null)
                System.Console.WriteLine(linea);
        }
        ficha.Close();



    }
}




