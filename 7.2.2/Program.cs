/*
(7.2.2) Amplía el proyecto Libro (ejercicio 6.7.2), de modo que permita guardar
hasta 1.000 libros. Main mostrará un menú que permita añadir un nuevo libro o
ver los datos de los ya existentes.
*/

using System;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        GestionDeArchivos gestionDeArchivos = new GestionDeArchivos();
    }
}

public class Menu
{
    protected byte opcion;

    public byte GetOpcion()
    {
        return opcion;
    }
    public void MostrarMenu()
    {
        System.Console.WriteLine("Menú");
        System.Console.WriteLine("1: AddLibro");
        System.Console.WriteLine("2: Mostrar libros");
        System.Console.WriteLine("0: Salir");
        System.Console.WriteLine();

        opcion = Convert.ToByte(Console.ReadLine());
    }
}

public class AddLibro
{
    protected string titulo;
    protected string autor;
    protected string nacionalidad;

    public string GetTitulo()
    {
        return titulo;
    }
    public string GetAutor()
    {
        return autor;
    }
    public string GetNacionalidad()
    {
        return nacionalidad;
    }
    public void PedirDatosDelLibro()
    {
        System.Console.Write("Título: ");
        titulo = Console.ReadLine();
        System.Console.Write("Autor: ");
        autor = Console.ReadLine();
        System.Console.Write("Nacionalidad: ");
        nacionalidad = Console.ReadLine();
        System.Console.WriteLine();
    }
}


public class GestionDeArchivos
{
    protected int cantidad = 0;
    protected const int capacidad = 3;
    protected bool salir = false;
    Menu menu = new Menu();
    protected AddLibro[] arrayLibros = new AddLibro[capacidad];

    public GestionDeArchivos()
    {
        do
        {
            menu.MostrarMenu();
            
            Console.Clear();

            switch (menu.GetOpcion())
            {
                case 1:
                    if (cantidad < capacidad)
                    {
                        AddLibro addLibro = new AddLibro();
                        addLibro.PedirDatosDelLibro();
                        arrayLibros[cantidad] = addLibro;
                        cantidad++;
                    }
                    else
                    {
                        System.Console.WriteLine("No es posible añadir más libros");
                    }
                    break;
                case 2:

                    MostrarLibro mostrarLibro = new MostrarLibro();
                    for (int i = 0; i < cantidad; i++)
                    {
                        mostrarLibro.Mostrar(arrayLibros[i].GetTitulo(), arrayLibros[i].GetAutor(), arrayLibros[i].GetNacionalidad());
                        System.Console.WriteLine();
                    }

                    break;

                case 0:
                    salir = true;
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (!salir);

    }
}

public class MostrarLibro
{
    public void Mostrar(string titulo, string autor, string nacionalidad)
    {
        System.Console.WriteLine("Título: {0}", titulo);
        System.Console.WriteLine("Autor: {0}", autor);

        if (nacionalidad != "")
        {

            System.Console.WriteLine("Nacionalidad: {0}", nacionalidad);
        }
        else
        {
            System.Console.WriteLine("Nacionalidad: Ciudadano del mundo");
        }
    }
}



