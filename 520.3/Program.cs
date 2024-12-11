using System;
class Program
{

    struct myStruct
    {
        public string nombre;
        public int edad;
    }

    static bool salir = false;
    static byte opcion;
    static int cantidad = 0;
    static int capacidad = 20;
    static int archPorEncimade;
    static int archivoBuscado;
    static myStruct[] persona = new myStruct[capacidad];
    public static void Menu()
    {
        Console.WriteLine("Escoja una opción:");
        Console.WriteLine("1:  Añadir datos de un nuevo fichero");
        Console.WriteLine("2: Mostrar los nombres de todos los ficheros");
        Console.WriteLine("3: Mostrar ficheros por encima de un cierto tamaño");
        Console.WriteLine("4: Ver datos de un fichero");
        Console.WriteLine("5: Ordenar archivos alfabeticamente");
        Console.WriteLine("6: Limpiar consola");
        Console.WriteLine("0: Salir");
        Console.WriteLine($"Fichas guardadas: {cantidad}");
    }

    public static byte Opcion()
    {
        return Convert.ToByte(Console.ReadLine());
    }

    public static void AddDatos() //Case 1
    {
        System.Console.Write("Nombre: ");
        persona[cantidad].nombre = Console.ReadLine();
        System.Console.Write("Edad: ");
        persona[cantidad].edad = Convert.ToInt32(Console.ReadLine());
        cantidad++;
        Console.Clear();
    }

    public static void Mostrar() //Case 2
    {
        for (int i = 0; i < cantidad; i++)
        {
            System.Console.WriteLine($"{i + 1} - Nombre: {persona[i].nombre}, Edad: {persona[i].edad}");
        }
    }

    public static void MostrarPorEncimaDe() //Case 3
    {
        System.Console.WriteLine("Mostrar por encima del fichero: ");
        System.Console.Write("Número: ");
        archPorEncimade = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            if (i + 1 > archPorEncimade)
            {
                System.Console.WriteLine($"{i + 1} - Nombre: {persona[i].nombre}, Edad: {persona[i].edad}");
            }
        }

    }

    public static void buscarArchivo() // case 4
    {
        System.Console.Write("Número de archivo: ");
        archivoBuscado = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            if (i + 1 == archivoBuscado)
            {
                System.Console.WriteLine($"{i + 1} - Nombre: {persona[i].nombre}, Edad: {persona[i].edad}");
            }
        }
    }

    // https://chatgpt.com/c/675966c9-c8d8-8006-a348-79e4a9f00c11
    public static void OrdenarAlfabeticamente()
    {
        var sortList = persona.Take(cantidad).OrderBy(p => p.nombre).ToArray();

        for (int i = 0; i < sortList.Length; i++)
        {
            Console.WriteLine($"{i + 1} - Nombre: {sortList[i].nombre}, Edad: {sortList[i].edad}");
        }
    }


    public static void LimpiarConsola() //Case 6
    {
        Console.Clear();
    }

    public static void Salir()
    {
        salir = true;
    }

    static void Main()
    {
        Console.Clear();
        do
        {
            Menu();
            opcion = Opcion();

            switch (opcion)
            {
                case 1:
                    AddDatos();
                    break;
                case 2:
                    Mostrar();
                    break;

                case 3:
                    MostrarPorEncimaDe();
                    break;

                case 4:
                    buscarArchivo();
                    break;

                case 5:
                    OrdenarAlfabeticamente();
                    break;

                case 6:
                    LimpiarConsola();
                    break;


                case 0:
                    Salir();
                    break;

                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }

            System.Console.WriteLine(); // salto
        } while (!salir);

        System.Console.WriteLine("Fin");

    }
}