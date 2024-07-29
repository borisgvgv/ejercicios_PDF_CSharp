using System;
class Program
{
    struct MyStruct
    {
        public string nombre;
        public byte dia;
        public byte mes;
        public int anyo;
    }
    static void Main()
    {
        byte option;
        int capacidad = 3, cantidad = 0;
        bool salir = false;
        MyStruct[] persona = new MyStruct[capacidad];



        do
        {

            Console.WriteLine("Menú");
            Console.WriteLine("1 - ADD datos");
            Console.WriteLine("2 - Mostrar datos");
            Console.WriteLine("3 - Borrar un dato");
            Console.WriteLine("4 - Insertar un dato");
            Console.WriteLine("5 - salir");

            option = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 1:

                    if (cantidad == capacidad)
                    {
                        Console.WriteLine("No podemos añadir más datos");
                        Console.WriteLine("Elige otra opción de ménu");
                    }
                    else
                    {

                        Console.Write("Nombre: ");
                        persona[cantidad].nombre = Console.ReadLine();
                        Console.Write("Dia de nacimiento: ");
                        persona[cantidad].dia = Convert.ToByte(Console.ReadLine());
                        Console.Write("Mes de nacimiento: ");
                        persona[cantidad].mes = Convert.ToByte(Console.ReadLine());
                        Console.Write("Año de nacimiento: ");
                        persona[cantidad].anyo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        cantidad++;
                    }

                    break;

                case 2:

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("{0}, {1}/{2}/{3}", persona[i].nombre, persona[i].dia, persona[i].mes, persona[i].anyo);
                    }
                    Console.WriteLine();

                    break;

                case 3:

                    Console.WriteLine("Indica la posición de los datos que quieres borrar");
                    int posicionBorrar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = posicionBorrar - 1; i < cantidad - 1; i++)
                    {
                        persona[i].nombre = persona[i + 1].nombre;
                        persona[i].dia = persona[i + 1].dia;
                        persona[i].mes = persona[i + 1].mes;
                        persona[i].anyo = persona[i + 1].anyo;
                    }
                    cantidad--;

                    break;

                case 4:

                    Console.WriteLine("Indica en que posición donde quieres insertar los datos ");
                    int posicionInsertar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    if (cantidad == capacidad)
                    {
                        Console.WriteLine("No podemos añadir más datos");
                        Console.WriteLine("Elige otra opción de ménu");
                    }
                    else
                    {
                        cantidad++;

                        for (int i = cantidad - 1; i > posicionInsertar - 1; i--)
                        {
                            persona[i].nombre = persona[i - 1].nombre;
                            persona[i].dia = persona[i - 1].dia;
                            persona[i].mes = persona[i - 1].mes;
                            persona[i].anyo = persona[i - 1].anyo;
                        }

                        Console.Write("Nombre: ");
                        persona[posicionInsertar-1].nombre = Console.ReadLine();
                        Console.Write("Dia de nacimiento: ");
                        persona[posicionInsertar-1].dia = Convert.ToByte(Console.ReadLine());
                        Console.Write("Mes de nacimiento: ");
                        persona[posicionInsertar-1].mes = Convert.ToByte(Console.ReadLine());
                        Console.Write("Año de nacimiento: ");
                        persona[posicionInsertar-1].anyo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                    }

                    break;

                case 5:

                    salir = true;

                    break;

                default:

                    Console.WriteLine("Opción incorrecta.");
                    Console.WriteLine("Inténtalo denuevo.");
                    Console.WriteLine();

                    break;
            }

        } while (!salir);

        Console.WriteLine("FIN...");
    }
}