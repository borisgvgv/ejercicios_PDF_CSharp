using System;

public class Caracteristicas
{

    protected string tipoDeVehiculo;
    protected string marca;
    protected string modelo;
    protected int matricula;

    protected int velocidad = 50;

    public Caracteristicas(string newTipoDeVehiculo, string newMarca, string newModelo, int newMatricula)
    {
        tipoDeVehiculo = newTipoDeVehiculo;
        marca = newMarca;
        modelo = newModelo;
        matricula = newMatricula;
    }

    public void Circular(){
        System.Console.WriteLine("Velocidad: {0}", velocidad);
    }
    public void Circular(int newVelocidad){
        velocidad = newVelocidad;
        System.Console.WriteLine("Velocidad: {0}", velocidad);
    }

    public void MostrarVehiculo()
    {
        System.Console.WriteLine("Tipo de vehiculo: {0}", tipoDeVehiculo);
        System.Console.WriteLine("Marca: {0}", marca);
        System.Console.WriteLine("Modelo: {0}", modelo);
        System.Console.WriteLine("Matrícula: {0}", matricula);
    }

}