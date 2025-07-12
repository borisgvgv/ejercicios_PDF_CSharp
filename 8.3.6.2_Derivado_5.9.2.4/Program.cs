
//8.3.6.1_Derivado_5.9.2.4
/*
(5.9.2.4) Haz un programa que pida al usuario 5 datos numéricos enteros, los
guarde en un array, pida un nuevo dato y muestre el valor del array que se
encuentra más cerca de ese dato, siendo mayor que él, o el texto "Ninguno es
mayor" si ninguno lo es.
*/

using System;
public class Program
{
    public static void Main(String[] args)
    {
        int[] numeros = new int[5];
        int contador = 0;
        int addNum;
        while (contador < numeros.Length)
        {
            System.Console.Write("Añade un número: ");
            addNum = Convert.ToInt32(Console.ReadLine());
            if (addNum < 1 || addNum > 10)
            {
                System.Console.WriteLine("El número debe estar comprendido entre 1 y 10");
            }
            else
            {
                numeros[contador] = addNum;
                contador++;
            }
        }

        //Mostramos todos los números
        System.Console.WriteLine("Los número elegidos son:");
        foreach (int numero in numeros)
        {
            System.Console.Write($"{numero} ");
        }

        System.Console.WriteLine(); // salto de línea

        System.Console.WriteLine("Añade un nuevo número");
        int newNumero = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine($"El nuevo número añadido es el {newNumero}.");

        int mayor = numeros[0];
        for (int i = 0; i < numeros.Length; i++)
        {
            mayor = Math.Max(mayor, numeros[i]);
        }

        if (mayor < newNumero)
        {
            System.Console.WriteLine($"Ningún número es mayor que {newNumero}");
        }
        else
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > newNumero && numeros[i] < mayor)
                    mayor = numeros[i];
            }
            System.Console.WriteLine($"El número mayor más cercano es el {mayor}");
        }

    } 
}