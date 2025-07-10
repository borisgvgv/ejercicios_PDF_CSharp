/*
(8.1.3) Amplia el proyecto Libro (ejercicio 7.7.8), de modo que todos los datos se
vuelquen a un fichero de texto al terminar la ejecución del programa.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        GestionArchivo gestionArchivo = new GestionArchivo();
    }

}
public class CrearArchivo
{
    int contador = 0;
    public CrearArchivo(int contador)
    {
        this.contador = contador;

        if (contador == 0)
        {
            using (StreamWriter archivo = new StreamWriter("Archivo.txt"))
            {

                System.Console.Write("Titulo: ");
                string titulo = Console.ReadLine();
                System.Console.Write("Autor: ");
                string autor = Console.ReadLine();
                System.Console.Write("Año de lanzamiento: ");
                int anyo = Convert.ToInt32(Console.ReadLine());
                archivo.WriteLine($"Titulo: {titulo}, Autor: {autor}, Año de lanzamiento {anyo}");

            }
        }
        else
        {
            using (StreamWriter archivo = new StreamWriter("Archivo.txt", true))
            {

                System.Console.Write("Titulo: ");
                string titulo = Console.ReadLine();
                System.Console.Write("Autor: ");
                string autor = Console.ReadLine();
                System.Console.Write("Año de lanzamiento: ");
                int anyo = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine();//Salto de línea
                archivo.WriteLine($"Titulo: {titulo}, Autor: {autor}, Año de lanzamiento {anyo}");

            }
        }
    }
}

public class LeerArchivo
{
    protected string linea;
    public LeerArchivo()
    {
        using (StreamReader archivo = new StreamReader("Archivo.txt"))
        {
            do
            {
                linea = archivo.ReadLine();
                if (linea != null)
                    System.Console.WriteLine(linea);
                System.Console.WriteLine();

            } while (linea != null);
        }
    }
}
public class BuscarPorTitulo
{
    protected string linea;
    public BuscarPorTitulo()
    {
        System.Console.Write("Título: ");
        string buscarTitulo = Console.ReadLine();

        using (StreamReader archivo = new StreamReader("Archivo.txt"))
        {

            do
            {
                linea = archivo.ReadLine();
                if (linea != null)
                {
                    //Seccionamos la linea en palabras
                    string[] seccionLinea = linea.Split(' ');

                    seccionLinea[1] = seccionLinea[1].Substring(0, seccionLinea[1].Length - 1);

                    if (buscarTitulo == seccionLinea[1])
                        System.Console.WriteLine(linea);
                }


            } while (linea != null);
        }
    }
}

public class GestionArchivo
{
    bool salir = false;
    protected int contador = 0;

    public GestionArchivo()
    {

        do
        {
            System.Console.WriteLine("MENÚ");
            System.Console.WriteLine("1- Add Libro");
            System.Console.WriteLine("2- Mostrar todos los libros");
            System.Console.WriteLine("3- Buscar por título");
            System.Console.WriteLine("0- Salir");
            byte opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("1- Add Libro");

                    CrearArchivo archivo = new CrearArchivo(contador);
                    contador++;

                    break;

                case 2:
                    System.Console.WriteLine("2- Mostrar todos los libros");
                    LeerArchivo leerArchivo = new LeerArchivo();

                    break;
                case 3:
                    System.Console.WriteLine("3- Buscar por título");
                    BuscarPorTitulo buscarPorTitulo = new BuscarPorTitulo();

                    break;
                case 0:
                    salir = true;
                    break;

                default:
                    System.Console.WriteLine("Opcion errónea");
                    break;
            }

        } while (!salir);
    }
}

