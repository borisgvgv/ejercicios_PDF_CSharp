using System;

public class ClassPorton : ClassPuerta
{

    bool estadoDeBloqueo;

    public bool GetEstadoDeBloqueo()
    {
        return estadoDeBloqueo;
    }

    public void SetEstadoDeBloqueo(bool newEstadoDeBloqueo)
    {
        estadoDeBloqueo = newEstadoDeBloqueo;
    }

    public new void MonstrarEstado()
    {
        System.Console.WriteLine("Características del portón");
        System.Console.WriteLine("Alto: {0}", alto);
        System.Console.WriteLine("Ancho: {0}", ancho);
        System.Console.WriteLine("Color: {0}", color);

        if (estado)
        {
            System.Console.WriteLine("Estado: abierta");
        }
        else
        {
            System.Console.WriteLine("Estado: cerrada");
        }

        if (estadoDeBloqueo)
        {
            System.Console.WriteLine("Estado de bloqueo: Boqueado");
        }
        else
        {
            System.Console.WriteLine("Estado de bloqueo: Desbloqueado");
        }
    }

}