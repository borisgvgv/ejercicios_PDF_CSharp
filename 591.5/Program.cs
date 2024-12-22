using System;

/*
5.9.1.5) Crea un programa que "dibuje" asteriscos en 100 posiciones al azar de la
pantalla. Para ayudarte para escribir en cualquier coordenada, puedes usar un
array de dos dimensiones (con tamaños 24 para el alto y 79 para el ancho), que
primero rellenes y luego dibujes en pantalla.
*/

class Program
{

    public static void DibujarEstrellas()
    {
        Random r = new Random();


        for (int i = 0; i < 30; i++)
        {
            int n = r.Next(1, 30);
            
            for (int j = 0; j < 30; j++)
            {
                if (j == n)
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
        DibujarEstrellas();
    }
}