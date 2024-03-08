/*Ver explicación con dos formas diferentes de ampliar el array 
usando los métodos estáticos 
Array.Resize
Array.Copy

Enlace de la explicación
https://chat.openai.com/share/15996a75-60a6-480f-b6e7-b2aafbfa1db1
*/

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
        int longitud = 0;
        Coche[] ArrayCoche = new Coche[longitud];



        do
        {

            Console.WriteLine("Menú");
            Console.WriteLine("a - añadir datos");
            Console.WriteLine("m - mostrar datos");
            Console.WriteLine("s - salir");
            Console.WriteLine();




            char option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 'a':

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

                    longitud++;

                    break;

                case 'm':
                    Console.WriteLine();
                    for (int i = 0; i < ArrayCoche.Length; i++)
                    {
                        ArrayCoche[i].MostrarCoche();
                        Console.WriteLine();
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


