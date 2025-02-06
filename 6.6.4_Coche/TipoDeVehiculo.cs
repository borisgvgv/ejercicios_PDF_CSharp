using System;

public class TipoDeVehiculo : CaracteristicasDelVehiculo
{
    protected string tipoDeVehiculo;
    protected byte cantidadDeRuedas;

    public string GetTipoDeVehiculo()
    {
        return tipoDeVehiculo;
    }

    public void SetTipoDeVehiculo(string newTipoDeVehiculo)
    {
        tipoDeVehiculo = newTipoDeVehiculo;
    }

    public byte GetTipoCantidadDeRuedas()
    {
        return cantidadDeRuedas;
    }

    public void SetCantidadDeRuedas(byte newCantidadDeRuedas)
    {
        cantidadDeRuedas = newCantidadDeRuedas;
    }
    
    public new void MostrarTipoDeVehiculo()
    {
        System.Console.WriteLine("Características del vehículo");
        System.Console.WriteLine("Tipo de Vehiculo: {0}", tipoDeVehiculo);
    }

     public new void CantidadDeRuedas()
    {
        System.Console.WriteLine("{0} ruedas", cantidadDeRuedas);
    }
}

