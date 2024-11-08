using System;

/*
(4.6.5) Ampliar la base de datos de ficheros (ejemplo 04_06a) para que incluya una
opción de búsqueda parcial, en la que el usuario indique parte del nombre y se
muestre todos los ficheros que contienen ese fragmento (usando "Contains" o
"IndexOf"). Esta búsqueda no debe distinguir mayúsculas y minúsculas (con la
ayuda de ToUpper o ToLower).
*/

public class Program
{

    struct myStructFichas
    {
        public string nombreFich;
        public int tamanyoFich;

    };

    static void Main()
    {
        Console.Clear();

        bool salir = false;
        bool archivoEncontrado = false;
        byte option;
        int capacidad = 1000;
        int cantidad = 0;

        myStructFichas[] fichas = new myStructFichas[1000];

        do
        {

            Console.WriteLine("MENU");
            Console.WriteLine("1 - Add datos del fichero");
            Console.WriteLine("2 - Mostrar ficheros");
            Console.WriteLine("3 - Mostrar por nombre");
            Console.WriteLine("4 - Mostrar por parte del nombre");
            Console.WriteLine("5 - Borrar archivo");
            Console.WriteLine("6 - Limpiar pantalla");
            Console.WriteLine("0 - Salir");

            try
            {
                option = Convert.ToByte(Console.ReadLine());
                Console.WriteLine(); //Espacio





                switch (option)
                {
                    case 1:

                        Console.Write("Nombre del fichero: ");
                        fichas[cantidad].nombreFich = Console.ReadLine();
                        Console.Write("Tamaño del fichero: ");
                        fichas[cantidad].tamanyoFich = Convert.ToInt32(Console.ReadLine());

                        cantidad++;
                        Console.WriteLine();
                        break;
                    case 2:

                        archivoEncontrado = false;
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Fichero - {0}", i + 1);
                            Console.WriteLine("Nombre: {0}", fichas[i].nombreFich);
                            Console.WriteLine("Tamaño: {0} Kb", fichas[i].tamanyoFich);
                            archivoEncontrado= true;
                            Console.WriteLine();//Espacio
                        }
                        if (!archivoEncontrado)
                        {
                            Console.WriteLine("No se han encontrado archivos que mostrar");
                            Console.WriteLine();
                        }

                        break;

                    case 3:

                        Console.WriteLine("Introduce el nombre que quieres buscar");
                        string nombreBuscar = Console.ReadLine();
                        nombreBuscar = nombreBuscar.ToLower();
                        archivoEncontrado = false;



                        for (int i = 0; i < cantidad; i++)
                        {
                            if (nombreBuscar == fichas[i].nombreFich.ToLower())
                            {
                                archivoEncontrado = true;
                                Console.WriteLine("Fichero - {0}", i + 1);
                                Console.WriteLine("Nombre: {0}", fichas[i].nombreFich);
                                Console.WriteLine("Tamaño: {0} Kb", fichas[i].tamanyoFich);
                                Console.WriteLine();//Espacio
                            }
                        }

                        if (!archivoEncontrado)
                        {
                            Console.WriteLine("Archivo no encontrado");
                            Console.WriteLine();//Espacio
                        };

                        break;

                    case 4:

                        Console.WriteLine("Introduce parte del nombre a buscar");
                        string parteNombreBuscar = Console.ReadLine();
                        parteNombreBuscar = parteNombreBuscar.ToLower();
                        archivoEncontrado = false;

                        Console.WriteLine("Busqueda utilizando Contains");
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (fichas[i].nombreFich.ToLower().Contains(parteNombreBuscar))
                            {
                                archivoEncontrado = true;
                                Console.WriteLine("Fichero - {0}", i + 1);
                                Console.WriteLine("Nombre: {0}", fichas[i].nombreFich);
                                Console.WriteLine("Tamaño: {0} Kb", fichas[i].tamanyoFich);
                                Console.WriteLine();//Espacio
                            }

                        }

                        if (!archivoEncontrado)
                        {
                            Console.WriteLine("Archivo no encontrado");
                            Console.WriteLine();//Espacio
                        };


                        Console.WriteLine("Busqueda utilizando IndexOf");
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (fichas[i].nombreFich.IndexOf(parteNombreBuscar) != -1)
                            {
                                archivoEncontrado = true;
                                Console.WriteLine("Fichero - {0}", i + 1);
                                Console.WriteLine("Nombre: {0}", fichas[i].nombreFich);
                                Console.WriteLine("Tamaño: {0} Kb", fichas[i].tamanyoFich);
                                Console.WriteLine();//Espacio
                            }
                        }

                        if (!archivoEncontrado)
                        {
                            Console.WriteLine("Archivo no encontrado");
                            Console.WriteLine();//Espacio
                        };

                        break;

                    case 5:
                        //Borrar archivo


                        Console.WriteLine("Introduce el nombre del archivo a borrar");
                        string archivoBorrar = Console.ReadLine();
                        int posicion = 0;


                        Console.WriteLine("Busqueda utilizando Contains");
                        for (int i = 0; i < cantidad; i++)
                        {

                            if (fichas[i].nombreFich == archivoBorrar)
                            {
                                archivoEncontrado = true;
                                posicion = i;

                                for (int j = posicion; j < cantidad; j++)
                                {

                                    fichas[j].nombreFich = fichas[j + 1].nombreFich;
                                    fichas[j].tamanyoFich = fichas[j + 1].tamanyoFich;

                                }
                                cantidad--;
                            }
                        }


                        if (!archivoEncontrado)
                        {
                            Console.WriteLine("Archivo no encontrado");
                            Console.WriteLine();//Espacio
                        };

                        break;

                    case 6:
                        Console.Clear();
                        break;

                    case 0:
                        salir = true;
                        break;
                    default:
                        break;
                }

            }
            catch (System.FormatException)
            {

                Console.WriteLine("Error en el formato");
            }

        } while (!salir);


        Console.Clear();



    }
}