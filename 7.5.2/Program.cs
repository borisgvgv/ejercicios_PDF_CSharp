/*
(7.5.2) Crea una clase Puerta con un ancho, un alto y un método "MostrarEstado"
que muestre su ancho y su alto. Crea una clase Casa, que contenga 3 puertas y
otro método "MostrarEstado" que escriba "Casa" y luego muestre el estado de sus
tres puertas.
*/

using System;

public class Program
{
    public static void Main()
    {
        Casa casa = new Casa();
        casa.MostrarEstado();
    }
}

public class Puerta
{
    protected byte ancho;
    protected byte alto;

    public Puerta() : this(5, 2)
    {
    }
    public Puerta(byte ancho, byte alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public void MostrarEstado()
    {
        System.Console.WriteLine("Ancho: {0}, Alto: {1}", ancho, alto);
    }
}

public class Casa
{

    Puerta[] puertas = new Puerta[3];
    public Casa()
    {
        for (int i = 0; i < puertas.Length; i++)
        {
            if (i == 0)
            {
                puertas[i] = new Puerta();
            }
            else
            {
                Console.WriteLine("Casa {0}", i + 1);
                Console.Write("Ancho: ");
                byte ancho = Convert.ToByte(Console.ReadLine());
                Console.Write("Alto: ");
                byte alto = Convert.ToByte(Console.ReadLine());
                puertas[i] = new Puerta(ancho, alto);

            }
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Casa");
        for (int i = 0; i < puertas.Length; i++)
        {
            Console.Write("Puerta {0}: ", i + 1);
            puertas[i].MostrarEstado();
        }
    }
}

