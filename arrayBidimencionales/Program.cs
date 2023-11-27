// Ejemplo_04_02a.cs
// Array de dos dimensiones "rectangulares" (estilo Pascal)
// Introducción a C#, por Nacho Cabanes

using System;
class Ejemplo_04_02a
{
    static void Main()
    {
        int[,] notas1 = new int[2, 2]; // 2 bloques de 2 datos
        notas1[0, 0] = 1;
        notas1[0, 1] = 2;
        notas1[1, 0] = 3;
        notas1[1, 1] = 4;

        // 2 bloques de 10 datos, prefijados
        int[,] notas2 ={
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
            {11, 12, 13, 14, 15, 16, 17, 18, 19, 20}

            };
        Console.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}",
        notas1[0, 1]);
        Console.WriteLine("La nota2 del tercer alumno del grupo 2 es {0}",
        notas2[1, 2]);

        /*
        Si queremos recorrer por completo un array de varias dimensiones, no nos
        bastará con ".Length", sino que querremos saber la cantidad de filas y de
        columnas, o, en general, de datos que hay en cada una de las dimensiones. Para
        eso, podemos emplear ".GetLength(n)", donde n será un número desde 0 (la
        primera dimensión, típicamente las filas) hasta n-1 (la última dimensión, que serán
        las columnas en el caso de dos dimensiones):
        */

        // Ejemplo_04_02a2.cs
        // Array de dos dimensiones "rectangulares" + GetLength
        // Introducción a C#, por Nacho Cabanes


        int[,] notas3 = // 2 bloques de 10 datos, prefijados
        {
{1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
{11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
};
        for (int i = 0; i < notas3.GetLength(0); i++)
        {
            for (int j = 0; j < notas3.GetLength(1); j++)
            {
                Console.Write("{0} ", notas3[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine(); //Salto de Línea
        Console.WriteLine("Arrays de arrays");

        /*
        La otra forma de tener arrays multidimensionales son los "arrays de arrays", que,
        como ya hemos comentado, y como veremos en este ejemplo, pueden tener
        elementos de distinto tamaño. En ese caso nos puede interesar saber su longitud,
        para lo que, como ya sabemos, se puede emplear ".Length":
        */
        // Ejemplo_04_02b.cs
        // Array de arrays (array de dos dimensiones al estilo C)
        // Introducción a C#, por Nacho Cabanes

        int[][] notas4; // Array de dos dimensiones
        notas4 = new int[3][]; // Serán 3 bloques de datos
        notas4[0] = new int[10]; // 10 notas4 en un grupo
        notas4[1] = new int[15]; // 15 notas4 en otro grupo
        notas4[2] = new int[12]; // 12 notas4 en el ultimo
                                 // Damos valores de ejemplo
        for (int i = 0; i < notas4.Length; i++)
        {
            for (int j = 0; j < notas4[i].Length; j++)
            {
                notas4[i][j] = i + j;
            }
        }
        // Y mostramos esos valores
        for (int i = 0; i < notas4.Length; i++)
        {
            for (int j = 0; j < notas4[i].Length; j++)
            {
                Console.Write(" {0}", notas4[i][j]);
            }
            Console.WriteLine();
        }


    }
}