using System;

class Program
{

    struct myStruct
    {
        public string nombre;
        public int edad;
    }
    static void Main()
    {

        int capacidad = 5;
        int cantidad = 0;
        bool salir = false;
        byte opcion;

        myStruct[] persona = new myStruct[capacidad];


        do
        {

            if (cantidad < capacidad)
            {
                Console.Write("Nombre: ");
                persona[cantidad].nombre = Console.ReadLine();

                if (persona[cantidad].nombre == "")
                {
                    salir = true;
                }
                else
                {
                    Console.Write("Edad: ");
                    persona[cantidad].edad = Convert.ToInt32(Console.ReadLine());
                    cantidad++;
                }

            }
            else
            {
                Console.WriteLine("No se pueden añadir más datos");
                salir = true;
            }

        } while (!salir);

        salir = false;

        do
        {

            Console.WriteLine();
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Mostrar todos los nombres");
            Console.WriteLine("2 - Mostrar nombres de cierta edad");
            Console.WriteLine("3 - Mostrar nombre según su inicial");
            Console.WriteLine("4 - Salir");

            Console.WriteLine();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("{0} - Nombre: {1}, Edad: {2}", i + 1, persona[i].nombre, persona[i].edad);
                    }
                    Console.WriteLine();

                    break;
                case 2:

                    Console.WriteLine("A partir de que edad quiere buscar?");
                    int edadBuscar = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (persona[i].edad > edadBuscar)
                        {
                            Console.WriteLine("{0} - Nombre: {1}, Edad: {2}", i + 1, persona[i].nombre, persona[i].edad);
                        }
                    }
                    Console.WriteLine();

                    break;

                case 3:

                    Console.WriteLine("Indica una inicial");
                    char inicial = Convert.ToChar(Console.ReadLine());

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (persona[i].nombre[0] == inicial)
                        {
                            Console.WriteLine("{0} - Nombre: {1}, Edad: {2}", i + 1, persona[i].nombre, persona[i].edad);
                        }
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    salir = true;
                    Console.WriteLine();
                    break;


                default:
                    Console.WriteLine("Opción incorrecta.");
                    Console.WriteLine("Prueba otra opción");
                    break;
            }



        } while (!salir);

        Console.WriteLine("FIN");





    }
}