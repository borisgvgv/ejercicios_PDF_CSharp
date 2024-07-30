using System;

class Program
{
    static void Main()
    {

        byte cantidad = 0, capacidad = 5, option;
        bool fin = false;
        string palabra;
        string[] frases = new string[capacidad];


        do
        {
            Console.WriteLine("MENÚ");
            Console.WriteLine("1 - Add frase");
            Console.WriteLine("2 - Mostrar frases");
            Console.WriteLine("3 - Buscar frase según palabra añadida y mostrar su posición en la frase");
            Console.WriteLine("4 - Borrar frase");
            Console.WriteLine("5 - Añadir frase");
            Console.WriteLine("6 - Salir");
            option = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 1:

                    if (cantidad == capacidad)
                    {
                        Console.WriteLine("No es posible añadir más frases");
                        Console.WriteLine("Prueba otra opción");
                    }
                    else
                    {
                        Console.WriteLine("Frase {0} ", cantidad + 1);
                        frases[cantidad] = Console.ReadLine();
                        cantidad++;
                    }

                    Console.WriteLine();

                    break;

                case 2:

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("{0} - {1}.", i + 1, frases[i]);
                    }
                    Console.WriteLine();

                    break;

                case 3:

                    Console.Write("Palabra: ");
                    palabra = Console.ReadLine();


                    for (int i = 0; i < cantidad; i++)
                    {
                        if (frases[i].IndexOf(palabra) >= 0)
                        {
                            Console.WriteLine("La palabra {0} Aparece en la frase", palabra);
                            Console.WriteLine("{0}", frases[i]);
                            Console.WriteLine("En la posición {0}",frases[i].IndexOf(palabra));
                        }
                    }
                    Console.WriteLine();

                    break;

                case 4:

                    Console.WriteLine("Que Frase quieres eliminar");
                    byte borrar = Convert.ToByte(Console.ReadLine());

                    for (int i = borrar-1; i < cantidad; i++)
                    {
                        frases[i] = frases[i + 1];
                    }
                    cantidad--;

                    break;

                case 5:

                    Console.WriteLine("Que posición quieres insertar");
                    byte insertar = Convert.ToByte(Console.ReadLine());
                    insertar--;
                    cantidad++;

                    for (int i = cantidad; i > insertar; i--)
                    {
                        frases[i] = frases[i - 1];
                    }

                    Console.WriteLine("Frase {0} ", insertar);
                    frases[insertar] = Console.ReadLine();

                    break;

                case 6:
                    fin = true;
                    break;

                default:
                    Console.WriteLine("Opción incorrecto");
                    Console.WriteLine("Intentalo nuevamente");
                    break;

            }

        } while (!fin);

        Console.WriteLine("FIN");
        Console.WriteLine();

    }
}