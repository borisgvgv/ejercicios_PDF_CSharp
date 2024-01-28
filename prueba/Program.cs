using System;
using System.Data;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce un el número como texto");
        string textoNum = Console.ReadLine();

        Funcion(numero, textoNum);

        Console.WriteLine(" Hagamos un cuadrado");
        Console.Write(" alto: ");
        int alto = Convert.ToInt32(Console.ReadLine());
        Console.Write(" ancho: ");
        int ancho = Convert.ToInt32(Console.ReadLine());
        DibujarCuadrado(alto, ancho);



    }
    static void Funcion(int numero, string texto)
    {
        Console.WriteLine("número: {0} y Texto del número: {1} ", numero, texto);
        Console.WriteLine("{0} {1} ", numero, texto);
    }
    static void DibujarCuadrado(int al, int an)
    {
        for (int i = 0; i <= al; i++)
        {
            for (int j = 0; j <= an; j++)
            {

                if (((i == 0) || (i == al))||((j == 0) || (j == an)))
                {
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }
    }
}