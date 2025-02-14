/*

7.1. La palabra "static"

Desde un principio, nos hemos encontrado con que "Main" siempre iba
acompañado de la palabra "static". Lo mismo ocurría con las funciones que
creamos en el tema 5. En cambio, los métodos (funciones) que pertenecen a
nuestros objetos no los estamos declarando como "static". Vamos a ver el motivo:
- La palabra "static" delante de un atributo (una variable) de una clase, indica
que es una "variable de clase", es decir, que su valor es el mismo para todos
los objetos de la clase. Por ejemplo, si hablamos de coches convencionales,
podríamos suponer que el atributo "numeroDeRuedas" va a tener el valor 4
para cualquier objeto que pertenezca a esa clase (cualquier coche). Por eso,
se podría declarar como "static". En el mundo real, esto es muy poco
habitual, y por eso casi nunca usaremos atributos "static" (por ejemplo, no
todos los coches que podamos encontrar tendrán 4 ruedas, aunque esa sea
la cantidad más frecuente).

- De igual modo, si un método (una función) está precedido por la palabra
"static", indica que es un "método de clase", es decir, un método que se
podría usar sin necesidad de declarar ningún objeto de la clase. Por
ejemplo, si queremos que se pueda usar la función "BorrarPantalla" de una
clase "Hardware" sin necesidad de crear primero un objeto perteneciente a
esa clase, lo podríamos conseguir así
*/

// Ejemplo_07_01a.cs
// Métodos "static"
// Introducción a C#, por Nacho Cabanes
using System;
public class Hardware
{
    public static void BorrarPantalla()
    {
        for (byte i = 0; i < 25; i++)
            Console.WriteLine();
    }
}
public class Ejemplo_07_01a
{
    public static void Main()
    {
        Console.WriteLine("Pulsa Intro para borrar");
        Console.ReadLine();

        Hardware.BorrarPantalla();
        Console.WriteLine("Borrado!");
    }
}