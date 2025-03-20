using System;

public class Program
{
    public static void Main()
    {
        Animal[] animal = new Animal[3];
        animal[0] = new Animal();
        animal[1] = new Perro();
        animal[2] = new Gato();

        animal[0].MostrarSaludo();
        animal[1].MostrarSaludo();
        animal[2].MostrarSaludo();
    }
}


public class Animal
{
    public virtual void MostrarSaludo()
    {
        System.Console.WriteLine("Hola soy un animal");
    }
}

public class Gato : Animal
{
    public override void MostrarSaludo()
    {
        System.Console.WriteLine("Hola soy un gato");
    }
}

public class Perro : Animal
{
    public override void MostrarSaludo()
    {
        System.Console.WriteLine("Hola soy un perro");
    }
}
