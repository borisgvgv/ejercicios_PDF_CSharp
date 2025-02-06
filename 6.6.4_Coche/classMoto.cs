using System;

public class classMoto : CaracteristicasDelVehiculo
{
    public new void MostrarTipoDeVehiculo()
    {
        System.Console.WriteLine("Características del vehículo");
        System.Console.WriteLine("Tipo de vehiculo: Moto");
    }

    public new void CantidadDeRuedas(){
        System.Console.WriteLine("2 Ruedas");
    }

}