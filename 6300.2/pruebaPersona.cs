using System;

public class PruebaPersona
{
    public static void Main()
    {
        Persona persona1 = new Persona();
        bool error = false;
        bool salir = false;

        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine("A - AñadirDatos y mostrar");
            Console.WriteLine("S - Salir");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "A":

                    do
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nombre:");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Edad:");
                            int edad = Convert.ToInt32(Console.ReadLine());
                            persona1.SetNombre(nombre);
                            persona1.SetEdad(edad);

                            ConsoleKeyInfo tecla;
                            do
                            {
                                Console.WriteLine("Pulsa intro para saludar");
                                tecla = Console.ReadKey();
                                Console.WriteLine();

                            } while (tecla.Key != ConsoleKey.Enter);

                            persona1.Saludar();
                            error = false;
                            salir = true;

                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Datos incorrectos");
                            error = true;
                        }

                    } while (error || !salir);

                    break;


                case "S":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (!salir);

        Console.WriteLine("Hasta pronto");


    }
}