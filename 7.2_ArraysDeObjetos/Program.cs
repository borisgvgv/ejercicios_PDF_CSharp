using System;

public class Program
{
    public static void Main()
    {
        Perro[] perros = new Perro[5];

        for (int i = 0; i < 5; i++)
        {
            perros[i] = new Perro();
        }

    }
}

public class Animal
{
    public Animal()
    {
        System.Console.WriteLine("Ha nacido un animal");
    }
}
public class Perro : Animal
{
    public Perro()
    {
        System.Console.WriteLine(" Ha nacido un perro");
    }
}
