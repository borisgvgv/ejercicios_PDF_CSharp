using System;

class Program
{
    static void Main()
    {

        bool salir = false;
        bool dejarDeBuscar = false;
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
                            numeros[cantidad] = Convert.ToInt32(numero);
                            cantidad++;

                            for (int i = 0; i < cantidad - 1; i++)
                            {
                                for (int j = i + 1; j < cantidad; j++)
                                {
                                    if (numeros[i] > numeros[j])
                                    {
                                        float temporal = numeros[i];
                                        numeros[i] = numeros[j];
                                        numeros[j] = temporal;
                                    }
                                }
                            }
                        }
                        else if (numero == "fin")
                        {
                            dejarDeBuscar = true;
                        }

                        for (int i = 0; i < cantidad; i++)
                        {
                            System.Console.Write($"{numeros[i]} ");
                        }

                    } while (!dejarDeBuscar);

                    break;

                case 0:
                    salir = true;
                    break;

                default:
                    System.Console.WriteLine("Opción incorrecta");
                    System.Console.WriteLine("Prueba otra opción");
                    break;
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

        } while (!salir);

    }
}