using System;

/*
(6.3.7) Crea un proyecto a partir de la clase Coche (ejercicio 6.2.4): además de la
clase Coche, existirá una clase PruebaDeCoche, que contendrá la función "Main",
que creará un objeto de tipo coche, pedirá al usuario su marca, modelo, cilindrada
y potencia, y luego mostrará en pantalla el valor de esos datos.
*/

public class pruebaVehiculo
{

    public static void Main()
    {

        Console.Clear();
        classVehiculo vehiculo = new classVehiculo();
        classVehiculo vehiculo2 = new classVehiculo();

        classCoche coche = new classCoche();
        classMoto moto = new classMoto();


        System.Console.Write("Marca: ");
        string marca = Console.ReadLine();
        System.Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        System.Console.Write("Cilindrada: ");
        int cilindrada = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Potencia: ");
        int potencia = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine();
        vehiculo.SetMarca(marca);
        vehiculo.SetModelo(modelo);
        vehiculo.SetCilindrada(cilindrada);
        vehiculo.SetPotencia(potencia);
        vehiculo.MostrarVehiculo();
        coche.EstoEsUnCoche();

        System.Console.WriteLine();

        System.Console.Write("Marca: ");
        string marca2 = Console.ReadLine();
        System.Console.Write("Modelo: ");
        string modelo2 = Console.ReadLine();
        System.Console.Write("Cilindrada: ");
        int cilindrada2 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Potencia: ");
        int potencia2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine();
        vehiculo2.SetMarca(marca2);
        vehiculo2.SetModelo(modelo2);
        vehiculo2.SetCilindrada(cilindrada2);
        vehiculo2.SetPotencia(potencia2);
        vehiculo2.MostrarVehiculo();
        moto.EstoEsUnaMoto();



    }
}