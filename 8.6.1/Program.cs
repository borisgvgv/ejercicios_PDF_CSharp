/*
(8.3.4) Amplía la base de datos de ficheros (ejercicio 8.1.2), de modo que los datos
se lean desde fichero (si existe) en el momento de lanzar el programa (puedes usar
try-catch para que el programa no falle en el momento inicial, en el que quizá
todavía no existan datos en fichero; dentro de poco veremos formas alternativas
de saber si existe).
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Gestion gestionDeArchivos = new Gestion();
    }
}

public class CrearArchivo
{
    protected string texto;
    public CrearArchivo()
    {

        Console.Write("Nombre del Archivo:");
        string nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        do
        {
            if (File.Exists(nombreArchivo))
            {
                Console.WriteLine("Este archivo ya existe");
                using (StreamWriter archivo = new StreamWriter(nombreArchivo, true))
                {
                    Console.WriteLine("Añade un texto o escribe \"fin\" para terminar");
                    
                    texto = Console.ReadLine();
                    if (texto != "fin")
                        archivo.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(nombreArchivo, false))
                {
                    Console.WriteLine("Añade un texto o escribe \"fin\" para terminar");
                    texto = Console.ReadLine();
                    if (texto != "fin")
                        archivo.WriteLine(texto);
                }
            }

        } while (texto != "fin");
    }
}

public class LeerArchivo
{
    protected string linea;
    public LeerArchivo()
    {
        Console.Write("Nombre de archivo: ");
        string nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        if (File.Exists(nombreArchivo))
        {
            using (StreamReader leerArchivo = new StreamReader(nombreArchivo))
            {
                do
                {
                    linea = leerArchivo.ReadLine();
                    if (linea != null)
                    {
                        Console.WriteLine(linea);
                    }

                } while (linea != null);

            }
        }
        else
        {
            Console.WriteLine("Este archivo no existe");
        }

    }
}

public class Gestion
{
    protected bool salir = false;
    protected byte opcion;
    public Gestion()
    {
        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine("1- Crear archivo");
            Console.WriteLine("2- Leer archivo");
            Console.WriteLine("0- Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("1- Crear archivo");
                    CrearArchivo crearArchivo = new CrearArchivo();
                    break;
                case 2:
                    Console.WriteLine("2- Leer archivo");
                    LeerArchivo leerArchivo = new LeerArchivo();
                    break;
                case 0:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }


        } while (!salir);

    }
}

