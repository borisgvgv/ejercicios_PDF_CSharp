using System;

/*
(4.7.2) Un programa que pida al usuario 5 nombres y los muestre ordenados
alfabéticamente (recuerda que para comparar cadenas no podrás usar el símbolo
">", sino "CompareTo").     
*/


class Program
{
    static void Main()
    {

        bool salir = false;
        bool dejarDeAdd = false;
        byte opcion;
        int cantidad = 0, capacidad = 1000;

        string[] nombres = new string[capacidad];

        do
        {
            System.Console.WriteLine("MENU");
            System.Console.WriteLine("1: Add nombres");
            System.Console.WriteLine("2: Mostrar nombres ordenados alfabeticamente");
            System.Console.WriteLine("0: Salir");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {

                case 1: // Add datos

                    System.Console.WriteLine("Añade un nombre o escribe 000 para salir");
                    do
                    {
                        nombres[cantidad] = Console.ReadLine();
                        if (nombres[cantidad] != "000")
                        {
                            cantidad++;
                        }
                        else
                        {
                            dejarDeAdd = true;
                        }

                    } while (!dejarDeAdd);

                    break;

                case 2: // Mostrar datos ordenados
                    string[] nombres2 = new string[capacidad];

                    // add nombres a nombres2
                    for (int i = 0; i < cantidad; i++)
                    {
                        nombres2[i] = nombres[i];
                    }

                    //Mostramos los nombres desordenados
                    System.Console.WriteLine("Nombres desordenados");
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.WriteLine($"{i + 1} - {nombres2[i]}");
                    }
                    System.Console.WriteLine(); //Salto de línea

                    //Ordenamos los nombres con el método burbuja
                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        for (int j = i + 1; j < cantidad; j++)
                        {
                            if (string.Compare(nombres2[i], nombres2[j])>0)
                            {
                                string datoTemporal = nombres2[i];
                                nombres2[i] = nombres2[j];
                                nombres2[j] = datoTemporal;
                            }
                        }
                    }

                    //Mostramos los nombres Ordenados
                    System.Console.WriteLine("Nombres Ordenados");
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.WriteLine($"{i + 1} - {nombres2[i]}");
                    }

                    break;

                case 0: // salir
                    salir = true;
                    break;

                default:
                    System.Console.WriteLine("Opción incorrecta");
                    System.Console.WriteLine("Prueba otra opción");
                    break;
            }

            System.Console.WriteLine();// salto de línea
        } while (!salir);

    }
}
