using System;

public class CaracteristicasDelVehiculo
{
    protected string marca;
    protected string modelo;
    protected int cilindrada;
    protected int potencia;

    public string GetMarca()
    {
        return marca;
    }

    public void SetMarca(string newMarca)
    {
        marca = newMarca;
    }
    public string GetModelo()
    {
        return modelo;
    }

    public void SetModelo(string newModelo)
    {
        modelo = newModelo;
    }

    public int GetCilindrada()
    {
        return cilindrada;
    }

    public void SetCilindrada(int newCilindrada)
    {
        cilindrada = newCilindrada;
    }

    public int GetPotencia()
    {
        return potencia;
    }

    public void SetPotencia(int newPotencia)
    {
        potencia = newPotencia;
    }

    public void MostrarCaracteristicasDelVehiculo()
    {
        System.Console.WriteLine("Marca: {0}", marca);
        System.Console.WriteLine("Modelo: {0}", modelo);
        System.Console.WriteLine("Cilindrada: {0}", cilindrada);
        System.Console.WriteLine("Potencia: {0}", potencia);

    }



}