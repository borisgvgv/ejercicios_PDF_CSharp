using System;

public class mostrarLibro
{
    public static void Main()
    {

        bool salir = false;
        //int Libros = 0;
        int cantidadLibros = 0;
        int cantidadRevistas = 0;
        Libro[] ArrayLibros = new Libro[cantidadLibros];
        Revista[] ArrayRevistas = new Revista[cantidadRevistas];


        do
        {

            Console.WriteLine("   Menú   ");
            Console.WriteLine("a - Añadir");
            Console.WriteLine("m - Mostrar");
            Console.WriteLine("b - Buscar");
            Console.WriteLine("s - Salir");

            try
            {
                char opcion = Convert.ToChar(Console.ReadLine());


                switch (opcion)
                {
                    case 'a':

                        Console.WriteLine("Libro o revista");
                        Console.WriteLine("l  - Libro");
                        Console.WriteLine("r - revista");

                        char libroRevista = Convert.ToChar(Console.ReadLine());

                        if (libroRevista == 'l')
                        {
                            Array.Resize(ref ArrayLibros, cantidadLibros + 1);
                            ArrayLibros[cantidadLibros] = new Libro();


                            ArrayLibros[cantidadLibros].SetNumeracion(cantidadLibros + 1);
                            Console.WriteLine("Título:");
                            string nuevoTitulo = Console.ReadLine();
                            ArrayLibros[cantidadLibros].SetTitulo(nuevoTitulo);

                            Console.WriteLine("Autor:");
                            string nuevoAutor = Console.ReadLine();
                            ArrayLibros[cantidadLibros].SetAutor(nuevoAutor);

                            Console.WriteLine("Lanzamiento:");
                            int nuevoLanzamiento = Convert.ToInt32(Console.ReadLine());
                            ArrayLibros[cantidadLibros].SetLanzamiento(nuevoLanzamiento);

                            cantidadLibros++;
                        }
                        else if (libroRevista == 'r')
                        {
                            Array.Resize(ref ArrayRevistas, cantidadRevistas + 1);
                            ArrayRevistas[cantidadRevistas] = new Revista();

                            ArrayRevistas[cantidadRevistas].SetNumeracion(cantidadRevistas + 1);
                            Console.WriteLine("Título:");
                            string nuevoTitulo = Console.ReadLine();
                            ArrayRevistas[cantidadRevistas].SetTitulo(nuevoTitulo);

                            Console.WriteLine("Autor:");
                            string nuevoAutor = Console.ReadLine();
                            ArrayRevistas[cantidadRevistas].SetAutor(nuevoAutor);

                            Console.WriteLine("Lanzamiento:");
                            int nuevoLanzamiento = Convert.ToInt32(Console.ReadLine());
                            ArrayRevistas[cantidadRevistas].SetLanzamiento(nuevoLanzamiento);

                            Console.WriteLine("Activa:");
                            string activarDesactivar = Console.ReadLine();
                            ArrayRevistas[cantidadRevistas].SetEstadoRevista(activarDesactivar);

                            cantidadRevistas++;
                        }


                        break;

                    case 'm':
                        Console.WriteLine();

                        Console.WriteLine("Libros");
                        Console.WriteLine("-------------");
                        for (int i = 0; i < cantidadLibros; i++)
                        {
                            ArrayLibros[i].mostrar();
                            Console.WriteLine();
                        }

                        Console.WriteLine("Revistas");
                        Console.WriteLine("-------------");
                        for (int i = 0; i < cantidadRevistas; i++)
                        {
                            ArrayRevistas[i].mostrar();
                            Console.WriteLine();
                        }

                        break;

                    case 'b':

                        bool salirBuscar = false;

                        Console.WriteLine("Buscar por:");
                        Console.WriteLine("nl - Número de libro");
                        Console.WriteLine("nr - Número de Revista");
                        Console.WriteLine("tt - Título");
                        Console.WriteLine("aa - Autor");
                        Console.WriteLine("ss - Salir de Buscar");

                        string BuscarPor = Console.ReadLine();


                        switch (BuscarPor)
                        {
                            case "nl":

                                Console.WriteLine("Que número quieres buscar");
                                int numeroLib = Convert.ToInt32(Console.ReadLine());

                                if (numeroLib <= cantidadLibros)
                                {

                                    for (int i = 1; i <= cantidadLibros; i++)
                                    {

                                        if (i == numeroLib)
                                        {
                                            ArrayLibros[i - 1].mostrar();
                                        }

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("El número no es válido");
                                }
                                break;

                            case "nr":

                                Console.WriteLine("Que número quieres buscar");
                                int numeroRevista = Convert.ToInt32(Console.ReadLine());

                                if (numeroRevista <= cantidadRevistas)
                                {

                                    for (int i = 1; i <= cantidadRevistas; i++)
                                    {

                                        if (i == numeroRevista)
                                        {
                                            ArrayRevistas[i - 1].mostrar();
                                        }

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("El número no es válido");
                                }
                                break;

                            case "tt":

                                Console.WriteLine("Que titulo quieres buscar");
                                string tituloLibro = Console.ReadLine();

                                foreach (Libro libro in ArrayLibros)
                                {
                                    if (tituloLibro == libro.GetTitulo())
                                    {
                                        libro.mostrar();
                                    }
                                }

                                break;

                            case "aa":
                                break;
                            case "ss":
                                salirBuscar = true;
                                break;
                            default:
                                Console.WriteLine("La opción no es válida");
                                break;

                        }


                        break;

                    case 's':
                        if (opcion == 's')
                        {
                            salir = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;



                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("La opción debe ser un caracter");
            }

        } while (salir != true);


    }

}