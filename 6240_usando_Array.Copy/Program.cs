using System;

public class Coche
{
    // ... (sin cambios en la definición de la clase)
}

public class Coches
{
    public static void Main()
    {
        bool salir = false;
        int longitud = 0;
        Coche[] ArrayCoche = new Coche[longitud];

        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine("a - añadir datos");
            Console.WriteLine("m - mostrar datos");
            Console.WriteLine("s - salir");

            char option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 'a':
                    Coche nuevoCoche = new Coche();

                    Console.WriteLine("Marca:");
                    nuevoCoche.SetMarca(Console.ReadLine());

                    Console.WriteLine("Modelo:");
                    nuevoCoche.SetModelo(Console.ReadLine());

                    Console.WriteLine("Cilindrada:");
                    nuevoCoche.SetCilindrada(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Potencia:");
                    nuevoCoche.SetPotencia(Convert.ToDouble(Console.ReadLine()));

                    // Crear un nuevo array temporal con un tamaño mayor
                    Coche[] nuevoArrayCoche = new Coche[longitud + 1];

                    // Copiar los elementos existentes al nuevo array
                    Array.Copy(ArrayCoche, nuevoArrayCoche, longitud);

                    // Asignar el nuevo coche al final del nuevo array
                    nuevoArrayCoche[longitud] = nuevoCoche;

                    // Actualizar la referencia al nuevo array
                    ArrayCoche = nuevoArrayCoche;

                    longitud++; // Incrementar la longitud después de añadir un nuevo coche
                    break;

                case 'm':
                    for (int i = 0; i < longitud; i++)
                    {
                        ArrayCoche[i].MostrarCoche();
                    }
                    break;

                case 's':
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (salir != true);
    }
}
