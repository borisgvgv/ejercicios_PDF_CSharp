/*
(5.10.8) Crear un programa que encuentre el máximo común divisor de dos
números usando el algoritmo de Euclides: Dados dos números enteros positivos m
y n, tal que m > n, para encontrar su máximo común divisor, es decir, el mayor
entero positivo que divide a ambos: - Dividir m por n para obtener el resto r (0 ≤ r
< n) ; - Si r = 0, el MCD es n.; - Si no, el máximo común divisor es MCD(n,r).
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcularMCD(m, n));
    }

    static int CalcularMCD(int m, int n)
    {

        int r = 0;
        // Asegurarse de que m sea siempre mayor que n
         if (n > m)
        {
            int temp = m;
            m = n;
            n = temp;
        }

        if (m%n == 0)
        {
            
            return n;

        }

        
        return CalcularMCD(n, m % n);

        //Desglose de calculo para los valores 5 y 17
        // Primero se evalúa que número es mayor y se organiza en 17 y 5
        // Luego se evalúa si el resto es = 0, (17 % 5 != 0)
        // Como  (17 % 5 != 0) resto = 2, pasamos el valor de n a m , n = 5 y se evalua 5 % 2 == 1
        // Como  (5 % 2 != 0) resto = 1, pasamos el valor de n a m , n = 2 y se evalua 2 % 1 == 0




    }

}
