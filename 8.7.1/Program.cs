/*
(8.7.1) Un programa que pida al usuario el nombre de un fichero de origen y el de
un fichero de destino, y que vuelque al segundo fichero el contenido del primero,
convertido a mayúsculas. Se debe controlar los posibles errores, como que el
fichero de origen no exista, o que el fichero de destino no se pueda crear.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Gestion gestionArchivo = new Gestion();

    }
}

public class CrearArchivo
{
    public CrearArchivo()
    {
        Console.Write("Nombre del archivo: ");
        string nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        if (File.Exists(nombreArchivo))
        {
            try
            {
                Console.WriteLine("Este Archivo ya existe");
                Console.WriteLine("Añade contenido al archivo o escribe \"fin\" para salir");
                string texto;
                do
                {
                    using (StreamWriter archivo = new StreamWriter(nombreArchivo, true))
                    {

                        texto = Console.ReadLine();
                        if (texto != "fin")
                            archivo.WriteLine(texto);
                    }

                } while (texto != "fin");

            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Nombre demasiado largo!");
            }
            catch (IOException e)
            {
                Console.WriteLine("No se ha podido escribir!");
                Console.WriteLine("El error exacto es: {0}", e.Message);
            }

        }
        else
        {
            try
            {

                using (StreamWriter archivo = new StreamWriter(nombreArchivo))
                {
                    string texto;
                    do
                    {
                        texto = Console.ReadLine();
                        if (texto != "fin")
                            archivo.WriteLine(texto);

                    } while (texto != "fin");

                }

            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Nombre demasiado largo!");
            }
            catch (IOException e)
            {
                Console.WriteLine("No se ha podido escribir!");
                Console.WriteLine("El error exacto es: {0}", e.Message);
            }

        }
    }
}

public class LeerArchivo
{
    protected string linea;

    public LeerArchivo()
    {
        Console.Write("Nombre del Archivo: ");
        string nombreArchivo = Console.ReadLine();
        nombreArchivo = nombreArchivo.ToLower() + ".txt";

        using (StreamReader leerArchivo = new StreamReader(nombreArchivo))
        {
            do
            {
                linea = leerArchivo.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);

            } while (linea != null);
        }

    }
}

public class TransferirMinusculas
{
    protected string linea;
    protected string[] lineas = new string[1000000];
    protected int cantidad = 0;
    protected string lineaDestino;
    protected string archivoOrigen;
    protected string archivoDestino;
    protected bool existe = false;

    public TransferirMinusculas()
    {
        do
        {
            Console.Write("Archivo de origen: ");
            archivoOrigen = Console.ReadLine();
            archivoOrigen = archivoOrigen.ToLower() + ".txt";

            if (File.Exists(archivoOrigen))
            {
                existe = true;
                Console.Write("Archivo de destino: ");
                archivoDestino = Console.ReadLine();
                archivoDestino = archivoDestino.ToLower() + ".txt";
            }
            else
            {
                Console.WriteLine("Este archivo no esxiste");
                Console.WriteLine("Debes elejir un archivo existente");
            }

        } while (!existe);

        using (StreamReader leerArchivo = new StreamReader(archivoOrigen))
        {
            do
            {
                linea = leerArchivo.ReadLine();
                if (linea != null)
                {
                    lineas[cantidad] = linea.ToLower();
                    cantidad++;
                }
            } while (linea != null);

            using (StreamWriter transferirArchivo = new StreamWriter(archivoDestino))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    lineaDestino = lineas[i];
                    transferirArchivo.WriteLine(lineaDestino);
                }
            }
        }
    }
}

public class TransferirMayusculas
{
    protected string linea;
    protected string[] lineas = new string[1000000];
    protected int cantidad = 0;
    protected string lineaDestino;
    protected string archivoOrigen;
    protected string archivoDestino;
    protected bool existe = false;

    public TransferirMayusculas()
    {
        do
        {
            Console.Write("Archivo de origen: ");
            archivoOrigen = Console.ReadLine();
            archivoOrigen = archivoOrigen.ToLower() + ".txt";

            if (File.Exists(archivoOrigen))
            {
                existe = true;
                Console.Write("Archivo de destino: ");
                archivoDestino = Console.ReadLine();
                archivoDestino = archivoDestino.ToLower() + ".txt";
            }
            else
            {
                Console.WriteLine("Este archivo no esxiste");
                Console.WriteLine("Debes elejir un archivo existente");
            }

        } while (!existe);

        using (StreamReader leerArchivo = new StreamReader(archivoOrigen))
        {
            do
            {
                linea = leerArchivo.ReadLine();
                if (linea != null)
                {
                    lineas[cantidad] = linea.ToUpper();
                    cantidad++;
                }
            } while (linea != null);

            using (StreamWriter transferirArchivo = new StreamWriter(archivoDestino))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    lineaDestino = lineas[i];
                    transferirArchivo.WriteLine(lineaDestino);
                }
            }
        }
    }
}


public class TransferirArchivo
{
    protected bool salir = false;
    protected byte opcion;
    public TransferirArchivo()
    {
        do
        {
            System.Console.WriteLine("1- Transferir texto en minúsculas");
            System.Console.WriteLine("2- Transferir texto en mayúsculas");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    TransferirMinusculas transferirMinusculas = new TransferirMinusculas();
                    salir = true;
                    break;
                case 2:
                    TransferirMayusculas transferirMayusculas = new TransferirMayusculas();
                    salir = true;
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (!salir);

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
            Console.WriteLine("3- Transferir archivo");
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
                case 3:
                    Console.WriteLine("3- Transferir archivo");
                    TransferirArchivo transferirArchivo = new TransferirArchivo();
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