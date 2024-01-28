/*
¿Qué ocurre si damos el mismo nombre a dos variables locales distintas? Vamos a
comprobarlo con un ejemplo:
*/

using System;
public class Ejemplo_05_06a
{

   
    public static void CambiaN()
    {
        int n = 7;
        n++;
        Console.WriteLine("n vale {0}", n);
    }
    
    public static void Main()
    {
        int n = 5;
        Console.WriteLine("n vale {0}", n);
        CambiaN(); 
        Console.WriteLine("Ahora n vale {0}", n);
    }
}