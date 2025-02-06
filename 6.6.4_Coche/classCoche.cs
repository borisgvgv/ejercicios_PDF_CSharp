using System;

public class classCoche : CaracteristicasDelVehiculo
{
    public new void MostrarTipoDeVehiculo()
    {
        System.Console.WriteLine("Características del vehículo");
        System.Console.WriteLine("Tipo de vehiculo: Coche");
    }

    public new void CantidadDeRuedas()
    {
        System.Console.WriteLine("4 Ruedas");
    }
}