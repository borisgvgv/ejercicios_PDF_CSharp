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

    public byte GetOpcion()
    {
        return opcion;
    }
    public void MostarMenu()
    {
        System.Console.WriteLine("\nMenu");
        System.Console.WriteLine("1: AddDatos: ");
        System.Console.WriteLine("2: Mostrar datos: ");
        System.Console.WriteLine("0: Salir: ");

        opcion = Convert.ToByte(Console.ReadLine());

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
        System.Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
    }
}

public class GestionDeArchivo
{


    protected List<AddDatos> listaDatos = new List<AddDatos>();
    protected bool salir = false;

    protected Menu menu = new Menu();

    public GestionDeArchivo()
    {

        do
        {
            menu.MostarMenu(); //Muestra menu
            Console.Clear();
            switch (menu.GetOpcion())
            {
                case 1:
                    System.Console.WriteLine("Añadiendo datos");

                    AddDatos addDatos = new AddDatos();
                    addDatos.PedirDatos();
                    listaDatos.Add(addDatos);

                    break;
                case 2:
                    System.Console.WriteLine("Mostrando datos");

                    MostrarDatos mostrarDatos = new MostrarDatos();
                    for (int i = 0; i < listaDatos.Count; i++)
                    {
                        mostrarDatos.Mostrar(listaDatos[i].GetNombre(), listaDatos[i].GetEdad());
                    }

                    /*
                    Mostrar datos con bucle foreach:

                   foreach (var datos in listaDatos)
                    {
                        mostrarDatos.Mostrar(datos.GetNombre(), datos.GetEdad());
                    }
                    
                    */

                    break;
                case 0:
                    System.Console.WriteLine("Saliendo...");
                    salir = true;
                    break;

                default:
                    System.Console.WriteLine("Error al pedir opción");
                    break;
            }

        } while (!salir);
    }

}