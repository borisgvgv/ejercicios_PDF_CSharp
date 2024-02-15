/*
Crea un programa que emplee recursividad para calcular la suma de los
elementos de un vector de números enteros, desde su posición inicial a la final,
usando una función recursiva que tendrá la apariencia: SumaVector(v, desde,
hasta). Nuevamente, piensa cuál será el caso base (cuántos elementos podrías
sumar para que dicha suma sea trivial) y cómo pasar del caso "n-1" al caso "n" (por
ejemplo, si conoces la suma de los 6 primeros elementos y el valor del séptimo
elemento, cómo podrías emplear esta información para conocer la suma de los 7
primeros).
*/

using System;
class Program
{

    public static int SumaVector(int[] vector, int desde, int hasta)
    {
        if(desde == hasta)
        return vector[desde];

        return vector[desde] + SumaVector(vector, desde + 1, hasta);

    }

    static void Main()
    {
        int[] vector = new int[11];
        int desde = vector[0];
        int hasta = vector.Length-1;
        int resultado = 0;

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = i;
        }
        for (int i = 1; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }

        Console.WriteLine();

        for (int i = 1; i < vector.Length; i++)
        {
            resultado += vector[i];

        }
        Console.WriteLine($"* Suma con bucle for = {resultado}");

        Console.WriteLine($"* Suma con recursividad = {SumaVector(vector, desde, hasta)}");
    }
}