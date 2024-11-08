using System;

/*
(4.6.6) Ampliar el ejercicio anterior (4.6.5) para que la búsqueda sea incremental: el
usuario irá indicando letra a letra el texto que quiere buscar, y se mostrará todos
los datos que lo contienen (por ejemplo, primero los que contienen "j", luego "ju",
después "jua" y finalmente "juan").
*/

class Program
{
    struct myStructFichas
    {
        public string name;
        public int age;
    }

    static void Main()
    {
        Console.Clear();

        byte option;
        bool salir = false;
        int cantidad = 0;
        int capacidad = 1000;

        myStructFichas[] fichas = new myStructFichas[capacidad];

        do
        {

            try
            {


                Console.WriteLine("Menu");
                Console.WriteLine("1: Add datos");
                Console.WriteLine("2: Mostrar datos");
                Console.WriteLine("3: Busqueda incremental");
                Console.WriteLine("4: Borrar una ficha");
                Console.WriteLine("5: Borrar consola");
                Console.WriteLine("0: Salir");

                Console.WriteLine();
                Console.WriteLine("{0} ficha guardada", cantidad);
                Console.WriteLine();


                option = Convert.ToByte(Console.ReadLine());

                switch (option)
                {

                    case 1:

                        if (cantidad < capacidad)
                        {

                            Console.Write("Nombre: ");
                            fichas[cantidad].name = Console.ReadLine();
                            Console.Write("Edad: ");
                            fichas[cantidad].age = Convert.ToInt32(Console.ReadLine());

                            cantidad++;
                        }
                        else
                        {
                            System.Console.WriteLine("No se pueden añadir más fichas");
                        }
                        Console.Clear();
                        break;

                    case 2:

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0} - {1}-{2}", i + 1, fichas[i].name, fichas[i].age);
                        }
                        Console.WriteLine();
                        break;

                    case 3:

                        char letra;
                        string palabraNueva = "";
                        string palabraFinal = "";

                        do
                        {
                            if (palabraFinal == "")
                            {
                                System.Console.Write("Marque 0 para salir o Buscar por la letra: ");
                                letra = Convert.ToChar(Console.ReadLine());

                            }
                            else
                            {
                                System.Console.Write("Marque 0 para salir o añadir letra a {0}: ", palabraFinal);
                                letra = Convert.ToChar(Console.ReadLine());
                            }

                            palabraNueva = palabraFinal;
                            palabraFinal = palabraNueva + letra;


                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichas[i].name.Contains(palabraFinal))
                                {
                                    System.Console.WriteLine("{0} - Nombre: {1}, Edad: {2} ", i + 1, fichas[i].name, fichas[i].age);
                                }
                            }

                        } while (letra != '0');
                        System.Console.WriteLine();

                        break;

                    case 4:

                        int numero;

                        Console.Write("Indica el número de la ficha que quires borrar: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        numero--;

                        for (int i = numero; i < cantidad; i++)
                        {
                            fichas[i].name = fichas[i + 1].name;
                            fichas[i].age = fichas[i + 1].age;
                        }
                        cantidad--;

                        break;

                    case 5:
                        Console.Clear();
                        break;

                    case 0:
                        salir = true;
                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta");
                        Console.WriteLine("Vuelva a intentarlo");

                        break;
                }

            }
            catch (System.FormatException)
            {

                Console.WriteLine("Error, vuelva a intentarlo");
            }

        } while (!salir);



        Console.WriteLine("Fin");




    }
}