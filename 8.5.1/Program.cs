/*
(8.5.1) Crea un programa que pida al usuario pares de números enteros y escriba
su suma (con el formato "20 + 3 = 23") en pantalla y en un fichero llamado
"sumas.txt", que se encontrará en un subdirectorio llamado "resultados". Cada vez
Introducción a la programación con C#, por Nacho Cabanes
Revisión 0.99zz – Página 249
que se ejecute el programa, deberá añadir los nuevos resultados a continuación
de los resultados de las ejecuciones anteriores.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Gestion gestionDeArchivo = new Gestion();

    }
}

public class Suma
{
    protected int n1;
    protected int n2;
    protected int resultado;
    public Suma()
    {
        System.Console.Write("Añade un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Añade otro número: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        resultado = n1 + n2;
        System.Console.WriteLine($"{n1} + {n2} = {resultado}");

        using (StreamWriter archivo = new StreamWriter("archivo.txt", true))
        {
            archivo.WriteLine($"{n1} + {n2} = {resultado}");
        }
    }
}

public class LeerArchivo
{
    protected string linea;
    protected string directorio = @"/workspaces/ejercicios_PDF_CSharp/8.5.1";
    protected string extension = "*.txt";
    protected string buscado;

    public LeerArchivo()
    {
        if (Directory.Exists(directorio))
        {
            System.Console.WriteLine("El directorio existe");
            string[] archivotxt = Directory.GetFiles(directorio, extension);

            foreach (string archivo in archivotxt)
            {
                if (Path.GetFileName(archivo) == "archivo.txt")
                {
                    buscado = Path.GetFileName(archivo);
                }
            }

            using (StreamReader leerArchivo = new StreamReader(buscado))
            {
                do
                {
                    linea = leerArchivo.ReadLine();
                    if (linea != null)
                        System.Console.WriteLine(linea);

                } while (linea != null);
            }

        }
        else
        {
            System.Console.WriteLine("El directorio no existe");
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
            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1- Añadir Operación");
            System.Console.WriteLine("2- Mostrar todas las operaciones ");
            System.Console.WriteLine("0- Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("1- Añadir Operación");
                    Suma suma = new Suma();
                    break;
                case 2:
                    System.Console.WriteLine("2- Mostrar todas las operaciones ");
                    LeerArchivo leerArchivo = new LeerArchivo();
                    break;
                case 0:
                    salir = true;
                    break;
                default:
                    System.Console.WriteLine("Opción errónea");
                    break;
            }


        } while (!salir);
    }
}

