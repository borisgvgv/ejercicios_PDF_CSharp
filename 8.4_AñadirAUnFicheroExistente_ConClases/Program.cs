using System;
using System.IO;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Console.Clear();
        GestionDeArchivos gestionDeArchivos = new GestionDeArchivos();
    }
}

public class CrearArchivo
{
    protected string texto;
    protected string nombreArchivo;

    public CrearArchivo()
    {
        System.Console.Write("Nombre del archivo: ");
        nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        if (File.Exists(nombreArchivo))
        {
            System.Console.WriteLine("Este archivo ya existe");
        }
        else
        {
            using (StreamWriter archivo = new StreamWriter(nombreArchivo))
            {
                do
                {
                    System.Console.WriteLine("Texto: ");
                    texto = Console.ReadLine();

                    if (texto != "fin")
                        archivo.WriteLine(texto);
                } while (texto != "fin");
            }
        }
    }
}

public class ListaArchivos
{

    public ListaArchivos()
    {
        string carpeta = @"/workspaces/ejercicios_PDF_CSharp/8.4_AñadirAUnFicheroExistente_ConClases";
        string extension = "*.txt";
       

        if (Directory.Exists(carpeta))
        {
           string[] archivos = Directory.GetFiles(carpeta, extension). OrderBy(f => Path.GetFileName(f)).ToArray();

            if (archivos.Length > 0)
            {
                Console.WriteLine("Existen archivos .txt en la carpeta.");
                foreach (string archivo in archivos)
                {
                    Console.WriteLine(Path.GetFileName(archivo)); // Solo el nombre del archivo
                    //Console.WriteLine(archivo); // O la ruta completa
                }

            }
            else
            {
                Console.WriteLine("No hay archivos .txt en la carpeta.");
            }
        }
        else
        {
            Console.WriteLine("La carpeta no existe.");
        }

    }
}

public class AddAArchivo
{
    protected string texto;
    protected string nombreArchivo;
    public AddAArchivo()
    {
        System.Console.Write("Nombre del archivo: ");
        nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        if (File.Exists(nombreArchivo))
        {
            using (StreamWriter archivo = new StreamWriter(nombreArchivo, true))
            {
                do
                {
                    System.Console.WriteLine("Texto: ");
                    texto = Console.ReadLine();

                    if (texto != "fin")
                        archivo.WriteLine(texto);
                } while (texto != "fin");
            }
        }
        else
        {
            System.Console.WriteLine("Este archivo no ha sido creado");
        }

    }
}

public class LeerArchivo
{
    protected string nombreArchivo;
    protected string linea;
    public LeerArchivo()
    {
        System.Console.Write("Nombre del archivo: ");
        nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        using (StreamReader leerFichero = new StreamReader(nombreArchivo))
        {
            do
            {
                linea = leerFichero.ReadLine();
                if (linea != null)
                    System.Console.WriteLine(linea);

            } while (linea != null);
        }
    }
}



public class GestionDeArchivos
{
    protected byte opcion;
    protected bool salir = false;
    public GestionDeArchivos()
    {
        do
        {
            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1- Crear nuevo archivo");
            System.Console.WriteLine("2- Añadir texto a archivo existente");
            System.Console.WriteLine("3- Leer archivo");
            System.Console.WriteLine("4- Mostrar listado de archivos");
            System.Console.WriteLine("0- Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("1- Crear nuevo archivo");
                    CrearArchivo archivo = new CrearArchivo();
                    break;
                case 2:
                    System.Console.WriteLine("2- Añadir texto a archivo existente");
                    AddAArchivo addAArchivo = new AddAArchivo();
                    break;
                case 3:
                    System.Console.WriteLine("3- Leer archivo");
                    LeerArchivo leerArchivo = new LeerArchivo();
                    break;
                case 4:
                    ListaArchivos listaArchivos = new ListaArchivos();
                    break;
                case 0:
                    salir = true;
                    break;
                default:
                    System.Console.WriteLine("Opción Incorrecta");
                    break;
            }

        } while (!salir);

    }
}