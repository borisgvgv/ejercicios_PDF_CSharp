using System;

class Program
{
    static void Main()
    {
        // Crear una matriz bidimensional
        int[,] matriz = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        // Obtener la longitud de la primera dimensión (filas)
        int filas = matriz.GetLength(0);

        // Obtener la longitud de la segunda dimensión (columnas)
        int columnas = matriz.GetLength(1);

        // Mostrar las dimensiones de la matriz
        Console.WriteLine("Filas: " + filas);
        Console.WriteLine("Columnas: " + columnas);

        // Acceder a los elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
