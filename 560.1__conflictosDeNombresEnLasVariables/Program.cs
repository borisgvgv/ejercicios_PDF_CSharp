/*
¿Qué ocurre si la variable es global locales distintas? Vamos a
comprobarlo con un ejemplo:
*/

using System;
public class Ejemplo_05_06a
{
    static int n = 7;// variable global
    public static void CambiaN()
    {
        n++;
    }
    
    public static void Main()
    { 
        Console.WriteLine("n vale {0}", n);
        CambiaN(); 
        Console.WriteLine("Ahora n vale {0}", n);
    }
}