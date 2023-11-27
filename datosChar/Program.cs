using System;
class datosChar
{
    static void Main()
    {
        char letra;
        letra = 'a';
        Console.WriteLine("La letra es {0}", letra);
        
        Console.WriteLine("Introduce una nueva letra");
        letra = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Ahora la letra es {0}", letra);
    }
}