using System;

class Program
{

    public static void DibujarCuadrado()
    {
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j<3; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {

        DibujarCuadrado();

    }
}

