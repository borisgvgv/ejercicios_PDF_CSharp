// See https://aka.ms/new-console-template for more information

using System;
class Program
{
    static void Main()
    {
        //arrays "rectangulares"
        //Primera forma de uso
        int[,] notas1 = new int[3, 2]; //Array de dos dimensiones con dos valores cada uno
        //Grupo1
        notas1[0, 0] = 11;
        notas1[0, 1] = 22;
        //Grupo2
        notas1[1, 0] = 33;
        notas1[1, 1] = 44;

        Console.WriteLine($"Las notas del grupo 1 son {notas1[0, 0]}, {notas1[0, 1]}");
        Console.WriteLine($"Las notas del grupo 2 son {notas1[1, 0]}, {notas1[1, 1]}");

        //Segunda forma de uso con valores prefijados
        int[,] notas2 = {
        {55,66,77},
        {88,99,1010}
        };

        Console.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}", notas2[0, 1]);
        Console.WriteLine("La nota2 del tercer alumno del grupo 1 es {0}", notas2[0, 2]);

        //"arrays de arrays",

        int[][] notas3 = new int[3][];
        notas3[0] = new int[10];
        notas3[1] = new int[15];
        notas3[2] = new int[12];

        //Damos valores de ejemplo

        for (int i = 0; i < notas3.Length; i++)
        {

            for (int j = 0; j < notas3[i].Length; j++)
            {
                notas3[i][j] = i + j;
            }
        }

        //Mostramos los valores obtenidos
        for (int i = 0; i < notas3.Length; i++)
        {
            for (int j = 0; j < notas3[i].Length; j++)
            {
                Console.WriteLine($"Valor {i}.{j} = {notas3[i][j]}");
            }
            Console.WriteLine();
        }

        //Ejemplo de uso de GetLength para obtener las dimensiones de un array bidimencional
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


