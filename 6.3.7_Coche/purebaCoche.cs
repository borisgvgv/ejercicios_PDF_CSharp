using System;

/*
(6.3.7) Crea un proyecto a partir de la clase Coche (ejercicio 6.2.4): además de la
clase Coche, existirá una clase PruebaDeCoche, que contendrá la función "Main",
que creará un objeto de tipo coche, pedirá al usuario su marca, modelo, cilindrada
y potencia, y luego mostrará en pantalla el valor de esos datos.
*/

public class pruebaCoche
{

    public static void Main()
    {

        Console.Clear();
        classCoche coche = new classCoche();

        System.Console.Write("Marca: ");
        string marca = Console.ReadLine();
        System.Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        System.Console.Write("Cilindrada: ");
        int cilindrada = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Potencia: ");
        int potencia = Convert.ToInt32(Console.ReadLine());

        coche.SetMarca(marca);
        coche.SetModelo(modelo);
        coche.SetCilindrada(cilindrada);
        coche.SetPotencia(potencia);
        coche.MostrarCoche();


    }
}