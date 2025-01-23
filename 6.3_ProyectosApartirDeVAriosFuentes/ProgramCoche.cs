
using System;

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
