using System;

/*
(4.7.1) Un programa que pida al usuario 6 números en coma flotante y los muestre
ordenados de menor a mayor. Escoge el método de ordenación que prefieras.
*/

class Program
{
    static void Main()
    {
        bool salir = false;
        byte opcion;
        int cantidad = 0, capacidad = 1000;

        float[] numeros = new float[capacidad];

        do
        {
            System.Console.WriteLine("MENU");
            System.Console.WriteLine("1: Add datos");
            System.Console.WriteLine("2: Mostrar datos ordenados con método burbuja");
            System.Console.WriteLine("3: Mostrar datos ordenados con método selección directa");
            System.Console.WriteLine("0: Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            System.Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    bool dejarDeAdd = false;
                    System.Console.WriteLine("Añade un número o marca 000 para dejar de añadir");
                    do
                    {
                        numeros[cantidad] = Convert.ToSingle(Console.ReadLine());

                        if (numeros[cantidad] != 000)
                        {
                            cantidad++;
                        }
                        else
                        {
                            dejarDeAdd = true;
                        }


                    } while (!dejarDeAdd);

                    break;

                case 2: //Mostrar datos ordenados con método burbuja"

                    System.Console.WriteLine("Datos ordenados con método burbuja");
                    float[] numeros2 = new float[capacidad];

                    // pasamos datos a numeros2
                    for (int i = 0; i < cantidad; i++)
                    {
                        numeros2[i] = numeros[i];
                    }

                    // muestro el array numeros2 desordenados
                    System.Console.WriteLine("Datos desordenados");
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.Write($"{numeros2[i]} ");
                    }
                    System.Console.WriteLine();

                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        for (int j = i + 1; j < cantidad; j++)
                        {
                            if (numeros2[i] > numeros2[j])
                            {
                                float temporal = numeros2[i];
                                numeros2[i] = numeros2[j];
                                numeros2[j] = temporal;
                            }
                        }
                    }

                    // muestro el array numeros2 ordenados
                    System.Console.WriteLine("Datos ordenados");
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.Write($"{numeros2[i]} ");
                    }
                    System.Console.WriteLine();

                    break;

                case 3: // Mostrar datos ordenados con método selección directa


                    System.Console.WriteLine("Datos ordenados con método de selleción directa");
                    float[] numeros3 = new float[capacidad];

                    // pasamos datos a numeros3
                    for (int i = 0; i < cantidad; i++)
                    {
                        numeros3[i] = numeros[i];
                    }

                    // muestro el array numeros3 desordenados
                    System.Console.WriteLine("Datos desordenados");
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.Write($"{numeros3[i]} ");
                    }
                    System.Console.WriteLine();

                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        int menor = i;
                        for (int j = menor; j < cantidad; j++)
                        {
                            if (numeros3[menor] > numeros3[j])
                            {
                                menor = j;
                            }

                        }

                        if (menor != i)
                        {
                            float temporal = numeros3[menor];
                            numeros3[menor] = numeros3[i];
                            numeros3[i] = temporal;
                        }
                    }

                    // muestro el array numeros3 ordenados
                    System.Console.WriteLine("Datos ordenados");
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.Write($"{numeros3[i]} ");
                    }
                    System.Console.WriteLine();

                    break;

                case 0:
                    salir = true;
                    break;
                default:

                    System.Console.WriteLine();
                    System.Console.WriteLine("Opción errónea");
                    System.Console.WriteLine("Prueba otra opción");
                    System.Console.WriteLine();

                    break;
            }

            System.Console.WriteLine(); // salto de línea

        } while (!salir);


    }
}
