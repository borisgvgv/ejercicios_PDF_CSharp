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
        else
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

public class TransferirArchivo
{
    protected string linea;
    public TransferirArchivo()
    {
        Console.Write("Archivo de origen: ");
        string archivoOrigen = Console.ReadLine();
        archivoOrigen = archivoOrigen.ToLower() + ".txt";

        Console.Write("Archivo de destino: ");
        string archivoDestino = Console.ReadLine();
        archivoDestino = archivoDestino.ToLower() + ".txt";

        if (File.Exists(archivoOrigen))
        {
            using (StreamReader leerArchivo = new StreamReader(archivoOrigen))
            {
                do
                {
                    linea = leerArchivo.ReadLine();
                    if (linea != null)
                        linea = linea.ToUpper();

                    using (StreamWriter transferirArchivo = new StreamWriter(archivoDestino, true))
                    {
                        transferirArchivo.WriteLine(linea);
                    }
                } while (linea != null);
            }
        }
        else
        {
            Console.WriteLine("El archivo de origen indicado no existe");
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