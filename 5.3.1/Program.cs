using System;

class Program
{

    public static void DibujarCuadrado(int x, int y, string z)
    {

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                System.Console.Write(z);
            }
            System.Console.WriteLine();
        }

    }
    static void Main()
    {

        int x = 4, y = 3;
        string z = "*";

        DibujarCuadrado(x, y, z);

    }
}