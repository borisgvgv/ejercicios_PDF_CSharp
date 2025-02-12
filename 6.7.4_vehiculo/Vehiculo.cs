using System;

public class Vehiculo
{
    public static void Main()
    {

        System.Console.Write("Tipo de vehiculo: ");
        string tipoDeVehiculo = Console.ReadLine();
        System.Console.Write("Marca: ");
        string marca = Console.ReadLine();
        System.Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        System.Console.Write("Martícula: ");
        int matricula = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Velocidad: ");
        int velocidad = Convert.ToInt32(Console.ReadLine());
        Caracteristicas caracteristicas = new Caracteristicas(tipoDeVehiculo, marca, modelo, matricula);

        caracteristicas.MostrarVehiculo();
        caracteristicas.Circular(velocidad);

    }

}