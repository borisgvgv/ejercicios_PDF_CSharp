/*
(8.3.6) Crea un programa que pida al usuario el nombre de un fichero de texto y
una frase a buscar, y que muestre en pantalla todas las líneas de ese fichero que
contengan esa frase. Cada frase se debe preceder del número de línea (la primera
línea del fichero será la 1, la segunda será la 2, y así sucesivamente).
*/

using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        Console.Clear();
        GestionFicha gestionFicha = new GestionFicha();

    }
}

public class CrearFicha
{
    protected string nombreFicha;
    protected string texto;
    public CrearFicha()
    {
        System.Console.WriteLine("Nombre de la ficha");
        nombreFicha = Console.ReadLine();
        nombreFicha = nombreFicha.ToLower() + ".txt";

        if (File.Exists(nombreFicha))
        {
            System.Console.WriteLine(nombreFicha + " ya existe.");
            using (StreamWriter ficha = new StreamWriter(nombreFicha, true))
            {
                do
                {
                    System.Console.Write("Añade un texto: ");
                    texto = Console.ReadLine();
                    if (texto != "fin")
                        ficha.WriteLine(texto);

                } while (texto != "fin");

            }
        }
        else
        {
            using (StreamWriter ficha = new StreamWriter(nombreFicha))
            {
                do
                {
                    System.Console.Write("Escribe un texto: ");
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
    protected string texto;
    protected int lineasPorBloque = 5;
    protected int palabrasPorLinea = 8;
    protected int palabrasPorBloque;
    protected ConsoleKeyInfo key;
    



    public LeerFicha()
    {
        palabrasPorBloque = lineasPorBloque * palabrasPorLinea;

        System.Console.Write("Nombre de la ficha que quieres ver: ");
        nombreFicha = Console.ReadLine();
        nombreFicha = nombreFicha.ToLower() + ".txt";
        System.Console.WriteLine();

        if (File.Exists(nombreFicha))
        {
            using (StreamReader leerFicha = new StreamReader(nombreFicha))
            {

                texto = leerFicha.ReadLine();

                if (texto != null)
                {
                    /*creamos lista de palabras y utilizamos texto.Split(' ', StringSplitOption.RemoveEmtyEntries) 
                     (Opciones de división de cadena Eliminar entradas vacías) para separar las palabras del texto*/
                     
                    List<string> palabras = new List<string>(texto.Split(' ', StringSplitOptions.RemoveEmptyEntries)); 

                    for (int i = 0; i < palabras.Count; i += palabrasPorBloque)
                    {
                        // Mostrar 5 líneas de 8 palabras
                        for (int j = i; j < i + palabrasPorBloque && j < palabras.Count; j += palabrasPorLinea)
                        {
                            List<string> linea = palabras.GetRange(j, Math.Min(palabrasPorLinea, palabras.Count - j));
                            
                            Console.WriteLine(string.Join(" ", linea));
                        }

                        // Esperar que el usuario presione Enter antes de continuar, si hay más palabras
                        if (i + palabrasPorBloque < palabras.Count)
                        {
                            Console.WriteLine("\nPresiona Enter para continuar...");
                            Console.ReadLine();
                        }
                    }

                    Console.WriteLine("\nFin del texto.");
                }
            }
        }
        else
        {
            System.Console.WriteLine("Esta ficha no existe");
        }

    }
}

public class GestionFicha
{
    protected bool salir = false;
    protected byte opcion;
    public GestionFicha()
    {
        do
        {


            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1- Crear ficha");
            System.Console.WriteLine("2- Leer ficha");
            System.Console.WriteLine("0- Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("1- Crear ficha");
                    CrearFicha crearFicha = new CrearFicha();
                    break;
                case 2:
                    System.Console.WriteLine("2- Leer ficha");
                    LeerFicha leerFicha = new LeerFicha();
                    break;
                case 0:
                    salir = true;
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta.");
                    break;
            }
        } while (!salir);

    }
}
