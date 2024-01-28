/*
¿Qué ocurre si la variable es global locales distintas? Vamos a
comprobarlo con un ejemplo:
*/

using System;
public class Ejemplo_05_06a
{

    public static int n = 5;// variable global
    public static void CambiaN()
    {
        n = 7;
        n++;
        Console.WriteLine("n vale {0}", n);
    }
    
    public static void Main()
    {
        
        Console.WriteLine("n vale {0}", n);
        CambiaN(); 
        Console.WriteLine("Ahora n vale {0}", n);
    }
}