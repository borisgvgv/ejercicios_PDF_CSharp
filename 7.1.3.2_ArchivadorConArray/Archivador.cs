using System;

public class Archivador
{
    public static void Main()
    {
        Console.Clear();

        GestionDeArchivo gestionDeArchivo = new GestionDeArchivo();
        System.Console.WriteLine("Fin");
    }
}

public class Menu
{
    protected byte opcion;
    public byte getOpcion()
    {
        return opcion;
    }
    public void MostrarMenu()
    {
        System.Console.WriteLine("Menu");
        System.Console.WriteLine("1: AddDatos");
        System.Console.WriteLine("2: Mostrar datos");
        System.Console.WriteLine("0: Salir");

        opcion = Convert.ToByte(Console.ReadLine());
        Console.Clear();

    }
}

public class GestionDeArchivo
{
    protected int cantidad = 0;
    protected const int capacidad = 10;
    protected AddDatos[] datosArray = new AddDatos[capacidad];

    protected bool salir = false;
    protected Menu menu = new Menu();

    public GestionDeArchivo()
    {
        do
        {
            menu.MostrarMenu();

            switch (menu.getOpcion())
            {
                case 1:
                    if (cantidad < capacidad)
                    {
                        AddDatos addDatos = new AddDatos();
                        addDatos.PedirDatos();
                        datosArray[cantidad] = addDatos;
                        cantidad++;
                    }
                    else
                    {
                        System.Console.WriteLine("No es posible añadir más datos");
                    }

                    break;
                case 2:
                    System.Console.WriteLine("Mostrando datos...");
                    System.Console.WriteLine();
                    MostrarDatos mostrarDatos = new MostrarDatos();
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.Write("{0}- ", i + 1);
                        mostrarDatos.Mostrar(datosArray[i].GetName(), datosArray[i].GetEdad());

                    }
                    break;
                case 0:
                    System.Console.WriteLine("Saliendo...");
                    salir = true;
                    break;
                default:
                    System.Console.WriteLine("Opcion incorrecta");
                    break;
            }


        } while (!salir);

    }
}

public class AddDatos
{
    protected string nombre;
    protected int edad;

    public string GetName()
    {
        return nombre;
    }
    public int GetEdad()
    {
        return edad;
    }

    public void PedirDatos()
    {
        System.Console.WriteLine("Añadiendo datos...");
        System.Console.Write("Nombre: ");
        nombre = Console.ReadLine();
        System.Console.Write("Edad: ");
        edad = Convert.ToInt32(Console.ReadLine());
    }
}

public class MostrarDatos
{
    public void Mostrar(string nombre, int edad)
    {

        System.Console.WriteLine("Nombre: {0}, edad: {1}", nombre, edad);

    }
}


