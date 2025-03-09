using System;
//using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        GestionBd gestionBd = new GestionBd();
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
        Console.WriteLine("\nMenu");
        Console.WriteLine("1: Agregar datos");
        Console.WriteLine("2: Mostrar datos");
        Console.WriteLine("0: Salir");

        opcion = Convert.ToByte(Console.ReadLine());
    }
}

public class GestionBd
{
    private Menu menu = new Menu();
    private List<AddDatos> listaDatos = new List<AddDatos>(); // Lista para almacenar los datos

    public GestionBd()
    {
        bool salir = false;

        do
        {
            menu.MostrarMenu();

            switch (menu.GetOpcion())
            {
                case 1:
                    Console.WriteLine("\nAñadir datos");
                    AddDatos addDatos = new AddDatos();
                    addDatos.PedirDatos();
                    listaDatos.Add(addDatos); // Guardamos los datos en la lista
                    break;

                case 2:
                    Console.WriteLine("\nMostrar datos");

                    if (listaDatos.Count == 0)
                    {
                        Console.WriteLine("No hay datos para mostrar.");
                    }
                    else
                    {
                        MostrarDatos mostrarDatos = new MostrarDatos();
                        foreach (var datos in listaDatos)
                        {
                            mostrarDatos.Mostrar(datos.GetNombre(), datos.GetEdad());
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (!salir);

        Console.WriteLine("Fin del programa.");
    }
}

public class AddDatos
{
    protected string nombre;
    protected int edad;

    public string GetNombre()
    {
        return nombre;
    }

    public int GetEdad()
    {
        return edad;
    }

    public void PedirDatos()
    {
        Console.Write("Nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Edad: ");
        edad = Convert.ToInt32(Console.ReadLine());
    }
}

public class MostrarDatos
{
    public void Mostrar(string nombre, int edad)
    {
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
    }
}
