using System;

public class Coche
{
    string marca = "Pendiente";
    string modelo = "Pendiente";
    int cilindrada;
    double potencia;

    public string GetMarca()
    {
        return marca;
    }
    public void SetMarca(string nuevaMarca)
    {
        marca = nuevaMarca;
    }

    public string GetModelo()
    {
        return modelo;
    }
    public void SetModelo(string nuevoModelo)
    {
        modelo = nuevoModelo;
    }

    public int GetCilindrada()
    {
        return cilindrada;
    }
    public void SetCilindrada(int nuevaCilindrada)
    {
        cilindrada = nuevaCilindrada;
    }
    public double GetPotencia()
    {
        return potencia;
    }
    public void SetPotencia(double nuevaPotencia)
    {
        potencia = nuevaPotencia;
    }

    public void MostrarCoche()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Cilindrada: {cilindrada}");
        Console.WriteLine($"Potencia: {potencia}");
    }
}

public class Coches
{
    public static void Main()
    {
        bool salir = false;
        int longitud = 0; // Inicializamos la longitud del array a 0
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
                    // Incrementamos la longitud del array antes de añadir un nuevo coche
                    Array.Resize(ref ArrayCoche, longitud + 1);
                    ArrayCoche[longitud] = new Coche();

                    Console.WriteLine("Marca:");
                    string marc = Console.ReadLine();
                    ArrayCoche[longitud].SetMarca(marc);

                    Console.WriteLine("Modelo:");
                    string mod = Console.ReadLine();
                    ArrayCoche[longitud].SetModelo(mod);

                    Console.WriteLine("Cilindrada:");
                    int cilind = Convert.ToInt32(Console.ReadLine());
                    ArrayCoche[longitud].SetCilindrada(cilind);

                    Console.WriteLine("Potencia:");
                    double pot = Convert.ToDouble(Console.ReadLine());
                    ArrayCoche[longitud].SetPotencia(pot);

                    longitud++; // Incrementamos la longitud después de añadir un nuevo coche
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
