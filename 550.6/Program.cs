using System;

class Program
{
    public static int PedirNumero()
    {
        Console.Write("Número: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static char PedirLetra()
    {
        Console.Write("Letra: ");
        return Convert.ToChar(Console.ReadLine());
    }

    public static void DibujarTriangulo(int n, char l)
    {

        for (int i = n; i > 0; i--)
        {
            // Imprime la letra 'i' veces en cada fila
            for (int j = 1; j <= i; j++)
            {
                Console.Write(l);
            }
            // Salto de línea después de cada fila
            Console.WriteLine();
        }

    }

    static void Main()
    {
        DibujarTriangulo(PedirNumero(), PedirLetra());
    }
}


