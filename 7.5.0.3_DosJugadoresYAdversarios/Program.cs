/*
Una alternativa mucho menos peligrosa (pero que, a cambio, complica el
programa principal), es que sea el programa principal el que indique a cada
jugador quién es su adversario
*/

using System;

public class Program
{
    static void Main()
    {

        Jugador j1 = new Jugador();
        Jugador j2 = new Jugador();
        j1.SetAdversario(j2);
        j2.SetAdversario(j1);

        System.Console.WriteLine("j1 - Adversario: {0}", j2.MostrarAdversario());
        System.Console.WriteLine("j2 - Adversario: {0}", j1.MostrarAdversario());

    }
}

public class Jugador
{
    protected Jugador adversario;
    public void SetAdversario(Jugador newAdversario)
    {
        this.adversario = newAdversario;
    }

    public Jugador MostrarAdversario()
    {
        return adversario;
    }
}