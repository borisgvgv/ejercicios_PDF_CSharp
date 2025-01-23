/*
(4.2.3) Un programa que pregunte al usuario el tamaño que tendrán dos bloques
de números enteros (por ejemplo, uno de 10 elementos y otro de 12). Luego
pedirá los datos para ambos bloques de datos. Finalmente deberá mostrar el
mayor dato que se ha introducido en cada uno de ellos.
*/

using System;
class Program
{
    static void Main()
    {

        int valor;
        int mayor1 = 0;
        int mayor2 = 0;
        
        Console.WriteLine("Tamaño del primer bloque de datos");
        int bloque1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tamaño del segundo bloque de datos");
        int bloque2 = Convert.ToInt32(Console.ReadLine());

        int[][] arrayDatos = new int[2][];
        arrayDatos[0] = new int[bloque1];
        arrayDatos[1] = new int[bloque2];

        //Pedimos valores para los datos
        for (int i = 0; i < arrayDatos.Length; i++)
        {
            for (int j = 0; j < arrayDatos[i].Length; j++)
            {
                Console.WriteLine("Introduce un valor");
                valor = Convert.ToInt32(Console.ReadLine());

                arrayDatos[i][j] = valor;
            }
        }

        //Mostramos los valores
        for (int i = 0; i < arrayDatos.Length; i++)
        {
            for (int j = 0; j < arrayDatos[i].Length; j++)
            {

                Console.WriteLine($" Valor {i}.{j} = {arrayDatos[i][j]}");
            }
        }

        for (int i = 0; i < arrayDatos.Length; i++)
        {
            for (int j = 0; j < arrayDatos[0].Length; j++)
            {
                if (mayor1 < arrayDatos[0][j])
                {
                    mayor1 = arrayDatos[0][j];
                }
            } for (int j = 0; j < arrayDatos[1].Length; j++)
            {
                if (mayor2 < arrayDatos[1][j])
                {
                    mayor2 = arrayDatos[1][j];
                }
            }

             for (int j = 0; j < arrayDatos[1].Length; j++)
            {
                if (mayor2 < arrayDatos[1][j])
                {
                    mayor2 = arrayDatos[1][j];
                }
            }
        }

        
        Console.WriteLine($"El numero mayor de la lista 1 es {mayor1}");
        Console.WriteLine($"El numero mayor de la lista 2 es {mayor2}");



    }
}