using System;

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


class Program
{
    public static int SumaVector(int vector, int desde, int hasta)
    {

        if (vector == 0)
        {
            return 0;
        }
        else
        {
            return vector + SumaVector(vector, hasta, desde - 1);
        }

    }

    public static int PedirVector(){
        System.Console.Write("Vector: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int PedirDesde(){
        System.Console.Write("Desde: ");
        return Convert.ToInt32(Console.ReadLine());
    }
     public static int PedirHasta(){
        System.Console.Write("Hasta: ");
        return Convert.ToInt32(Console.ReadLine());
    }


    static void Main()
    {
        System.Console.WriteLine(SumaVector(PedirVector(), PedirDesde(), PedirHasta()));
    }
}