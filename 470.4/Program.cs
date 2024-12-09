/*
(4.7.4) Amplia el ejercicio anterior, para añadir una segunda fase en la que el
usuario pueda "preguntar" si un cierto valor está en el array. Como el array está
ordenado, la búsqueda no se hará hasta el final de los datos, sino hasta que se
encuentre el dato buscado o un un dato mayor que él.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        bool salir = false;
        bool dejarDeAdd = false;
        byte opcion;
        int cantidad = 0, capacidad = 1000;

        float[] numeros = new float[capacidad];

        do
        {
            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1: Add datos");
            System.Console.WriteLine("0: Salir");

            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    System.Console.WriteLine("Añade un número o escribe \"fin\" para terminar");

                    do
                    {
                        string numero = Console.ReadLine();


                        if (numero != "fin")
                        {
                            numeros[cantidad] = Convert.ToSingle(numero);

                            float numTemporal = numeros[cantidad];
                            cantidad++;

                            Array.Sort(numeros, 0, cantidad);

                            // Mostrar array ordenado
                            for (int i = 0; i < cantidad; i++)
                            {
                            
                                if (numeros[i] != numeros[i + 1])
                                {
                                    System.Console.Write($"{numeros[i]} ");
                                }
                            }
                        }
                        else if (numero == "fin")
                        {
                            dejarDeAdd = true;
                            Console.Clear();
                        }


                    } while (!dejarDeAdd);

                    break;

                case 0:
                    salir = true;
                    Console.Clear();
                    break;

                default:
                    System.Console.WriteLine("Opción incorrecta");
                    System.Console.WriteLine("Prueba otra opción");
                    break;
                    System.Console.WriteLine();
            }

            System.Console.WriteLine();

        } while (!salir);

    }
}



