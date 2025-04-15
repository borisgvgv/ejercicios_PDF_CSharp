/*
Puede ocurrir que en un método de una clase hija no nos interese redefinir por
completo las posibilidades del método equivalente de la superclase, sino
ampliarlas. En ese caso, no hace falta que volvamos a teclear todo lo que hacía el
método de la clase base, sino que podemos llamarlo directamente, precediéndolo
de la palabra "base"
*/

using System;

public class Animales
{
    public static void Main()
    {
        Console.Clear();
        Gato gato = new Gato();
        gato.Mostrar();
        System.Console.WriteLine();

        AccionGato accionGato = new AccionGato();
        accionGato.Mostrar();

    }
}

public class Animal
{
    public void Mostrar()
    {
        System.Console.WriteLine("Animal");
    }
}

public class Gato : Animal
{
    public void Mostrar()
    {
        base.Mostrar();
        System.Console.WriteLine("Gato");
    }
}

public class AccionGato : Gato
{
    public void Mostrar()
    {
        base.Mostrar();
        System.Console.WriteLine("Miauuu!!!");
        System.Console.WriteLine();
    }
}

