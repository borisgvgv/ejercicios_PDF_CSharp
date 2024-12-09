/*
(4.7.6) Crea una variante del ejercicio 4.7.3, pero usando esta vez Array.Sort para
ordenar: un programa que pida al usuario varios números, los vaya añadiendo a
un array, mantenga el array ordenado continuamente y muestre el resultado tras
añadir cada nuevo dato (todos los datos se mostrarán en la misma línea,
separados por espacios en blanco). Terminará cuando el usuario teclee "fin".
*/
using System;

class Program
{
    static void Main()
    {

        bool salir = false;
        bool dejarDeAdd = false;
        bool existe = false;
        byte opcion;
        int cantidad = 0, capacidad = 6, contador = capacidad;

        float[] numeros = new float[capacidad];

        do
        {
            Console.Clear();
            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1: Add datos");
            System.Console.WriteLine("0: Salir");

            if (contador == 1)
            {
                System.Console.WriteLine("No se pueden añadir más datos debe pulsar 0 para salir");
            }


            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    System.Console.WriteLine("Añade un número o escribe \"fin\" para terminar");

                    do
                    {

                        if (contador > 1)
                        {

                            dejarDeAdd = false;
                            string numero = Console.ReadLine();
                            contador--;


                            if (numero != "fin")
                            {
                                numeros[cantidad] = Convert.ToSingle(numero);
                                cantidad++;


                                for (int i = 0; i < cantidad - 1; i++)
                                {
                                    if (Convert.ToSingle(numero) == numeros[i])
                                    {
                                        System.Console.WriteLine("Este número ya existe");
                                        cantidad--;
                                        contador++;
                                    }
                                }

                                Array.Sort(numeros, 0, cantidad);

                                for (int i = 0; i < cantidad; i++)
                                {
                                    if (numeros[i] == numeros[i + 1])
                                    {
                                        numeros[i] = numeros[i + 1];

                                    }
                                }

                                for (int i = 0; i < cantidad; i++)
                                {
                                    System.Console.Write($"{numeros[i]} ");
                                }

                            }
                            else if (numero == "fin")
                            {
                                dejarDeAdd = true;
                            }
                        }

                        else
                        {
                            dejarDeAdd = true;
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
