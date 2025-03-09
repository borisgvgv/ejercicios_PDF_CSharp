using System;

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
    private const int maxDatos = 10; // Tamaño máximo del array
    private AddDatos[] datosArray = new AddDatos[maxDatos]; // Array para almacenar los datos
    private int indice = 0; // Contador para saber cuántos datos hay en el array

    public GestionBd()
    {
        bool salir = false;

        do
        {
            menu.MostrarMenu();

            switch (menu.GetOpcion())
            {
                case 1:
                    if (indice < maxDatos)
                    {
                        Console.WriteLine("\nAñadir datos");
                        AddDatos addDatos = new AddDatos();
                        addDatos.PedirDatos();
                        datosArray[indice] = addDatos; // Guardamos los datos en el array
                        indice++;
                    }
                    else
                    {
                        Console.WriteLine("El almacenamiento está lleno. No se pueden agregar más datos.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\nMostrar datos");

                    if (indice == 0)
                    {
                        Console.WriteLine("No hay datos para mostrar.");
                    }
                    else
                    {
                        MostrarDatos mostrarDatos = new MostrarDatos();
                        for (int i = 0; i < indice; i++)
                        {
                            mostrarDatos.Mostrar(datosArray[i].GetNombre(), datosArray[i].GetEdad());
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
    private string nombre;
    private int edad;

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
