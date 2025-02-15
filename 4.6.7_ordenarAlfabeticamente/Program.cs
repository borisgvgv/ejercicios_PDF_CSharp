﻿using System;

public class Program
{
    struct myStruct
    {
        public string name;
        public int age;
    }
    public static void Main()
    {
        byte opcion;
        int cantidad = 0;
        int capacidad = 1000;
        bool salir = false;

        myStruct[] fichas = new myStruct[capacidad];

        Console.Clear();
        do
        {
            System.Console.WriteLine("MENÚ");
            System.Console.WriteLine("1: Add datos");
            System.Console.WriteLine("2: Mostrar datos");
            System.Console.WriteLine("3: Borrar un dato");
            System.Console.WriteLine("4: Busqueda incremental");
            System.Console.WriteLine("5: Modificar una ficha");
            System.Console.WriteLine("6: Organizar alfabeticamente");
            System.Console.WriteLine("7: Limpiar consola");
            System.Console.WriteLine("0: SALIR");
            System.Console.WriteLine("{0} fichas guardadas", cantidad);

            try
            {
                opcion = Convert.ToByte(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Add datos

                        if (cantidad < capacidad)
                        {
                            System.Console.Write("Nombre: ");
                            fichas[cantidad].name = Console.ReadLine();
                            System.Console.Write("Edad: ");
                            fichas[cantidad].age = Convert.ToInt32(Console.ReadLine());
                            cantidad++;
                        }
                        else
                        {
                            System.Console.WriteLine("No es posible añadir más fichas");
                        }
                        Console.Clear();

                        break;

                    case 2: // Mostrar datos

                        System.Console.WriteLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0} - Nombre: {1}, Edad: {2}", i + 1, fichas[i].name, fichas[i].age);
                        }
                        System.Console.WriteLine();

                        break;

                    case 3: // Borrar un dato
 
                        int borrar;
                        System.Console.WriteLine("Indica el número de la ficha que quieres borrar");
                        borrar = Convert.ToInt32(Console.ReadLine());
                        borrar--;

                        for (int i = borrar; i < cantidad; i++)
                        {
                            fichas[i].name = fichas[i + 1].name;
                            fichas[i].age = fichas[i + 1].age;
                        }
                        cantidad--;
                        Console.Clear();

                        break;

                    case 4: // Busqueda incremental

                        char letra;
                        string palabra = "";
                        string palabraFinal = "";

                        do
                        {
                            if (palabraFinal == "")
                            {
                                System.Console.Write("Marcar 0 para salir o buscar por la letra: ");
                                letra = Convert.ToChar(Console.ReadLine());
                            }
                            else
                            {
                                System.Console.Write("Marcar 0 para salir o añadir letra a {0}: ", palabraFinal);
                                letra = Convert.ToChar(Console.ReadLine());
                            }

                            palabra = palabraFinal;
                            palabraFinal = palabra + letra;


                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichas[i].name.Contains(palabraFinal))
                                {
                                    Console.WriteLine("{0} - Nombre: {1}, Edad: {2}", i + 1, fichas[i].name, fichas[i].age);
                                }
                            }

                        } while (letra != '0');

                        System.Console.Clear();

                        break;

                    case 5: // Modificar una ficha

                        int fichaModificar;
                        string nuevoNombre;
                        int nuevaEdad;

                        System.Console.Write("Indica el número de la ficha que quieres modificar: ");
                        fichaModificar = Convert.ToInt32(Console.ReadLine());
                        fichaModificar--;

                        System.Console.Write("Nombre: ");
                        nuevoNombre = Console.ReadLine();
                        if (!string.IsNullOrEmpty(nuevoNombre))
                        {
                            fichas[fichaModificar].name = Console.ReadLine();
                        }

                        /*
                                                System.Console.Write("Edad: ");
                                                nuevaEdad = Convert.ToInt32(Console.ReadLine());
                                                nuevaEdad= nuevaEdad.ToString();
                                                if (!string.IsNullOrEmpty(nuevaEdad))
                                                {
                                                    fichas[fichaModificar].age = Convert.ToInt32(Console.ReadLine());
                                                }
                                                */

                        break;

                    case 6: // Ordenar alfabeticamente

                        myStruct[] fichasOrdenadas = new myStruct[capacidad];

                        // Copiar los datos ordenados al arreglo 'fichasOrdenadas'.
                        for (int i = 0; i < cantidad; i++)
                        {
                            fichasOrdenadas[i] = fichas[i];
                        }

                        //Ordenamos los datos en fichasOrdenadas

                        for (int i = 0; i < cantidad; i++)
                        {
                            for (int j = 0; j < cantidad - i - 1; j++)
                            {
                                
                                if (String.Compare(fichasOrdenadas[j].name, fichasOrdenadas[j + 1].name) > 0)
                                {

                                    myStruct temp = fichasOrdenadas[j];
                                    fichasOrdenadas[j] = fichasOrdenadas[j + 1];
                                    fichasOrdenadas[j + 1] = temp;

                                }
                            }
                        }


                        // Mostrar los datos ordenados.
                        for (int i = 0; i < cantidad; i++)
                        {
                            System.Console.WriteLine("{0} - {1}, {2}", i + 1, fichasOrdenadas[i].name, fichasOrdenadas[i].age);
                        }

                        System.Console.WriteLine();





                        break;

                    case 7: // Limpiar consola
                        Console.Clear();
                        break;

                    case 0: // Salir
                        salir = true;
                        break;

                    default:
                        System.Console.WriteLine();
                        System.Console.WriteLine("Opcion incorrecta");
                        System.Console.WriteLine("Vuelva a intentarlo");
                        System.Console.WriteLine();
                        break;
                }
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Opción incorrecta");
                System.Console.WriteLine("Vuelva a intentarlo");
                System.Console.WriteLine();
            }

        } while (!salir);


    }
}
