using System;

class Program
{

    public static void dibujarCuadrado()
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                if (i == 1 || i == 3 || j == 1 || j == 3)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
    static void Main()
    {

        dibujarCuadrado();

    }
}