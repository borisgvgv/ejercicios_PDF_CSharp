using System;
public class Ejemplo_06_08a
{
    public static void Main()
    {
        Animal a1 = new Animal();
        Console.WriteLine();

        GatoSiames a2 = new GatoSiames();
        Console.WriteLine();

        Perro a3 = new Perro();
        Console.WriteLine();
        
        Gato a4 = new Gato();
        Console.WriteLine();
    }
}

// class--------------------------

public class Animal
{
    public Animal()
    {
        Console.WriteLine("Ha nacido un animal");
    }
}


// ------------------
public class Perro : Animal
{
    public Perro()
    {
        Console.WriteLine("Ha nacido un perro");
    }
}
// ------------------
public class Gato : Animal
{
    public Gato()
    {
        Console.WriteLine("Ha nacido un gato");
    }
}
// ------------------
public class GatoSiames : Gato
{
    public GatoSiames()
    {
        Console.WriteLine("Ha nacido un gato siamés");
    }
}