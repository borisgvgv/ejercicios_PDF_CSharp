/*
(8.3.3) Prepara un programa que pregunte un nombre de fichero y muestre en
pantalla el contenido de ese fichero, haciendo una pausa después de cada 24
líneas, para que dé tiempo a leerlo. Cuando el usuario pulse la tecla Intro, se
mostrarán las siguientes 24 líneas, y así sucesivamente hasta que termine el
fichero.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        GestionDeArchivo gestionDeArchivo = new GestionDeArchivo();
    }
}

public class CreaFicha
{
    protected string nombreicha = null;
    protected string texto;
    public CreaFicha()
    {
        Console.Write("Nombre de la ficha: ");
        nombreicha = Console.ReadLine();
        nombreicha = nombreicha + ".txt";

        if (nombreicha != null && File.Exists(nombreicha))
        {
            System.Console.WriteLine($"la ficha {nombreicha} ya existe");
            using (StreamWriter ficha = new StreamWriter(nombreicha, true))
            {
                do
                {
                    System.Console.WriteLine("Añade algún texto o escribe fin para salir");
                    texto = Console.ReadLine();
                    if (texto != "fin")
                        ficha.WriteLine(texto);

                } while (texto != "fin");
            }

        }
        else
        {
            using (StreamWriter ficha = new StreamWriter(nombreicha))
            {
                do
                {
                    System.Console.WriteLine("Escribe algún texto");
                    texto = Console.ReadLine();
                    if (texto != "fin")
                        ficha.WriteLine(texto);

                } while (texto != "fin");
            }

        }
    }
}

public class LeerFicha
{
    protected string nombreFicha;
    protected string linea;
    protected int contadorLinea = 0;
    protected ConsoleKeyInfo keyInfo;

    public LeerFicha()
    {
        System.Console.WriteLine("Nombre de la ficha: ");
        nombreFicha = Console.ReadLine();
        nombreFicha = nombreFicha + ".txt";



        using (StreamReader leerFicha = new StreamReader(nombreFicha))
        {
            if (File.Exists(nombreFicha))
            {
                do
                {
                    linea = leerFicha.ReadLine();
                    if (linea != null)
                        System.Console.WriteLine(linea);
                    contadorLinea++;

                    if (contadorLinea == 24)
                    {
                        System.Console.WriteLine("Pulsa Enter para continuar leyendo");
                        keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            contadorLinea = 0;
                        }
                    }


                } while (linea != null && contadorLinea < 24);

            }
            else
            {
                System.Console.WriteLine("El archivo no existe");
            }
        }
    }
}

public class GestionDeArchivo
{
    protected byte opcion;
    protected bool salir = false;
    public GestionDeArchivo()
    {
        do
        {
            System.Console.WriteLine("MENÚ");
            System.Console.WriteLine("1- Crear ficha");
            System.Console.WriteLine("2- Leer Ficha");
            System.Console.WriteLine("0- Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("1- Crear ficha");
                    CreaFicha creaFicha = new CreaFicha();

                    break;
                case 2:
                    System.Console.WriteLine("2- Leer Ficha");
                    LeerFicha leerFicha = new LeerFicha();

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
