/*
(8.3.1) Crea una variante del ejemplo 08_03a, empleando un constructor en vez de
"File.OpenText".
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        GestionFichero gestionFichero = new GestionFichero();

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

                using (StreamWriter crearfichero = new StreamWriter("fichero.txt"))
                {
                    System.Console.Write("Escribe un texto: ");
                    texto = Console.ReadLine();
                    if (texto != "fin" && texto != "")
                        crearfichero.WriteLine(texto);
                }
            }
            else
            {
               using (StreamWriter crearfichero = new StreamWriter("fichero.txt", true))
                {
                    System.Console.Write("Escribe un texto: ");
                    texto = Console.ReadLine();
                    if (texto != "fin" && texto != "")
                        crearfichero.WriteLine(texto);
                }
            }


        } while (texto != "fin");
    }
}


public class AddFichero
{
    protected string texto;
    public AddFichero()
    {
        using (StreamWriter addfichero = new StreamWriter("fichero.txt", true))
        {
            do
            {
                System.Console.Write("Escribe un texto: ");
                texto = Console.ReadLine();
                if (texto != "fin" && texto != "")
                    addfichero.WriteLine(texto);

            } while (texto != "fin");
        }
    }
}



public class LeerFichero
{
    protected string linea;
    public LeerFichero()
    {
        using (StreamReader leerFichero = new StreamReader("fichero.txt"))
        {
            do
            {
                linea = leerFichero.ReadLine();
                System.Console.WriteLine(linea);

            } while (linea != null);

        }
    }
}


public class GestionFichero
{
    protected byte opcion;
    bool salir = false;
    public GestionFichero()
    {
        do
        {
            System.Console.WriteLine("MENÚ");
            System.Console.WriteLine("1- Ver fichero existente");
            System.Console.WriteLine("2- Crear nuevo fichero");
            System.Console.WriteLine("3- Añadir datos al fichero");
            System.Console.WriteLine("0- Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {

                case 1:
                    System.Console.WriteLine("1- Ver fichero existente");

                    if (File.Exists("fichero.txt"))
                    {
                        LeerFichero leerFichero = new LeerFichero();
                    }
                    else
                    {
                        System.Console.WriteLine("No hay fichero creado");
                    }
                    break;

                case 2:
                    System.Console.WriteLine("2- Crear nuevo fichero");
                    CrearFichero crearFichero = new CrearFichero();
                    Console.Clear();
                    break;

                case 3:
                    System.Console.WriteLine("3- Añadir datos al fichero");
                    AddFichero addFichero = new AddFichero();
                    break;

                case 0:
                    salir = true;
                    break;

                default:
                    break;
            }

        } while (!salir);

    }
}

