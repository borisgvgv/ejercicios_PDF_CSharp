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
        int capacidad = 3;

        myStruct[] canciones = new myStruct[capacidad];

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
            Console.WriteLine("5 - Borrar una canción");
            Console.WriteLine("6 - Insertar canción");
            Console.WriteLine("7 - Salir");

            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:

                    if (numeroDeCancion < capacidad)
                    {
                        Console.WriteLine("Título: ");
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
                        Console.WriteLine();

                    }

                    salir = false;

                    break;

                case 2:

                    for (int i = 0; i < numeroDeCancion; i++)
                    {

                        Console.WriteLine("Tema {0}", i + 1);
                        Console.WriteLine("Título: {0}", canciones[i].titulo);
                        Console.WriteLine("Autor: {0}", canciones[i].autor);
                        Console.WriteLine();


                    }

                    salir = false;

                    break;

                case 3:

                    bool autorEncontrado = false;

                    Console.Write("Autor: ");
                    string autorBuscado = Console.ReadLine();
                    Console.WriteLine();


                    for (int i = 0; i < numeroDeCancion; i++)
                    {
                        if (autorBuscado == canciones[i].autor)
                        {
                            autorEncontrado = true;
                        }
                    }

                    for (int i = 0; i < numeroDeCancion; i++)
                    {

                        if (autorBuscado == canciones[i].autor)
                        {
                            Console.WriteLine("Tema {0}", i + 1);
                            Console.WriteLine("Título: {0}", canciones[i].titulo);
                            Console.WriteLine("Autor: {0}", canciones[i].autor);
                            Console.WriteLine();
                        }
                    }

                    if (!autorEncontrado)
                    {
                        Console.WriteLine("Este autor no existe");
                        Console.WriteLine();
                    }

                    salir = false;
                    break;

                case 4:

                    int n;

                    do
                    {
                        Console.WriteLine("Número de canción o pulsa \"0\" para salir: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (n == 0)
                        {
                            salir = true;
                        }
                        else if (n > numeroDeCancion)
                        {
                            Console.WriteLine("Archivo no encontrado");
                            Console.WriteLine("Inténtalo denuevo o pulsa \"0\" para salir");
                            Console.WriteLine();

                            salir = false;

                        }
                        else
                        {
                            Console.WriteLine("Tema {0}", n);
                            Console.WriteLine("Título: {0}", canciones[n - 1].titulo);
                            Console.WriteLine("Autor: {0}", canciones[n - 1].autor);
                            Console.WriteLine();
                            
                            salir = true;
                        }

                    } while (!salir);

                    salir = false;
                    break;

                case 5:

                    Console.Write("Número de canción que quieres borrar: ");
                    int cancionBorrar = Convert.ToInt32(Console.ReadLine());

                    for (int i = cancionBorrar - 1; i < numeroDeCancion - 1; i++)
                    {
                        canciones[i].titulo = canciones[i + 1].titulo;
                        canciones[i].autor = canciones[i + 1].autor;
                    }

                    numeroDeCancion--;
                    salir = false;
                    break;

                case 6:

                    if (numeroDeCancion == capacidad)
                    {
                        Console.WriteLine("No se pueden insertar más archivos");
                        Console.WriteLine("Elige otra opción");
                        Console.WriteLine();

                    }
                    else
                    {
                        int posicionInsertar;
                        Console.Write("En que posición quieres insertar el archivo: ");
                        posicionInsertar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        posicionInsertar--;

                        numeroDeCancion++;
                        for (int i = numeroDeCancion - 1; i > posicionInsertar; i--)
                        {
                            canciones[i].titulo = canciones[i - 1].titulo;
                            canciones[i].autor = canciones[i - 1].autor;
                        }

                        Console.Write("Titulo a insertar: ");
                        canciones[posicionInsertar].titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        canciones[posicionInsertar].autor = Console.ReadLine();
                        Console.WriteLine();
                    }

                    salir = false;
                    break;

                case 7:
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
