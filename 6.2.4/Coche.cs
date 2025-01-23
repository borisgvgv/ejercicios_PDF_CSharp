/*
(6.2.4) Crea una clase "Coche", con atributos "marca" (texto), "modelo" (texto),
"cilindrada" (número entero), potencia (número real). No hace falta que crees un
Main de prueba
*/

using System;

public class Coche
{
    string marca;
    string modelo;

    int cilindrada;

    float potencia;

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
    public void SetModelo(string newMmodelo)
    {
        modelo = newMmodelo;
    }

    public int GetCilindrada()
    {
        return cilindrada;
    }
    public void SetCilindrada(int newCilindrada)
    {
        cilindrada = newCilindrada;
    }

    public float GetPotencia()
    {
        return potencia;
    }
    public void SetPotencia(float newPotencia)
    {
        potencia = newPotencia;
    }

    public void MostrarCoche()
    {
        System.Console.WriteLine("Coche actual");
        System.Console.WriteLine("Marca: {0}", marca);
        System.Console.WriteLine("Modelo: {0}", modelo);
        System.Console.WriteLine("Cilindrada: {0}", cilindrada);
        System.Console.WriteLine("Potencia: {0}", potencia);
    }


}

public class ProgramCoche
{

    public static void Main()
    {
        Console.Clear();
        Coche coche = new Coche();

        coche.SetMarca("Fiat");
        coche.SetModelo("Punto");
        coche.SetCilindrada(120);
        coche.SetPotencia(3.8f);
        coche.MostrarCoche();

    }

}
