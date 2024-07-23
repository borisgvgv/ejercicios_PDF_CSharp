using System;

public class Program
{
    struct myStruct
    {
        public string titulo;
        public string autor;
    }
    public static void Main()
    {
        int cantidad = 3;
        myStruct[] canciones = new myStruct[cantidad];

        bool salir = true;
        byte opcion;
        int numeroDeCancion = 0;

        do
        {

            Console.WriteLine("Menú");
            Console.WriteLine("1 - Add canción");
            Console.WriteLine("2 - Mostrar canciones");
            Console.WriteLine("3 - Mostrar por autor");
            Console.WriteLine("4 - Mostrar por número");
            Console.WriteLine("5 - Salir");

            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:

                    if (numeroDeCancion < cantidad)
                    {
                        Console.WriteLine("Titulo: ");
                        canciones[numeroDeCancion].titulo = Console.ReadLine();
                        Console.WriteLine("Autor: ");
                        canciones[numeroDeCancion].autor = Console.ReadLine();
                        Console.WriteLine();

                        numeroDeCancion++;
                    }
                    else
                    {

                        Console.WriteLine("No se pueden añadir más datos");
                        Console.WriteLine("Debes elegir otra opción");

                    }

                    salir = false;

                    break;

                case 2:

                    for (int i = 0; i < numeroDeCancion; i++)
                    {

                        Console.WriteLine("Tema {0}", i + 1);
                        Console.WriteLine("Titulo: {0}", canciones[i].titulo);
                        Console.WriteLine("Autor: {0}", canciones[i].autor);
                        Console.WriteLine();


                    }

                    salir = false;

                    break;

                case 3:

                    Console.Write("Autor: ");
                    string autorBuscado = Console.ReadLine();

                    for (int i = 0; i < numeroDeCancion; i++)
                    {

                        if (autorBuscado == canciones[i].autor)
                        {
                            Console.WriteLine("Tema {0}", i + 1);
                            Console.WriteLine("Titulo: {0}", canciones[i].titulo);
                            Console.WriteLine("Autor: {0}", canciones[i].autor);
                            Console.WriteLine();
                        }
                    }

                    salir = false;
                    break;

                case 4:

                    int n;

                    do
                    {
                        Console.WriteLine("Número de canción: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n > numeroDeCancion)
                        {
                            Console.WriteLine("Archivo encontrado");
                            Console.WriteLine("Inténtalo denuevo");
                            salir = false;
                        }
                        else
                        {
                            salir = true;
                        }

                    } while (!salir);

                    Console.WriteLine("Tema {0}", n);
                    Console.WriteLine("Titulo: {0}", canciones[n - 1].titulo);
                    Console.WriteLine("Autor: {0}", canciones[n - 1].autor);
                    Console.WriteLine();

                    salir = false;
                    break;

                case 5:
                    salir = true;
                    break;


                default:
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("Elige otra opción");
                    salir = false;
                    break;
            }


        } while (!salir);

        Console.WriteLine("FIN");


    }

}
