using System;

public class Trabajadores
{
    public static void Main()
    {
        Trabajador trabajador = new Trabajador();
        System.Console.WriteLine();
        Programador programador = new Programador();
        System.Console.WriteLine();
        Analista analista = new Analista();
        System.Console.WriteLine();
        Ingeniero ingeniero = new Ingeniero();
        System.Console.WriteLine();
        IngenieroInformatico ingenieroInformatico = new IngenieroInformatico();



    }
}

public class Trabajador
{
    public Trabajador()
    {
        System.Console.WriteLine("Soy un trabajador");
    }
}

public class Programador : Trabajador
{
    public Programador()
    {
        System.Console.WriteLine("Soy un programador");
    }
}

public class Analista : Trabajador
{
    public Analista()
    {
        System.Console.WriteLine("Soy un analista");
    }
}

public class Ingeniero : Trabajador
{
    public Ingeniero()
    {
        System.Console.WriteLine("Soy un Ingeniero");
    }
}

public class IngenieroInformatico : Ingeniero
{
    public IngenieroInformatico()
    {
        System.Console.WriteLine("Soy un ingeniero informático");
    }
}