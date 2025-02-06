using System;

public class TipoDeVehiculo : CaracteristicasVehiculo
{

    protected string tipoDeVehiculo;

    public string GetTipoDeVehiculo()
    {
        return tipoDeVehiculo;
    }
    public void SetTipoDeVehiculo(string newTipoDeVehiculo)
    {
        tipoDeVehiculo = newTipoDeVehiculo;
    }

    public new void MostrarTipoDeVehiculo()
    {
        System.Console.WriteLine("Tipo de vehículo: {0}", tipoDeVehiculo);
    }
}