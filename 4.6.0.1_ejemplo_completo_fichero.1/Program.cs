using System;

class Program
{

    struct myStruct
    {
        public string nombre;
        public double kb;
    }
    static void Main()
    {

        bool salir = false;
        byte opcion;

        int capacidad = 1000;
        int cantidad = 0;
        myStruct[] datos = new myStruct[capacidad];


        do
        {

            Console.WriteLine("MENÚ");
            Console.WriteLine("1 - Añadir datos de un nuevo fichero");
            Console.WriteLine("2 - Mostrar los nombres de todos los ficheros");
            Console.WriteLine("3 - Mostrar ficheros de más de 1000 kb");
            Console.WriteLine("4 - Ver todos los datos de un fichero según su nombre");
            Console.WriteLine("5 - borrar archivo");
            Console.WriteLine("6 - insertar archivo");
            Console.WriteLine("7 - Salir");

            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {

                case 1:

                    if (cantidad < capacidad)
                    {
                        Console.Write("Nombre del fichero: ");
                        datos[cantidad].nombre = Console.ReadLine();
                        Console.Write("Tamaño: ");
                        datos[cantidad].kb = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine();
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("No se pueden añadir más datos");
                        Console.WriteLine("Debes elegir otra opción");
                    }

                    break;

                case 2:

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("Fichero {0} ", i + 1);
                        Console.WriteLine("Nombre {0}: ", datos[i].nombre);
                        Console.WriteLine();
                    }
                    break;

                case 3:

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (datos[i].kb > 1000)
                        {
                            Console.WriteLine("Fichero {0} ", i + 1);
                            Console.WriteLine("Nombre {0}: ", datos[i].nombre);
                            Console.WriteLine("Tamaño {0} KB: ", datos[i].kb);
                            Console.WriteLine();
                        }
                    }

                    break;

                case 4:

                    Console.WriteLine("Nombre del fichero que quieres ver");
                    string nombreFichero = Console.ReadLine();
                    Console.WriteLine();

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (nombreFichero == datos[i].nombre)
                        {
                            Console.WriteLine("Fichero {0} ", i + 1);
                            Console.WriteLine("Nombre {0}: ", datos[i].nombre);
                            Console.WriteLine("Tamaño {0} KB: ", datos[i].kb);
                            Console.WriteLine();
                        }
                    }


                    break;

                case 5:

                    Console.WriteLine("Nombre del fichero que quieres eliminar");
                    string ficheroEliminar = Console.ReadLine();
                    int num = 0;

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (ficheroEliminar == datos[i].nombre)
                        {
                            num = i;
                        }
                    }

                    for (int i = num; i < cantidad; i++)
                    {
                            datos[i].nombre = datos[i + 1].nombre;
                            datos[i].kb = datos[i + 1].kb;
                    }


                    cantidad--;

                    Console.WriteLine();
                    break;

                case 6:

                    if (cantidad < capacidad)
                    {
                        Console.WriteLine("Que posición quieres añadir");
                        int posicionAnyadir = Convert.ToInt32(Console.ReadLine());

                        cantidad++;
                        for (int i = cantidad; i > posicionAnyadir - 1; i--)
                        {
                            datos[i].nombre = datos[i - 1].nombre;
                            datos[i].kb = datos[i - 1].kb;
                        }

                        Console.Write("Nombre del fichero: ");
                        datos[posicionAnyadir - 1].nombre = Console.ReadLine();
                        Console.Write("Tamaño: ");
                        datos[posicionAnyadir - 1].kb = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No se pueden añadir más datos");
                        Console.WriteLine("Prueba otra opción");
                    }


                    break;

                case 7:

                    salir = true;

                    break;

                default:

                    Console.WriteLine("Opción errónea");
                    Console.WriteLine("Inténtalo denuevo");

                    break;
            }

        } while (!salir);

        Console.WriteLine("FIN");






    }
}
