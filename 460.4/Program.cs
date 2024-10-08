﻿using System;
public class Ejemplo_04_06a
{
    struct tipoFicha
    {
        public string nombreFich; // Nombre del fichero
        public long tamanyo; // El tamaño en KB
    };
    public static void Main()
    {
        tipoFicha[] fichas = new tipoFicha[1000]; // Los datos en si
        int numeroFichas = 0; // Número de fichas que ya tenemos
        int i; // Para bucles
        int opcion = 0; // La opcion del menu que elija el usuario
        string textoBuscar; // Para cuando preguntemos al usuario
        long tamanyoBuscar; // Para buscar por tamaño
        bool salir = false;

        do
        {
            // Menu principal, repetitivo
            Console.WriteLine();
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1.- Añadir datos de un nuevo fichero");
            Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
            Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
            Console.WriteLine("4.- Ver datos de un fichero");
            Console.WriteLine("5.- Salir");

           
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    salir = true;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Introduce un número");
                }

         
            // Hacemos una cosa u otra según la opción escogida
            switch (opcion)
            {
                case 1: // Añadir un dato nuevo

                    if (numeroFichas < 1000)
                    { // Si queda hueco


                        do
                        {

                            Console.WriteLine("Introduce el nombre del fichero: ");
                            fichas[numeroFichas].nombreFich = Console.ReadLine();

                            if (EsString(fichas[numeroFichas].nombreFich))
                            {
                                Console.WriteLine("El nombre del fichero no puede ser unicamente un número o un espacio");
                            }


                        } while (fichas[numeroFichas].nombreFich == "" || EsString(fichas[numeroFichas].nombreFich));

                        do
                        {


                            try
                            {
                                Console.WriteLine("Introduce el tamaño en KB: ");
                                fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());
                                salir = true;
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("Introduce un número");
                            }

                        } while (!salir);


                        // Y add una ficha más
                        numeroFichas++;
                    }
                    else // Si no hay hueco para más fichas, avisamos
                        Console.WriteLine("Máximo de fichas alcanzado (1000)!");
                    break;
                case 2: // Mostrar todos
                    for (i = 0; i < numeroFichas; i++)
                        Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                        fichas[i].nombreFich, fichas[i].tamanyo);
                    break;
                case 3: // Mostrar según el tamaño
                    Console.WriteLine("¿A partir de que tamaño quieres ver?");
                    tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
                    for (i = 0; i < numeroFichas; i++)
                        if (fichas[i].tamanyo >= tamanyoBuscar)
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                            fichas[i].nombreFich, fichas[i].tamanyo);
                    break;
                case 4: // Ver todos los datos (pocos) de un fichero
                    Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
                    textoBuscar = Console.ReadLine();
                    for (i = 0; i < numeroFichas; i++)
                        if (fichas[i].nombreFich == textoBuscar)
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                            fichas[i].nombreFich, fichas[i].tamanyo);
                    break;
                case 5: // Salir: avisamos de que salimos */
                    Console.WriteLine("Fin del programa");
                    break;
                default: // Otra opcion: no válida
                    Console.WriteLine("Opción desconocida!");
                    break;
            }
        } while (opcion != 5); // Si la opcion es 5, terminamos
    }


    // Función que no permite que un nombre sea solo números
    static bool EsString(string s)
    {

        foreach (char c in s)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }



}
