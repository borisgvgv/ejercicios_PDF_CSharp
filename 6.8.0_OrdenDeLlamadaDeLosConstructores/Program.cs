/*

Cuando creamos objetos de una clase derivada, antes de llamar a su constructor
se llama a los constructores de las clases base, empezando por la más general y
terminando por la más específica. Por ejemplo, si creamos una clase
"GatoSiamés", que deriva de una clase "Gato", que a su vez procede de una clase
"Animal", el orden de ejecución de los constructores sería: Animal, Gato,
GatoSiames, como se ve en este ejemplo:

*/

// Ejemplo_06_08a.cs
// Orden de llamada a los constructores
// Introducción a C#, por Nacho Cabanes
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
// ------------------
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