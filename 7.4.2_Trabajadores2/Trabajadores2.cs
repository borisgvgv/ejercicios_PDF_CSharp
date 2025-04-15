using System;

public class Trabajadores2
{
    public static void Main()
    {
        Console.Clear();
        Analista analista = new Analista("Hola soy un ");  
        System.Console.WriteLine();
        Informatico informatico = new Informatico("Hola soy un ");
        System.Console.WriteLine();
        Analista2 analista2 = new Analista2();
        System.Console.WriteLine();
        

    }
}

public class Trabajador
{
    protected string saludo;
    public Trabajador(string saludo)
    {
        System.Console.Write(saludo);
    }
}

public class Trabajador2
{
    protected string saludo = "Hola soy un segundo ";
    public Trabajador2()
    {
        System.Console.Write(saludo);
    }
}

public class Analista : Trabajador
{
    public Analista(string saludo) : base(saludo)
    {
        System.Console.Write("Analista ");
    }
}

public class Analista2 : Trabajador2
{
    public Analista2()
    {
        System.Console.Write("Analista ");
    }
}

public class Informatico : Analista
{
    public Informatico(string saludo) : base(saludo)
    {
        System.Console.Write("Informático ");
    }
}


