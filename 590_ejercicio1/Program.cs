/*
(5.9.1) Crea una función que calcule el valor de elevar un número entero a otro
número entero (por ejemplo, 5 elevado a 3 = 53 = 5 ·5 ·5 = 125). Esta función se
debe crear de forma recursiva. Piensa cuál será el caso base (qué potencia se
puede calcular de forma trivial) y cómo pasar del caso "n-1" al caso "n" (por
ejemplo, si sabes el valor de 54, cómo hallarías el de 55 a partir de él).
*/

using System;

class E590_ejercicio1
{
    static int operar(int num, int exp)
    {
        int resultado = num;

        if (exp == 1)
            return num;
        
     
     for(int i = 1; i < exp; i++){
        resultado = resultado * num;
     }

        return resultado;
    }

    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce un exponente");
        int exponente = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(" El resultado de {0} elevado a {1} es {2}", numero, exponente, operar(numero, exponente));

    }

}