using System;
class Program
{

    static void DibujarCuadrado(int alto, int ancho, char caracter)
    {
        for (int i = 0; i <= alto; i++)
        {
            for (int j = 0; j <= ancho; j++)
            {
                if ((i == 0) || (i == alto) || (j == 0) || (j == ancho))
                {
                    Console.Write(caracter);
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.WriteLine("Alto");
        int alto = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ancho");
        int ancho = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce un caracter");
        char caracter = Convert.ToChar(Console.ReadLine());

        DibujarCuadrado(alto, ancho, caracter);
    }
}
