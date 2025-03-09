/*
(7.2.1) Crea una versión ampliada del ejercicio 6.8.1 (clase Trabajador y
relacionadas), en la que no se cree un único objeto de cada clase, sino un array de
tres objetos.
*/

using System;

public class Trabajadores
{
    public static void Main()
    {
        Trabajador[] trabajador = new Trabajador[3];
        for (int i = 0; i < trabajador.Length; i++)
        {
            trabajador[i] = new Trabajador();
        }
        System.Console.WriteLine();

        Programador[] programador = new Programador[3];
        for (int i = 0; i < 3; i++)
        {
            programador[i] = new Programador();
        }
        System.Console.WriteLine();

        Analista[] analista = new Analista[3];
        for (int i = 0; i < 3; i++)
        {
            analista[i] = new Analista();
        }
        System.Console.WriteLine();

        Ingeniero[] ingeniero = new Ingeniero[3];
        for (int i = 0; i < 3; i++)
        {
            ingeniero[i] = new Ingeniero();
        }
        System.Console.WriteLine();

        IngenieroInformatico[] ingenieroInformatico = new IngenieroInformatico[3];
        for (int i = 0; i < 3; i++)
        {
            ingenieroInformatico[i] = new IngenieroInformatico();
        }
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