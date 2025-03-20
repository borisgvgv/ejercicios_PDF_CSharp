/*
7.2.4) A partir del ejemplo 07.02b y del ejercicio 6.8.1 (clase Trabajador y
relacionadas), crea un array de trabajadores en el que no sean todos de la misma
clase.
*/

using System;

public class Trabajadores
{
    public static void Main()
    {
        Trabajador[] trabajadores = new Trabajador[8];

        trabajadores[0] = new Programador();
        System.Console.WriteLine();
        trabajadores[1] = new Analista();
        System.Console.WriteLine();
        trabajadores[2] = new IngenieroInformatico();
        System.Console.WriteLine();

        for (byte i = 3; i < 7; i++)
        {
            trabajadores[i] = new Trabajador();
            System.Console.WriteLine();
        }

        trabajadores[7] = new Programador();
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
        //System.Console.WriteLine();
    }
}

public class Analista : Trabajador
{
    public Analista()
    {
        System.Console.WriteLine("Soy un analista");
        // System.Console.WriteLine();
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
        //System.Console.WriteLine();
    }
}


/*
        Trabajador trabajador = new Trabajador();
        System.Console.WriteLine();
        Programador programador = new Programador();
        System.Console.WriteLine();
        Analista analista = new Analista();
        System.Console.WriteLine();
        Ingeniero ingeniero = new Ingeniero();
        System.Console.WriteLine();
        IngenieroInformatico ingenieroInformatico = new IngenieroInformatico();
*/